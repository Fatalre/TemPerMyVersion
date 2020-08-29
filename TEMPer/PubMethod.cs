// Decompiled with JetBrains decompiler
// Type: TEMPer.PubMethod
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using Microsoft.Win32;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Xml;
using TEMPer.Properties;

namespace TEMPer
{
  internal class PubMethod
  {
    public static IntPtr pDevice;
    public static ushort inputLength;
    public static ushort outputLength;
    public static ulong lpNumberOfBytesWritten;
    public static ulong lpNumberOfBytesReaden;
    public static bool isOpen = false;
    public static double calib1 = 0.0;
    public static double calib2 = 0.0;
    public static double calib3 = 0.0;
    public static double calib4 = 0.0;
    public static string version = "";
    public static int type = 0;
    public static string data1;
    public static string data2;
    public static string data3;
    public static string data4;
    public static int innerSensor = 0;
    public static int outerSensor = 0;
    public static bool isRead = false;
    public static bool isLogin = false;
    public static string loginName;
    public static string loginPass;
    public static string reciveIp = "";
    public static Socket reciveSocket = (Socket) null;
    public static Socket sendSocket = (Socket) null;
    public static byte[] buffer = new byte[1024];
    public static bool isExistRemoteDevice = true;
    public static readonly string configPath = Environment.CurrentDirectory + "\\RDingWebUpdate.exe.config";
    public static string UpdateFilePath = PubMethod.GetConfigValue(nameof (UpdateFilePath));
    public static string SystemName = PubMethod.GetConfigValue("CompareFile");
    public static string LocUrl = PubMethod.GetConfigValue("Url");
    public static string dirDownPath = PubMethod.LocUrl + PubMethod.UpdateFilePath;
    public static string UpdateTime;

    public static string getStringDouble(string str)
    {
      string str1;
      try
      {
        double num = double.Parse(str);
        str1 = Settings.Default.Unit != 2 ? (num <= 125.0 && num >= -40.0 ? num.ToString("F2") : "error") : (num <= 257.0 && num >= -40.0 ? num.ToString("F2") : "error");
      }
      catch
      {
        str1 = "error";
      }
      return str1;
    }

    public static int getStringInteger(string str)
    {
      int num = 0;
      try
      {
        num = int.Parse(str);
      }
      catch
      {
      }
      return num;
    }

    public static string getMaxData(string str, string maxStr)
    {
      double num1;
      try
      {
        num1 = double.Parse(maxStr);
      }
      catch
      {
        num1 = -50000.0;
      }
      try
      {
        double num2 = double.Parse(str);
        if (num2 > 199.0 || num2 <= num1)
          return num1.ToString("F2");
        num1 = num2;
      }
      catch
      {
      }
      return num1.ToString("F2");
    }

    public static string getMinData(string str, string minStr)
    {
      double num1;
      try
      {
        num1 = double.Parse(minStr);
      }
      catch
      {
        num1 = 50000.0;
      }
      try
      {
        double num2 = double.Parse(str);
        if (num2 > 199.0 || num2 >= num1)
          return num1.ToString("F2");
        num1 = num2;
      }
      catch
      {
      }
      return num1.ToString("F2");
    }

    public static string getAvgData(string str, string avgStr, int count)
    {
      double num1;
      try
      {
        num1 = double.Parse(avgStr);
      }
      catch
      {
        num1 = 50000.0;
      }
      try
      {
        double num2 = double.Parse(str);
        num1 += (num2 - num1) / (double) (count + 1);
      }
      catch
      {
      }
      return num1.ToString("F2");
    }

    public static string getTime() => DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

    public static string getMille() => DateTime.Now.ToString("HH:mm:ss");

    public static double getCurveData(string data)
    {
      double num;
      try
      {
        num = double.Parse(data);
      }
      catch
      {
        num = -100.0;
      }
      return num;
    }

    public static int getFileRowNum(string fileName)
    {
      int num = 0;
      StreamReader streamReader = System.IO.File.OpenText(fileName);
      string str = streamReader.ReadLine();
      while (null != str)
      {
        str = streamReader.ReadLine();
        ++num;
      }
      streamReader.Close();
      return num;
    }

    public static double getCalib(int op)
    {
      double num = 0.0;
      switch (op)
      {
        case 1:
          num = PubMethod.calib1;
          break;
        case 2:
          num = PubMethod.calib2;
          break;
        case 3:
          num = PubMethod.calib3;
          break;
        case 4:
          num = PubMethod.calib4;
          break;
      }
      return num;
    }

    public static byte[] getCailbByte(int tag, double d)
    {
      byte[] numArray = new byte[9]
      {
        (byte) 0,
        (byte) 1,
        (byte) 129,
        (byte) 85,
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
      };
      if (PubMethod.type == 6)
      {
        for (int index = 0; index < 4; ++index)
          numArray[index + 4] = tag != index + 1 ? PubMethod.getSetByte(PubMethod.getCalib(index + 1)) : PubMethod.getSetByte(d);
      }
      else
      {
        switch (tag)
        {
          case 1:
            numArray[5] = PubMethod.getSetByte(d);
            if (PubMethod.type == 3)
            {
              numArray[6] = PubMethod.getSetByte(PubMethod.calib3);
              break;
            }
            break;
          case 2:
            numArray[6] = PubMethod.getSetByte(d);
            if (PubMethod.type == 5)
            {
              numArray[5] = PubMethod.getSetByte(PubMethod.calib1);
              break;
            }
            break;
          case 3:
            switch (PubMethod.type)
            {
              case 1:
                numArray[6] = PubMethod.getSetByte(PubMethod.calib4);
                numArray[5] = PubMethod.getSetByte(d);
                break;
              case 2:
                numArray[5] = PubMethod.getSetByte(d);
                break;
              case 3:
                numArray[5] = PubMethod.getSetByte(PubMethod.calib1);
                numArray[6] = PubMethod.getSetByte(d);
                break;
            }
            break;
          case 4:
            if (PubMethod.type == 1)
            {
              numArray[5] = PubMethod.getSetByte(PubMethod.calib3);
              numArray[6] = PubMethod.getSetByte(d);
              break;
            }
            break;
        }
      }
      return numArray;
    }

    private static byte getSetByte(double val) => PubMethod.type != 6 ? (val >= 0.0 ? Convert.ToByte(val / (1.0 / 16.0)) : Convert.ToByte(256.0 + (double) Convert.ToSByte(val) / (1.0 / 16.0))) : (val >= 0.0 ? Convert.ToByte(val * 10.0) : Convert.ToByte(256.0 + val * 10.0));

    public static bool HasUpdate()
    {
      try
      {
        string configValue = PubMethod.GetConfigValue("UpDateTime");
        string thePreUpdateTime = PubMethod.GetThePreUpdateTime(PubMethod.dirDownPath + "/AutoUpdate.xml");
        if (string.IsNullOrEmpty(thePreUpdateTime) || string.IsNullOrEmpty(configValue) || DateTime.Compare(Convert.ToDateTime(thePreUpdateTime, (IFormatProvider) CultureInfo.InvariantCulture), Convert.ToDateTime(configValue, (IFormatProvider) CultureInfo.InvariantCulture)) <= 0)
          return false;
        PubMethod.UpdateTime = thePreUpdateTime;
        return true;
      }
      catch
      {
        return false;
      }
    }

    public static string GetConfigValue(string appKey)
    {
      XmlDocument xmlDocument = new XmlDocument();
      try
      {
        xmlDocument.Load(PubMethod.configPath);
        XmlElement xmlElement = (XmlElement) xmlDocument.SelectSingleNode("//appSettings").SelectSingleNode("//add[@key=\"" + appKey + "\"]");
        return xmlElement != null ? xmlElement.GetAttribute("value") : "";
      }
      catch
      {
        return "";
      }
    }

    public static string GetThePreUpdateTime(string Dir)
    {
      string str = "";
      try
      {
        WebRequest webRequest = WebRequest.Create(Dir);
        webRequest.Timeout = 3000;
        Stream responseStream = webRequest.GetResponse().GetResponseStream();
        XmlTextReader xmlTextReader = new XmlTextReader(responseStream);
        while (xmlTextReader.Read())
        {
          if (xmlTextReader.Name == "UpdateTime")
          {
            str = xmlTextReader.GetAttribute("Date");
            break;
          }
        }
        xmlTextReader.Close();
        responseStream.Close();
        return str;
      }
      catch
      {
        return (string) null;
      }
    }

    public static void SetAutoRun(string fileName, bool isAutoRun)
    {
      RegistryKey registryKey = (RegistryKey) null;
      try
      {
        string name = System.IO.File.Exists(fileName) ? fileName.Substring(fileName.LastIndexOf("\\") + 1) : throw new Exception("ERROR,NO the file!");
        registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true) ?? Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
        if (isAutoRun)
          registryKey.SetValue(name, (object) fileName);
        else
          registryKey.SetValue(name, (object) false);
      }
      catch (Exception ex)
      {
        ex.Message.ToString();
      }
      finally
      {
        registryKey?.Close();
      }
    }
  }
}

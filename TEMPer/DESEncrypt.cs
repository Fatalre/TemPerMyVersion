// Decompiled with JetBrains decompiler
// Type: TEMPer.DESEncrypt
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TEMPer
{
  public class DESEncrypt
  {
    public static string Encrypt(string Text) => DESEncrypt.Encrypt(Text, "PCsensor");

    public static string Encrypt(string Text, string sKey)
    {
      try
      {
        DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
        byte[] bytes = Encoding.Default.GetBytes(Text);
        cryptoServiceProvider.Key = Encoding.ASCII.GetBytes(sKey);
        cryptoServiceProvider.IV = Encoding.ASCII.GetBytes(sKey);
        MemoryStream memoryStream = new MemoryStream();
        CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, cryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
        cryptoStream.Write(bytes, 0, bytes.Length);
        cryptoStream.FlushFinalBlock();
        StringBuilder stringBuilder = new StringBuilder();
        foreach (byte num in memoryStream.ToArray())
          stringBuilder.AppendFormat("{0:X2}", (object) num);
        return stringBuilder.ToString();
      }
      catch
      {
        throw new Exception("Encrypt Error!");
      }
    }

    public static string Decrypt(string Text) => DESEncrypt.Decrypt(Text, "PCsensor");

    public static string Decrypt(string Text, string sKey)
    {
      try
      {
        DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
        int length = Text.Length / 2;
        byte[] buffer = new byte[length];
        for (int index = 0; index < length; ++index)
        {
          int int32 = Convert.ToInt32(Text.Substring(index * 2, 2), 16);
          buffer[index] = (byte) int32;
        }
        cryptoServiceProvider.Key = Encoding.ASCII.GetBytes(sKey);
        cryptoServiceProvider.IV = Encoding.ASCII.GetBytes(sKey);
        MemoryStream memoryStream = new MemoryStream();
        CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, cryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write);
        cryptoStream.Write(buffer, 0, buffer.Length);
        cryptoStream.FlushFinalBlock();
        return Encoding.Default.GetString(memoryStream.ToArray());
      }
      catch
      {
        throw new Exception("Decrypt Error!");
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: TEMPer.AssemblyInDataParser
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System;
using System.Collections.Generic;

namespace TEMPer
{
  public class AssemblyInDataParser
  {
    private string m_header;
    private string m_command;
    private List<string> m_names;
    private List<string> m_values;

    public string Header => this.m_header;

    public string Command => this.m_command;

    public List<string> Names => this.m_names;

    public List<string> Values => this.m_values;

    public AssemblyInDataParser()
    {
      this.m_names = new List<string>();
      this.m_values = new List<string>();
    }

    public bool DecodeProtocolText(string protocolText)
    {
      this.m_header = "";
      this.m_names.Clear();
      this.m_values.Clear();
      if (protocolText.IndexOf(ProtocolKeys.ReturnWrap) < 0)
        return false;
      string[] strArray1 = protocolText.Split(new string[1]
      {
        ProtocolKeys.ReturnWrap
      }, StringSplitOptions.RemoveEmptyEntries);
      if (strArray1.Length < 2)
        return false;
      for (int index = 0; index < strArray1.Length; ++index)
      {
        string[] strArray2 = strArray1[index].Split(new string[1]
        {
          ProtocolKeys.ColonSign
        }, StringSplitOptions.None);
        if (strArray2.Length > 1)
        {
          if (strArray2.Length > 2)
            return false;
          if (strArray2[0].Equals(ProtocolKeys.Command, StringComparison.CurrentCultureIgnoreCase))
          {
            this.m_command = strArray2[1];
          }
          else
          {
            this.m_names.Add(strArray2[0].ToLower());
            this.m_values.Add(strArray2[1]);
          }
        }
      }
      return true;
    }

    public List<string> GetValue(string protocolKey)
    {
      List<string> stringList = new List<string>();
      for (int index = 0; index < this.m_names.Count; ++index)
      {
        if (protocolKey.Equals(this.m_names[index], StringComparison.CurrentCultureIgnoreCase))
          stringList.Add(this.m_values[index]);
      }
      return stringList;
    }

    public bool GetValue(string protocolKey, ref string value)
    {
      int index = this.m_names.IndexOf(protocolKey.ToLower());
      if (index <= -1)
        return false;
      value = this.m_values[index];
      return true;
    }
  }
}

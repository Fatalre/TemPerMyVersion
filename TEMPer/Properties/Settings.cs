// Decompiled with JetBrains decompiler
// Type: TEMPer.Properties.Settings
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TEMPer.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }

    [DefaultSettingValue("D:\\PCsensor\\Data")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public string FilePath
    {
      get => (string) this[nameof (FilePath)];
      set => this[nameof (FilePath)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("1000")]
    [DebuggerNonUserCode]
    public double tempUpper1
    {
      get => (double) this[nameof (tempUpper1)];
      set => this[nameof (tempUpper1)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("-1000")]
    public double tempLower1
    {
      get => (double) this[nameof (tempLower1)];
      set => this[nameof (tempLower1)] = (object) value;
    }

    [DefaultSettingValue("1000")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public double tempUpper2
    {
      get => (double) this[nameof (tempUpper2)];
      set => this[nameof (tempUpper2)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("1000")]
    [UserScopedSetting]
    public double tempUpper3
    {
      get => (double) this[nameof (tempUpper3)];
      set => this[nameof (tempUpper3)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("1000")]
    public double tempUpper4
    {
      get => (double) this[nameof (tempUpper4)];
      set => this[nameof (tempUpper4)] = (object) value;
    }

    [DefaultSettingValue("-1000")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public double tempLower2
    {
      get => (double) this[nameof (tempLower2)];
      set => this[nameof (tempLower2)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("-1000")]
    public double tempLower3
    {
      get => (double) this[nameof (tempLower3)];
      set => this[nameof (tempLower3)] = (object) value;
    }

    [DefaultSettingValue("-1000")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public double tempLower4
    {
      get => (double) this[nameof (tempLower4)];
      set => this[nameof (tempLower4)] = (object) value;
    }

    [DefaultSettingValue("1")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public int Interval
    {
      get => (int) this[nameof (Interval)];
      set => this[nameof (Interval)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("2")]
    public int Language
    {
      get => (int) this[nameof (Language)];
      set => this[nameof (Language)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("1")]
    [UserScopedSetting]
    public int Unit
    {
      get => (int) this[nameof (Unit)];
      set => this[nameof (Unit)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("1")]
    public int CloseOperate
    {
      get => (int) this[nameof (CloseOperate)];
      set => this[nameof (CloseOperate)] = (object) value;
    }

    [DefaultSettingValue("1")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public int FileType
    {
      get => (int) this[nameof (FileType)];
      set => this[nameof (FileType)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("50000")]
    public int FileMax
    {
      get => (int) this[nameof (FileMax)];
      set => this[nameof (FileMax)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("2")]
    [DebuggerNonUserCode]
    public int SoundAlarm
    {
      get => (int) this[nameof (SoundAlarm)];
      set => this[nameof (SoundAlarm)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("")]
    public string SoundPath
    {
      get => (string) this[nameof (SoundPath)];
      set => this[nameof (SoundPath)] = (object) value;
    }

    [DefaultSettingValue("")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string SendAccount
    {
      get => (string) this[nameof (SendAccount)];
      set => this[nameof (SendAccount)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("")]
    [DebuggerNonUserCode]
    public string SendPass
    {
      get => (string) this[nameof (SendPass)];
      set => this[nameof (SendPass)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string SendSmtp
    {
      get => (string) this[nameof (SendSmtp)];
      set => this[nameof (SendSmtp)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    [UserScopedSetting]
    public string SendPort
    {
      get => (string) this[nameof (SendPort)];
      set => this[nameof (SendPort)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string ReciveName1
    {
      get => (string) this[nameof (ReciveName1)];
      set => this[nameof (ReciveName1)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("")]
    [DebuggerNonUserCode]
    public string ReciveName2
    {
      get => (string) this[nameof (ReciveName2)];
      set => this[nameof (ReciveName2)] = (object) value;
    }

    [DefaultSettingValue("")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string ReciveAccount1
    {
      get => (string) this[nameof (ReciveAccount1)];
      set => this[nameof (ReciveAccount1)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    [UserScopedSetting]
    public string ReciveAccount2
    {
      get => (string) this[nameof (ReciveAccount2)];
      set => this[nameof (ReciveAccount2)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("")]
    [DebuggerNonUserCode]
    public string Subject
    {
      get => (string) this[nameof (Subject)];
      set => this[nameof (Subject)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("")]
    public string Content
    {
      get => (string) this[nameof (Content)];
      set => this[nameof (Content)] = (object) value;
    }

    [DefaultSettingValue("1")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public int SendType
    {
      get => (int) this[nameof (SendType)];
      set => this[nameof (SendType)] = (object) value;
    }

    [DefaultSettingValue("1")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public int SendInterval
    {
      get => (int) this[nameof (SendInterval)];
      set => this[nameof (SendInterval)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("0")]
    [DebuggerNonUserCode]
    public int SendStart
    {
      get => (int) this[nameof (SendStart)];
      set => this[nameof (SendStart)] = (object) value;
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool IsRember
    {
      get => (bool) this[nameof (IsRember)];
      set => this[nameof (IsRember)] = (object) value;
    }

    [DefaultSettingValue("")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string UserName
    {
      get => (string) this[nameof (UserName)];
      set => this[nameof (UserName)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("")]
    public string PassWord
    {
      get => (string) this[nameof (PassWord)];
      set => this[nameof (PassWord)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("℃")]
    [DebuggerNonUserCode]
    public string set
    {
      get => (string) this[nameof (set)];
      set => this[nameof (set)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    public bool isAutoRun
    {
      get => (bool) this[nameof (isAutoRun)];
      set => this[nameof (isAutoRun)] = (object) value;
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool EnableSSL
    {
      get => (bool) this[nameof (EnableSSL)];
      set => this[nameof (EnableSSL)] = (object) value;
    }
  }
}

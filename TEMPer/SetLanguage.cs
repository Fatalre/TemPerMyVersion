// Decompiled with JetBrains decompiler
// Type: TEMPer.SetLanguage
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace TEMPer
{
  internal class SetLanguage
  {
    public static void SetLang(string lang, Form form, System.Type frmtype)
    {
      Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
      if (form == null)
        return;
      ComponentResourceManager resources = new ComponentResourceManager(frmtype);
      resources.ApplyResources((object) form, "$this");
      SetLanguage.AppLang((Control) form, resources);
    }

    private static void AppLang(Control control, ComponentResourceManager resources)
    {
      try
      {
        foreach (Control control1 in (ArrangedElementCollection) control.Controls)
        {
          resources.ApplyResources((object) control1, control1.Name);
          SetLanguage.AppLang(control1, resources);
        }
      }
      catch
      {
      }
    }
  }
}

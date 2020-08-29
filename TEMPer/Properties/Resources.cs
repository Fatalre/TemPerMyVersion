// Decompiled with JetBrains decompiler
// Type: TEMPer.Properties.Resources
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TEMPer.Properties
{
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) TEMPer.Properties.Resources.resourceMan, (object) null))
          TEMPer.Properties.Resources.resourceMan = new ResourceManager("TEMPer.Properties.Resources", typeof (TEMPer.Properties.Resources).Assembly);
        return TEMPer.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => TEMPer.Properties.Resources.resourceCulture;
      set => TEMPer.Properties.Resources.resourceCulture = value;
    }
  }
}

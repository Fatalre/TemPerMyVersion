// Decompiled with JetBrains decompiler
// Type: TEMPer.HttpPostHelp
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace TEMPer
{
  internal class HttpPostHelp
  {
    public static string PostSend(string url, Dictionary<string, string> dictionary)
    {
      try
      {
        using (WebClient webClient = new WebClient())
        {
          NameValueCollection data = new NameValueCollection();
          foreach (KeyValuePair<string, string> keyValuePair in dictionary)
            data.Add(keyValuePair.Key, keyValuePair.Value);
          return Encoding.UTF8.GetString(webClient.UploadValues(url, "POST", data));
        }
      }
      catch
      {
        return (string) null;
      }
    }

    public static string GetSend(string url, Dictionary<string, string> dictionary)
    {
      try
      {
        using (WebClient webClient = new WebClient())
        {
          if (dictionary != null)
          {
            foreach (KeyValuePair<string, string> keyValuePair in dictionary)
              url = url + keyValuePair.Key + "=" + keyValuePair.Value;
          }
          return webClient.DownloadString(url);
        }
      }
      catch
      {
        return "0x1";
      }
    }
  }
}

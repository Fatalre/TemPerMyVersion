// Decompiled with JetBrains decompiler
// Type: TEMPer.DESncrypt
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TEMPer
{
  internal class DESncrypt
  {
    public static string Encrypt3DES(string Text) => DESncrypt.Encrypt3DES(Text, "wwwwwwwwwww.pcsensor.com");

    public static string Encrypt3DES(string a_strString, string a_strKey)
    {
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      cryptoServiceProvider.Key = Encoding.ASCII.GetBytes(a_strKey);
      cryptoServiceProvider.Mode = CipherMode.ECB;
      ICryptoTransform encryptor = cryptoServiceProvider.CreateEncryptor();
      byte[] bytes = Encoding.ASCII.GetBytes(a_strString);
      return Convert.ToBase64String(encryptor.TransformFinalBlock(bytes, 0, bytes.Length));
    }

    public static string Decrypt3DES(string Text) => DESncrypt.Decrypt3DES(Text, "wwwwwwwwwww.pcsensor.com");

    public static string Decrypt3DES(string a_strString, string a_strKey)
    {
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      cryptoServiceProvider.Key = Encoding.ASCII.GetBytes(a_strKey);
      cryptoServiceProvider.Mode = CipherMode.ECB;
      cryptoServiceProvider.Padding = PaddingMode.PKCS7;
      ICryptoTransform decryptor = cryptoServiceProvider.CreateDecryptor();
      string str = "";
      try
      {
        byte[] inputBuffer = Convert.FromBase64String(a_strString);
        str = Encoding.ASCII.GetString(decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
      }
      catch (Exception ex)
      {
                MessageBox.Show(ex.ToString());
      }
      return str;
    }
  }
}

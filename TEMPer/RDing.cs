// Decompiled with JetBrains decompiler
// Type: TEMPer.RDing
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System;
using System.Runtime.InteropServices;

namespace TEMPer
{
  internal class RDing
  {
    [DllImport("RDingUSB.dll")]
    public static extern IntPtr OpenUSBDevice(int VID, int PID);

    [DllImport("RDingUSB.dll")]
    public static extern IntPtr CloseUSBDevice(IntPtr hDevice);

    [DllImport("RDingUSB.dll")]
    public static extern bool WriteUSB(
      IntPtr hDevice,
      byte[] pBuffer,
      uint dwBytesToWrite,
      ref ulong lpNumberOfBytesWritten);

    [DllImport("RDingUSB.dll")]
    public static extern bool ReadUSB(
      IntPtr hDevice,
      byte[] pBuffer,
      uint dwBytesToRead,
      ref ulong lpNumberOfBytesRead);

    [DllImport("RDingUSB.dll")]
    public static extern ushort GetInputLength(IntPtr hDevice);

    [DllImport("RDingUSB.dll")]
    public static extern ushort GetOutputLength(IntPtr hDevice);

    [DllImport("RDingUSB.dll")]
    public static extern uint GetErrorMsg(ref string[] lpErrorMsg, uint dwErrorMsgSize);
  }
}

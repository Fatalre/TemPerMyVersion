// Decompiled with JetBrains decompiler
// Type: TEMPer.IpDAL
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TEMPer
{
  internal class IpDAL
  {
    public static Socket GetSocket(string ip, int port)
    {
      Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
      TcpClient tcpClient = new TcpClient(AddressFamily.InterNetwork);
      try
      {
        IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
        socket.BeginConnect((EndPoint) ipEndPoint, (AsyncCallback) null, (object) socket).AsyncWaitHandle.WaitOne(1000, true);
        if (socket.Connected)
        {
          socket.ReceiveTimeout = 2000;
          socket.SendTimeout = 2000;
        }
      }
      catch
      {
      }
      return socket;
    }

    public static string sendOrder(string order, Socket client)
    {
      string str = "";
      try
      {
        if (client.Connected)
        {
          byte[] bytes = Encoding.UTF8.GetBytes(order);
          byte[] numArray = new byte[client.ReceiveBufferSize];
          client.Send(bytes, bytes.Length, SocketFlags.None);
          Thread.Sleep(500);
          client.Receive(numArray);
          str = Encoding.UTF8.GetString(numArray);
        }
      }
      catch (Exception ex)
      {
                MessageBox.Show(ex.ToString());
      }
      return str;
    }

    public static void returnOrder(string order, Socket client)
    {
      try
      {
        if (!client.Connected)
          return;
        byte[] bytes = Encoding.UTF8.GetBytes(order);
        byte[] numArray = new byte[client.ReceiveBufferSize];
        client.Send(bytes, bytes.Length, SocketFlags.None);
      }
      catch (Exception ex)
      {
                MessageBox.Show(ex.ToString());
      }
    }
  }
}

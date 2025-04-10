using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace ClientUpdater
{
    class Client
    {
        private Socket socket = null;
        private bool receiving = false;
       

        public Client(String Address, int port)
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(Address, port);
                socket.BeginReceive(new byte[] { 0 }, 0, 0, 0, callback, null);
            }
            catch (SecurityException ex)
            {
                throw new Exception("Fehler beim Herstellen der Verbindung zum Server, evtl. verursacht durch eine Firewall oder ähnliche Schutzmechanismen", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Herstellen der Verbindung zum Server", ex);
            }
        }

        public int send(Byte[] data)
        {
            if (socket == null) return 0;
            if (data == null) return 0;
            if (data.Length <= 0) return 0;
            if (receiving) return 0;
            try
            {
                return socket.Send(data);
            }
            catch (SocketException)
            {
                socket.Close();
                socket = null;
                return 0;
            }
            catch (ObjectDisposedException)
            {
                socket.Close();
                socket = null;
                return 0;
            }
            catch (Exception)
            {
                socket.Close();
                socket = null;
                return 0;
            }
        }

        public void close()
        {
            if (receiving) return;
            if (socket == null) return;

            PacketWriter pw = new PacketWriter();
            pw.Write((ushort)Headers.Exit);
            byte[] data = pw.GetBytes();
            send(data);

            socket.Close();
            socket.Dispose();
            socket = null;
            receiving = false;
        }


       

        void callback(IAsyncResult AR)
        {
            try
            {
                socket.EndReceive(AR);

                byte[] buf = new byte[8192];
                int rec = socket.Receive(buf, buf.Length, 0);
                if (rec < buf.Length)
                {
                    Array.Resize<byte>(ref buf, rec);
                }
                if (Recived != null)
                {
                    Recived(this, buf);
                }
                socket.BeginReceive(new byte[] { 0 }, 0, 0, 0, callback, null);
            }
            catch (Exception)
            {

                Close();
            }
        }
        public void Close()
        {
            socket.Close();
            socket.Dispose();
        }

        public delegate void ClientRecivedHandler(Client sender, byte[] date);
        public event ClientRecivedHandler Recived;
    }
}

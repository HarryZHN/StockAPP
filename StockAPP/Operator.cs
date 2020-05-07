using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace StockAPP
{
    public class Operator
    {
        public void SendMsg(Socket socket,string msg)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            socket.Send(buffer);
        }

        public string GetIP()
        {
            try
            {
                IPHostEntry IPHE = new IPHostEntry();
                IPHE = Dns.GetHostEntry(Dns.GetHostName());
                string ips = "";
                for (int i = 0; i < IPHE.AddressList.Length; i++)
                {
                    if (IPHE.AddressList[i].ToString().Length < 7)
                    {
                        continue;
                    }
                    if (IPHE.AddressList[i].ToString().IndexOf(":") > 0)
                    {
                        continue;
                    }
                    ips = ips + IPHE.AddressList[i].ToString() + ";";
                    return ips.Substring(0, ips.Length - 1);
                }
                return "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public void Show(Form form,string msg)
        {
            MsgBox msgBox = new MsgBox(msg);
            msgBox.Owner = form;
            msgBox.ShowDialog();
        }
    }
}

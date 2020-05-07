using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockAPP
{
    public partial class MsgBox : Form
    {
        public string Msg;
        public MsgBox(string msg)
        {
            this.Msg = msg;
            InitializeComponent();
        }

        private void MsgBox_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            info.Text = Msg;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            
            Thread.Sleep(1000);
            this.Dispose();
        }
    }
}

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

namespace AsyncAwaitUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Task.Run(() => { DoWork();  });
            int begin = DateTime.Now.Millisecond;
            for (int i = begin; i <= begin + 100; i++) {
                label1.Text = i.ToString();
                if (i % 2 == 0)
                {
                    label1.ForeColor = Color.Blue;
                }
                else
                {
                    label1.ForeColor = Color.Green;
                }
                await Task.Run(() => { Thread.Sleep(1);  });
            }
        }
    }
}

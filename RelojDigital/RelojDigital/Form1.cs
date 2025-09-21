using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelojDigital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IniciarReloj();
        }

        private async void IniciarReloj()
        {

            while (!this.IsDisposed)
            {

                label1.Text = DateTime.Now.ToString("T");
                await Task.Delay(1000);

            }
        }
    }
}

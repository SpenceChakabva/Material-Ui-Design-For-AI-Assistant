using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Material_Ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mytime.Start();
            datelbl.Text = DateTime.Now.ToLongDateString();
        }

        private void mytime_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

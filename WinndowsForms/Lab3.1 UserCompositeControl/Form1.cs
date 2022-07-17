using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3._1_UserCompositeControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userControlTimer1.TimeEnabled == true)
            {
                userControlTimer1.TimeEnabled = false;
            }
            else
            {
                userControlTimer1.TimeEnabled = true;
            }
                
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._5._2_newUserForm
{
    public partial class OpenButton : Form
    {

        public OpenButton()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           ChildForm newChild = new ChildForm();
           newChild.MdiParent = this;
            newChild.Show();
        }
    }
}

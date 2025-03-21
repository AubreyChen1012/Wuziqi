using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 欢乐五子棋
{
    public partial class IPForm : Form
    {
        public IPForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            JGForm form6 = new JGForm();
            form6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

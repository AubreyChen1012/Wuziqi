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
    public partial class QPYS : Form
    {
        public QPYS()
        {
            InitializeComponent();
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int tdm = int.Parse(textBox1.Text);
            int R= int.Parse(textBox2.Text);
           int G= int.Parse(textBox3.Text);
          int B=  int.Parse(textBox4.Text);
            ChessBoard.pn = new Pen(Color.FromArgb(tdm, R, G, B));
            EVWMain.start = false;
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QPYS_Load(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
                try
                {
                    this.pictureBox1.BackColor = Color.FromArgb(0 + int.Parse(textBox1.Text), 0 + int.Parse(textBox2.Text), 0 + int.Parse(textBox3.Text), 0 + int.Parse(textBox4.Text));

                }
                catch (Exception)
                {
                    
                   
                }
                
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           
                try
                {
                    this.pictureBox1.BackColor = Color.FromArgb(0 + int.Parse(textBox1.Text), 0 + int.Parse(textBox2.Text), 0 + int.Parse(textBox3.Text), 0 + int.Parse(textBox4.Text));

                }
                catch (Exception)
                {


                }

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
                try
                {
                    this.pictureBox1.BackColor = Color.FromArgb(0 + int.Parse(textBox1.Text), 0 + int.Parse(textBox2.Text), 0 + int.Parse(textBox3.Text), 0 + int.Parse(textBox4.Text));

                }
                catch (Exception)
                {


                }

            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
                try
                {
                    this.pictureBox1.BackColor = Color.FromArgb(0 + int.Parse(textBox1.Text), 0 + int.Parse(textBox2.Text), 0 + int.Parse(textBox3.Text), 0 + int.Parse(textBox4.Text));

                }
                catch (Exception)
                {


                }

            
        }

    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 退出游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form2= new Form5();
            form2.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本产品由陈进狗，李尾狗和他们最最最敬畏，崇拜的风流倜傥英俊潇洒风度翩翩文物双全彬彬有礼智商高达360的邓组长赞助播出", "关于");
        }

        private void 背景ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 自定义ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form7 form = new Form7();
                form.ShowDialog();
                this.BackgroundImage = Image.FromFile(form.a);
            }
            catch (Exception)
            {
                MessageBox.Show("路径输入有误或您关闭了窗口");
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("五子棋游戏源远流长，它源于古代中国，发展于日本，风靡于欧洲。五子棋不仅能增强思维能力，提高智力，而且富含哲理，有助于修身养性。五子棋既有现代休闲的明显特征“短、平、快”，又有古典哲学的高深学问“阴阳易理”；它既有简单易学的特性，为人民群众所喜闻乐见，又有深奥的技巧和高水平的国际性比赛；它的棋文化源渊流长，具有东方的神秘和西方的直观；既有“场”的概念，亦有“点”的连接。它是中西文化的交流点，是古今哲理的结晶。本系统实现了网络五子棋游戏，身临其境的体验进行网络五子棋游戏！功能包括游戏、设置、帮助。采用古典画风,操作简单、直接.。"
                , "帮助");
        }
    }

}

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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //退出游戏
        private void 退出游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //联机对战按钮点击事件
        private void button4_Click(object sender, EventArgs e)
        {
			OLMain ol = new OLMain();
			ol.Show();
			this.Hide();
		}
        //关于
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本产品由愚蠢的陈进狗，李伟军和他们最最最敬畏，崇拜的风流倜傥英俊潇洒风度翩翩文物双全彬彬有礼智商高达250的邓蠢狗赞助播出", "关于");
        }

        //帮助
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("五子棋游戏源远流长，它源于古代中国，发展于日本，风靡于欧洲。五子棋不仅能增强思维能力，提高智力，而且富含哲理，有助于修身养性。五子棋既有现代休闲的明显特征“短、平、快”，又有古典哲学的高深学问“阴阳易理”；它既有简单易学的特性，为人民群众所喜闻乐见，又有深奥的技巧和高水平的国际性比赛；它的棋文化源渊流长，具有东方的神秘和西方的直观；既有“场”的概念，亦有“点”的连接。它是中西文化的交流点，是古今哲理的结晶。本系统实现了网络五子棋游戏，身临其境的体验进行网络五子棋游戏！功能包括游戏、设置、帮助。采用古典画风,操作简单、直接.。");
        }

        //双人对战
        private void btnEvw_Click(object sender, EventArgs e)
        {
            this.Hide();
            EVWMain evw = new EVWMain();//对象实例化
            evw.ShowDialog();
        }

        //人机对战
        
        private void btnCpt_Click(object sender, EventArgs e)
        {
            this.Hide();
            CPTMain cpt = new CPTMain();
            cpt.ShowDialog();
        }


        //退出游戏
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this .StartPosition= FormStartPosition.CenterParent;
            this.Location = new Point(387,185);

            
            if (BGI.MP == 0)
            {
                MP.currentPlaylist.appendItem(MP.newMedia(".\\背景音乐\\出山.MP3"));
                MP.currentPlaylist.appendItem(MP.newMedia(".\\背景音乐\\绿色.MP3"));
                MP.settings.setMode("loop", true);
                MP.settings.autoStart = true;
                MP.Ctlcontrols.play();
            }
            BGI.MP++;
        }

        private void 背景图片十ToolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg10.jpg");
        }

        private void 背景图片九ToolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg9.jpg");
        }

        private void 背景图片一ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg1.jpg");
        }

        private void 背景图片一ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg4.jpg");
        }

        private void 背景图片一ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg5.jpg");
        }

        private void 背景图片一ToolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg6.jpg");
        }

        private void 背景图片一ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg7.jpg");
        }

        private void 背景图片一ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg8.jpg");
        }

        private void 背景图片一ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg2.jpg");
        }

        private void 出山ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MP.Ctlcontrols.stop();
            MP.URL = (".\\背景音乐\\出山.MP3");
        }

        private void 绿色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MP.Ctlcontrols.stop();
            MP.URL = (".\\背景音乐\\绿色.MP3");
        }

        private void 更换背景音乐ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 自定义背景音乐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  BGLuJingForm bg = new BGLuJingForm();
            //bg.Show();
            this.ofd.Filter = "音乐文件|*.mp3;*.mav";
            DialogResult dr = this.ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MP.Ctlcontrols.stop();
                MP.URL = string.Format("{0}", this.ofd.FileName);
            }
        }

        private void 关闭背景音乐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MP.Ctlcontrols.stop();
        }

        private void 打开背景音乐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MP.Ctlcontrols.play();

        }

        private void 自定义ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ofd.Filter = "图片文件|*.jpg;*.png";
            DialogResult dr = this.ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.BackgroundImage = Image.FromFile(string.Format("{0}", this.ofd.FileName));
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }
    }

}
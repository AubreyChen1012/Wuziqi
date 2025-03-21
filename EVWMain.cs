using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 欢乐五子棋
{

    public partial class EVWMain : Form
    {
        public static bool start = false;   // 是否开始
        private bool type = true;   // 玩家
        const int size = 15;  //格子个数
        int gzk = MainSize.gzk;  //格子的宽度
        int r = MainSize.r;   //棋子的半径
        int z = 80; //屏幕距离棋盘左的距离
        int s = 80; //屏幕距离棋盘上的距离
        int bs = 0;  //下棋的步数
        static PictureBox[] hq = new PictureBox[225];//用于悔棋的数组
        PictureBox[,] xs = new PictureBox[size, size]; //用于显示的图片框
        public static bool ZLYJ;
        int index1 = 0;
        int index2 = 1;

        public EVWMain()
        {
            InitializeComponent();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    xs[i, j] = new PictureBox();
                    xs[i, j].Location = new Point(i * 40 + z - 15, j * 40 + s - 15);
                    xs[i, j].Size = new Size(30, 30);
                    xs[i, j].BackColor = Color.Transparent;
                    //xs[i,j].BorderStyle
                    xs[i, j].SizeMode = PictureBoxSizeMode.CenterImage;//棋子显示方式
                    xs[i, j].Visible = false;
                    this.Controls.Add(xs[i, j]);
                }
            }

        }
        private void 退出游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void 返回上级菜单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();
        }

        //悔棋
        private void btnHQ_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你确定要悔棋吗", "悔棋", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                if (bs > 0)
                {
                    int a = bs;
                    bs = EVWStone.hq(hq, bs, z, s);
                    Graphics g = this.CreateGraphics();
                    ChessBoard.DrawCB(g, size, s, z);
                    if (a > bs)
                        type = !type;
                    if (type)                                   //到谁下棋谁显红
                    {
                        label2.ForeColor = Color.Black;
                        label1.ForeColor = Color.Red;
                    }
                    else
                    {
                        label1.ForeColor = Color.Black;
                        label2.ForeColor = Color.Red;
                    }
                }
            if (bs < 1)   //判断步数来是否禁用悔棋按钮 
                btnHQ.Enabled = false;
            else
                btnHQ.Enabled = true;


        }

        //下棋
        private void EVWMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (start)
            {
                Graphics g = this.CreateGraphics();
                EVWStone.cf(e, z, s, hq);
                if (EVWStone.cf(e, z, s, hq))
                {

                    hq[bs] = EVWStone.fuzhi(e, type, r, z, s, hq, bs, xs);
                    bs++;
                    type = !type;
                    StoneVoice();
                    Rule.panduan(size, bs);
                    if (ZLYJ)
                    {
                        btnRStart.PerformClick();//调用再来一局的按钮
                    }
                    设置ToolStripMenuItem.Enabled = false;
                    棋盘颜色ToolStripMenuItem.Enabled = false;
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;


                }

                if (type)
                {
                    label2.ForeColor = Color.Black;
                    label1.ForeColor = Color.Red;
                }
                else
                {
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Red;
                }
                if (bs < 1)
                {
                    btnHQ.Enabled = false;
                }
                else
                {
                    btnHQ.Enabled = true;
                }

            }
        }

        //再来一局
        private void btnRStart_Click(object sender, EventArgs e)
        {
            type = true;
            if (btnRStart.Text == "开始游戏")
            {
                btnRStart.Text = "再来一局";
            }
            start = true;
            Graphics g = this.CreateGraphics();
            for (int i = 0; i < size; i++)          //将所有的棋子重置并隐藏
                for (int j = 0; j < size; j++)
                {
                    xs[i, j].Update();
                    xs[i, j].Visible = false;
                }
            ChessBoard.DrawCB(g, size, s, z);  //重新画棋盘
            EVWStone.kaishi(size);           //初始化棋盘的值 
            设置ToolStripMenuItem.Enabled = true;
            棋盘颜色ToolStripMenuItem.Enabled = true;
            pictureBox1.Enabled = true;       //在开局前选择玩家一棋子的颜色
            pictureBox2.Enabled = true;       //在开局前选择玩家二棋子的颜色


            label2.ForeColor = Color.Black;        //用来显示玩家的下棋时候，红为当前玩家下棋
            label1.ForeColor = Color.Red;      //用来显示玩家的下棋时候，红为当前玩家下棋

        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 落子声音
        /// </summary>
        public void StoneVoice()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "./棋子声音./落子声音.wav";
            player.Load();
            player.Play();
        }
        //根据mainForm的值更改所有窗体背景
        private void EVWMain_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(EVWStone.qzlj1);//用来显示玩家一棋子的颜色
            pictureBox2.Image = Image.FromFile(EVWStone.qzlj2);//用来显示玩家二棋子的颜色
            label1.ForeColor = Color.Red;
            btnHQ.Enabled = false;   //开局禁用悔棋按钮
        }



        private void 背景图片1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg1.jpg");
            start = false;
            btnRStart.Text = "开始游戏";

        }

        private void 背景图片2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg2.jpg");
            start = false;
            btnRStart.Text = "开始游戏";


        }

        private void 背景图片3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg3.jpg");
            start = false;
            btnRStart.Text = "开始游戏";


        }

        private void 背景图片14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg4.jpg");
            start = false;
            btnRStart.Text = "开始游戏";

        }

        private void 背景图片5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg5.jpg");
            start = false;
            btnRStart.Text = "开始游戏";

        }

        private void 背景图片6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg6.jpg");
            start = false;
            btnRStart.Text = "开始游戏";

        }

        private void 背景图片7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg7.jpg");
            start = false;
            btnRStart.Text = "开始游戏";

        }

        private void 背景图片8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg8.jpg");
            start = false;
            btnRStart.Text = "开始游戏";

        }

        private void 背景图片9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg9.jpg");
            start = false;
            btnRStart.Text = "开始游戏";

        }

        private void 背景图片10ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg10.jpg");
            start = false;
            btnRStart.Text = "开始游戏";


        }

        private void 灰色默认ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChessBoard.pn = new Pen(Color.Gray); //棋盘线的颜色为灰色
            Graphics g = this.CreateGraphics();
            ChessBoard.DrawCB(g, size, s, z);
        }

        private void 红色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChessBoard.pn = new Pen(Color.Red); //棋盘线的颜色为灰色
            Graphics g = this.CreateGraphics();
            ChessBoard.DrawCB(g, size, s, z);
        }

        private void 白色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChessBoard.pn = new Pen(Color.Blue); //棋盘线的颜色为白色
            Graphics g = this.CreateGraphics();
            ChessBoard.DrawCB(g, size, s, z);
        }

        private void 黑色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChessBoard.pn = new Pen(Color.Black);//棋盘线的颜色为黑色
            Graphics g = this.CreateGraphics();
            ChessBoard.DrawCB(g, size, s, z);
        }

        private void 自定义颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QPYS q = new QPYS();
            q.Show();
        }



        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            index1++;
            if (index1 == index2)
            {
                index1++;
            }
            if (index1 == 10)
            {
                index1 = 0;
            }
            switch (index1)
            {
                //0 黑 1白 2橙 3粉 4红 5黄 6蓝 7绿 8浅蓝 9青 10紫
                case 0:
                    EVWStone.qzlj1 = ".\\棋子图片\\黑.png";
                    pictureBox1.Image = Image.FromFile(EVWStone.qzlj1);//用来显示玩家一棋子的黑色
                    break;
                case 1:
                    EVWStone.qzlj1 = ".\\棋子图片\\白.png";
                    pictureBox1.Image = Image.FromFile(EVWStone.qzlj1);//用来显示玩家一棋子的颜色
                    break;
                case 2:
                    EVWStone.qzlj1 = ".\\棋子图片\\橙.png";
                    pictureBox1.Image = Image.FromFile(EVWStone.qzlj1);//用来显示玩家一棋子的颜色
                    break;
                case 3:
                    EVWStone.qzlj1 = ".\\棋子图片\\粉红.png";
                    pictureBox1.Image = Image.FromFile(EVWStone.qzlj1);//用来显示玩家一棋子的颜色
                    break;
                case 4:
                    EVWStone.qzlj1 = ".\\棋子图片\\红.png";
                    pictureBox1.Image = Image.FromFile(EVWStone.qzlj1);//用来显示玩家一棋子的颜色
                    break;
                case 5:
                    EVWStone.qzlj1 = ".\\棋子图片\\黄.png";
                    pictureBox1.Image = Image.FromFile(EVWStone.qzlj1);//用来显示玩家一棋子的颜色
                    break;
                case 6:
                    EVWStone.qzlj1 = ".\\棋子图片\\蓝.png";
                    pictureBox1.Image = Image.FromFile(EVWStone.qzlj1);//用来显示玩家一棋子的颜色
                    break;
                case 7:
                    EVWStone.qzlj1 = ".\\棋子图片\\绿.png";
                    pictureBox1.Image = Image.FromFile(EVWStone.qzlj1);//用来显示玩家一棋子的颜色
                    break;
                case 8:
                    EVWStone.qzlj1 = ".\\棋子图片\\浅蓝.png";
                    pictureBox1.Image = Image.FromFile(EVWStone.qzlj1);//用来显示玩家一棋子的颜色
                    break;
                case 9:
                    EVWStone.qzlj1 = ".\\棋子图片\\青.png";
                    pictureBox1.Image = Image.FromFile(EVWStone.qzlj1);//用来显示玩家一棋子的颜色
                    break;
                case 10:
                    EVWStone.qzlj1 = ".\\棋子图片\\紫.png";
                    pictureBox1.Image = Image.FromFile(EVWStone.qzlj1);//用来显示玩家一棋子的颜色
                    break;
                default:
                    break;
            }


        }

        private void PictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            index2++;
            if (index2 == 10)
            {
                index2 = 0;
            }
            if (index1 == index2)
            {
                index2++;
            }
            switch (index2)
            {
                //0 黑 1白 2橙 3粉 4红 5黄 6蓝 7绿 8浅蓝 9青 10紫
                case 0:
                    EVWStone.qzlj2 = ".\\棋子图片\\黑.png";
                    pictureBox2.Image = Image.FromFile(EVWStone.qzlj2);
                    break;
                case 1:
                    EVWStone.qzlj2 = ".\\棋子图片\\白.png";
                    pictureBox2.Image = Image.FromFile(EVWStone.qzlj2);
                    break;
                case 2:
                    EVWStone.qzlj2 = ".\\棋子图片\\橙.png";
                    pictureBox2.Image = Image.FromFile(EVWStone.qzlj2);
                    break;
                case 3:
                    EVWStone.qzlj2 = ".\\棋子图片\\粉红.png";
                    pictureBox2.Image = Image.FromFile(EVWStone.qzlj2);
                    break;
                case 4:
                    EVWStone.qzlj2 = ".\\棋子图片\\红.png";
                    pictureBox2.Image = Image.FromFile(EVWStone.qzlj2);
                    break;
                case 5:
                    EVWStone.qzlj2 = ".\\棋子图片\\黄.png";
                    pictureBox2.Image = Image.FromFile(EVWStone.qzlj2);
                    break;
                case 6:
                    EVWStone.qzlj2 = ".\\棋子图片\\蓝.png";
                    pictureBox2.Image = Image.FromFile(EVWStone.qzlj2);
                    break;
                case 7:
                    EVWStone.qzlj2 = ".\\棋子图片\\绿.png";
                    pictureBox2.Image = Image.FromFile(EVWStone.qzlj2);
                    break;
                case 8:
                    EVWStone.qzlj2 = ".\\棋子图片\\浅蓝.png";
                    pictureBox2.Image = Image.FromFile(EVWStone.qzlj2);
                    break;
                case 9:
                    EVWStone.qzlj2 = ".\\棋子图片\\青.png";
                    pictureBox2.Image = Image.FromFile(EVWStone.qzlj2);
                    break;
                case 10:
                    EVWStone.qzlj2 = ".\\棋子图片\\紫.png";
                    pictureBox2.Image = Image.FromFile(EVWStone.qzlj2);
                    break;
                default:
                    break;
            }


        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本产品由愚蠢的陈进狗，李伟军和他们最最最敬畏，崇拜的风流倜傥英俊潇洒风度翩翩文物双全彬彬有礼智商高达250的邓佑狗赞助播出", "关于");
        }



        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("五子棋游戏源远流长，它源于古代中国，发展于日本，风靡于欧洲。五子棋不仅能增强思维能力，提高智力，而且富含哲理，有助于修身养性。五子棋既有现代休闲的明显特征“短、平、快”，又有古典哲学的高深学问“阴阳易理”；它既有简单易学的特性，为人民群众所喜闻乐见，又有深奥的技巧和高水平的国际性比赛；它的棋文化源渊流长，具有东方的神秘和西方的直观；既有“场”的概念，亦有“点”的连接。它是中西文化的交流点，是古今哲理的结晶。本系统实现了网络五子棋游戏，身临其境的体验进行网络五子棋游戏！功能包括游戏、设置、帮助。采用古典画风,操作简单、直接.。");
        }

        private void 自定义ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.BackgroundImage = Image.FromFile(string.Format("{0}", this.ofd.FileName));
            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            MinimizeBox = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRT_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
        }
    }
}

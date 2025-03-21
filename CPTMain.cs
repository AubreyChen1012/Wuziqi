using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 欢乐五子棋.CPT;

namespace 欢乐五子棋
{
    /// <summary>
    /// CPT主窗体
    /// </summary>
    public partial class CPTMain : Form
    {
        //创建棋盘
        private CPT.CPTChessBoard cb;
        //下棋后禁用先下棋按钮
        public static bool start = true;
        //记录棋子步数
        public static int sum = 0;
        //悔棋临时变量
        private int temp;
        public int[] m = new int[125], n = new int[125];
        //定义棋子数组
        public static PictureBox[,] chesspb = new PictureBox[15, 15];
        //历史添加悔棋记录
        public static bool HQRecord;
        //0(白)1(黑)2(黄)3(蓝)4(绿)5(青)6(橙)7(粉红)8(浅蓝)9(浅绿)10(紫)11(红)
        public static int B = 1, W = 0;
        //开始游玩判断
        public static bool flagPlaying = false;
        public CPTMain()
        {
            InitializeComponent();
            //构造棋盘类
            Graphics g = PBCB.CreateGraphics();
            cb = new CPT.CPTChessBoard(g);
            PBCB.Visible = false;
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 15; j++)
                {
                    chesspb[i, j] = new PictureBox();
                    chesspb[i, j].Location = new Point(5 + 40 * i, 5 + 40 * j);//这是棋子图的左上角坐标
                    chesspb[i, j].Size = new Size(30, 30);///棋子图尺寸
                    chesspb[i, j].BackColor = Color.Transparent;//棋子背景颜色
                    chesspb[i, j].SizeMode = PictureBoxSizeMode.CenterImage;//棋子显示方式
                    chesspb[i, j].Visible = false;//先隐藏棋子
                    PBCB.Controls.Add(chesspb[i, j]);//在指定控件添加PictureBox
                }
        }

        //下棋
        private void PBCB_MouseDown(object sender, MouseEventArgs e)
        {
            cb.PlayerDownStone(e.X, e.Y);
            //记录历史记录
            Array arr = cb.StarckHistory.ToArray();
            History.DataSource = arr;
            m = Stone.m; n = Stone.n;
            //重置倒计时
            this.lblDjs.Text = "30";
            if (start)
            {
                rcpt.Enabled = false;
                rplayer.Enabled = false;
            }
            this.Djs.Start();
            Result();
            this.btnHQ.Enabled = true;
            HQRecord = false;
            sum = Stone.sum;
            toolStripMenuItem1.Enabled = false;

        }

        //开始
        private void btnStart_Click(object sender, EventArgs e)
        {
            //开始游玩
            flagPlaying = true;
            PBCB.Visible = true;
            if (rcpt.Checked)
                cb.Start(true);
            else
                cb.Start(false);
            //清空历史记录
            ArrayList arrl = new ArrayList();
            History.DataSource = arrl;

            //记录历史记录
            Array arr = cb.StarckHistory.ToArray();
            History.DataSource = arr;
            ReDjs();
            if (this.btnStart.Text == "开始")
                this.btnStart.Text = "再来一局";
            else
            {
                this.rcpt.Enabled = true;
                this.rplayer.Enabled = true;
            }
            reset();
            cb.Draw();
            toolStripMenuItem1.Enabled = true;

        }

        //悔棋
        private void btnHQ_Click(object sender, EventArgs e)
        {
            //倒计时暂停
            this.Djs.Stop();
            try
            {
                DialogResult HQflag = MessageBox.Show("请确定是否悔棋！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (HQflag == DialogResult.Yes)
                {
                    temp = sum;
                    for (int i = 0; i < 2; i++)
                    {

                        chesspb[m[temp], n[temp]].Visible = false;
                        chesspb[m[temp], n[temp]].Update();
                        CPTChessBoard.arrcb[m[temp], n[temp]] = 0;
                        PBCB.Update();
                        cb.Draw();
                        temp--;
                    }
                    int count = 0;
                    for (int i = 0; i < 15; i++)
                        for (int j = 0; j < 15; j++)
                            if (chesspb[i, j].Visible == true) count++;
                    if (count == 1)
                        this.btnHQ.Enabled = false;
                    sum -= 2;
                    Stone.sum = sum;
                    //初始化倒计时
                    ReDjs();
                    HQRecord = true;
                }
                else
                    //继续倒计时
                    this.Djs.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("无棋子可悔棋！");
                this.Djs.Start();
                HQRecord = false;
            }
            //测试
            //if (Stone.sum > 0)
            //{
            //	int x1 = (chesspb[Stone.k, Stone.l].Location.X - 5) / 40;

            //	int y1 = (chesspb[Stone.k, Stone.l].Location.Y - 5) / 40;
            //	chesspb[x1, y1].Visible = false;
            //	chesspb[x1, y1].Update();
            //	CPTChessBoard.arrcb[x1, y1] = 0;
            //	PBCB.Update();
            //	cb.Draw();
            //}
        }

        //电脑先
        private void rcpt_CheckedChanged(object sender, EventArgs e)
        {
            //开始游玩
            flagPlaying = true;
            //清空历史记录
            ArrayList arrl = new ArrayList();
            History.DataSource = arrl;
            cb.Start(true);
            PBCB.Visible = true;
            //开始倒计时
            ReDjs();
            //棋盘重置
            reset();
            //显示历史记录
            Array arr = cb.StarckHistory.ToArray();
            History.DataSource = arr;
            //绘制棋盘
            cb.Draw();
        }

        //玩家先
        private void rplayer_CheckedChanged(object sender, EventArgs e)
        {
            //开始游玩
            flagPlaying = true;
            //清空历史记录
            ArrayList arrl = new ArrayList();
            History.DataSource = arrl;
            cb.Start(false);
            PBCB.Visible = true;
            //开始倒计时
            ReDjs();
            //棋盘重置
            reset();
            //显示历史记录
            Array arr = cb.StarckHistory.ToArray();
            History.DataSource = arr;
            //绘制棋盘
            cb.Draw();
        }

        //棋盘重置
        public void reset()
        {
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 15; j++)
                    chesspb[i, j].Visible = false;
            PBCB.Invalidate();
            PBCB.Update();
            sum = 0;
            B = 1; W = 0;
            this.btnBlack.Image = this.StoneType.Images[B];
            this.btnWhite.Image = this.StoneType.Images[W];
        }

        //倒计时
        private void Djs_Tick(object sender, EventArgs e)
        {
            if (cb.result)
                this.Djs.Stop();
            int timer = int.Parse(this.lblDjs.Text);
            timer--;
            //倒计时小于5提出红色文字警告
            if (timer <= 10)
                this.lblDjs.ForeColor = Color.Red;
            else
                this.lblDjs.ForeColor = Color.Black;
            this.lblDjs.Text = timer.ToString();
            //倒计时为0则重置
            if (this.lblDjs.Text=="0"&&timer==0)
            {
                Array arr = cb.StarckHistory.ToArray();
                History.DataSource = arr;
                this.lblDjs.Text = "30";
                m = Stone.m; n = Stone.n;
                sum = Stone.sum;
                this.btnHQ.Enabled = true; 
                cb.ComputerDownStone();
                cb.ComputerDownStone();
                sum += 2;
            }
        }

        //判断结果
        public void Result()
        {
            //判断是否再来一局，否则返回主界面
            if (CPTChessBoard.resultflag == DialogResult.Yes)
            {
                rcpt.Enabled = true;
                rplayer.Enabled = true;
                //显示历史记录
                ArrayList arr = new ArrayList();
                History.DataSource = arr;
                //实现指定模式再来一局
                if (rcpt.Checked)
                    cb.Start(true);
                else
                    cb.Start(false);
                //初始化倒计时
                ReDjs();
                reset();
                cb.Draw();
            }
            else if (CPTChessBoard.resultflag == DialogResult.No)
            {
                //返回主界面Mainform
                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
                this.Close();
            }
            //清空结果判断
            CPTChessBoard.resultflag = 0;
        }

        //重置倒计时
        public void ReDjs()
        {
            this.lblDjs.Text = "30";
            this.Djs.Start();
        }

        //白棋换子
        private void BtnWhite_Click(object sender, EventArgs e)
        {

            if (flagPlaying)
            {
                W++;
                if (W == this.StoneType.Images.Count)
                {
                    W = 0;
                }
                if (B == W) W++;

                if (W == this.StoneType.Images.Count)
                {
                    W = 0;
                }
                //绘制棋子颜色
                this.btnWhite.Image = this.StoneType.Images[W];
                Stone.ChangeStone(B, W);
            }
            else
            {
                MessageBox.Show("请先开始游戏！");
            }
        }

        //黑棋换子
        private void BtnBlack_Click(object sender, EventArgs e)
        {
            if (flagPlaying)
            {
                B++;
                if (B == this.StoneType.Images.Count)
                {
                    B = 0;
                }
                if (B == W) B++;

                if (B == this.StoneType.Images.Count)
                {
                    B = 0;
                }
                //绘制棋子颜色
                Stone.ChangeStone(B, W);
                this.btnBlack.Image = this.StoneType.Images[B];
            }
            else
            {
                MessageBox.Show("请先开始游戏！");
            }

        }

        private void 自定义ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.BackgroundImage = Image.FromFile(string.Format("{0}", this.ofd.FileName));
            }
        }

        private void 背景图片1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg1.jpg");
        }


        private void 背景图片2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg2.jpg");
        }

        private void 背景图片3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg3.jpg");
        }

        private void 背景图片14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg4.jpg");
        }

        private void 背景图片5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg5.jpg");
        }

        private void 背景图片6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg6.jpg");
        }

        private void 背景图片7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg7.jpg");
        }

        private void 背景图片8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg8.jpg");
        }

        private void 背景图片9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg9.jpg");
        }

        private void 背景图片10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(".\\背景图片\\bg10.jpg");
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 返回上级菜单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            MinimizeBox = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本产品由陈进狗，李尾狗和他们最最最敬畏，崇拜的风流倜傥英俊潇洒风度翩翩文物双全彬彬有礼智商高达250的邓猪长赞助播出", "关于");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("五子棋游戏源远流长，它源于古代中国，发展于日本，风靡于欧洲。五子棋不仅能增强思维能力，提高智力，而且富含哲理，有助于修身养性。五子棋既有现代休闲的明显特征“短、平、快”，又有古典哲学的高深学问“阴阳易理”；它既有简单易学的特性，为人民群众所喜闻乐见，又有深奥的技巧和高水平的国际性比赛；它的棋文化源渊流长，具有东方的神秘和西方的直观；既有“场”的概念，亦有“点”的连接。它是中西文化的交流点，是古今哲理的结晶。本系统实现了网络五子棋游戏，身临其境的体验进行网络五子棋游戏！功能包括游戏、设置、帮助。采用古典画风,操作简单、直接.。");
        }

        private void BtnRT_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiJi;
namespace 欢乐五子棋
{

    public partial class Form5 : Form
    {
        private bool start;   // 是否开始
        private bool type=true;   // 玩家
        private const int size = 15;
        int[,] wz = new int[size, size]; //数组
        Pen pn = new Pen(Color.Gray); //棋盘线的颜色

        int r = DiJi.size.r;
        int z = 80; //屏幕距离棋盘左的距离
        int s = 80; //屏幕距离棋盘上的距离
        static Color color1 = Color.FromArgb(0, 0, 0);
        static Color color2 = Color.FromArgb( 255, 255, 255);
        SolidBrush n1 = new SolidBrush(color1); //玩家1的棋子颜色
        SolidBrush n2 = new SolidBrush(color2); // 玩家2的棋子颜色
        int bs = 0;
        int[] hq = new int[450];//用于悔棋的数组
        
        public Form5()
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
        //System.Drawing.Bitmap
        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.lblClock.Text=DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss")
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            if (start)
            {
               Graphics g = this.CreateGraphics();
           type= DiJi.guize.fuzhi(e,wz,type,g,n1,n2,r,z,s,hq,bs);
            DiJi.guize.panduan(size,wz,bs);
            }
          
            
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        

        private void Button3_Click(object sender, EventArgs e)  //悔棋
        {
            Graphics g = this.CreateGraphics();
            //this.InitializeComponent();
            this.Invalidate();
            this.Update();
            DiJi.guize.hq(g, hq, bs, n1, n2, r);
          
         
            
          
           
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            start = true;
            Graphics g = this.CreateGraphics();
            ChessBoard.DrawCB(g, size, pn, s, z);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            start = true;
            this.Invalidate();
            //this.Invalidated();
            //this.InitializeComponent();
            this.Update();
            Graphics g = this.CreateGraphics();
            ChessBoard.DrawCB(g, size, pn, s, z);
            DiJi.csh.kaishi(size,wz);
      
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        // void Control.RaisepaintEvent(object key,PaintEventArgs e)
        //{
        //    Graphics g = this.CreateGraphics();
        //    DiJi.guize.hq(g, hq, bs, n1, n2, r);

        //}
     
        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            DiJi.guize.hq(g, hq, bs, n1, n2, r);

        }
        
    }
}
      
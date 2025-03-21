using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace 欢乐五子棋
{
	public partial class OLMain : Form
	{
		public OLMain()
		{
			InitializeComponent();
                Stone();
		}
		public int[,] stonetype = new int[15, 15];////棋子类型，黑色为1,白色为2
		public PictureBox[,] Chesspb = new PictureBox[15, 15];//棋子

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//绘制棋盘
		private void ChessBoard1_Paint(object sender, PaintEventArgs e)
		{
			Graphics mg = e.Graphics;
			//画格子
			Pen Pen = new Pen(Color.Black, 1);
			Pen BoldPen = new Pen(Color.Black, 2);
			Pen rect = new Pen(Color.Black, 4);
			//这里是在给棋盘加一个框框哦~
			//上边框
			mg.DrawLine(BoldPen, 1, 1, 1, 600);
			//下边框
			mg.DrawLine(BoldPen, 600, 1, 600, 600);
			//左边框
			mg.DrawLine(BoldPen, 1, 1, 600, 1);
			//右边框
			mg.DrawLine(BoldPen, 1, 600, 600, 600);
			for (int i = 0; i < 15; i++)
			{
				//竖线
				mg.DrawLine(Pen, 20 + i * 40, 20, 20 + i * 40, 580);
				//横线
				mg.DrawLine(Pen, 20, 20 + i * 40, 580, 20 + i * 40);//棋盘起点（30,30），大小32
			}
			//棋盘九点
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 3; j++)
					mg.DrawEllipse(rect, 138 + i * 160, 138 + j * 160, 3, 3);
		}
		//绘制隐形的棋子在网格上
		private void Stone()
		{
			for (int x = 0; x < 15; x++)
				for (int y = 0; y < 15; y++)
				{
					Chesspb[x, y] = new PictureBox();//新增图片棋子
					Chesspb[x, y].Size = new Size(32, 32);//大小
					Chesspb[x, y].BackColor = Color.Transparent;//棋子背景颜色
					Chesspb[x, y].Visible = false;//将控件设为隐藏
					Chesspb[x, y].Location = new Point(x * 40 + 5, y * 40 + 5);//在ChessBoard容器中的位置
					Chesspb[x, y].SizeMode = PictureBoxSizeMode.CenterImage;
					Chesspb[x, y].BackgroundImageLayout = ImageLayout.Center;//背景图片状态
					this.ChessBoard.Controls.Add(Chesspb[x, y]);//棋盘控件添加棋子
				}
		}
		//点击获取棋子的坐标
		int x, y;
		int flag = 0;//判断谁是监听端谁是连接端flag=1是监听端，反之为连接端
		int jt = 2;//判断是否为监听端下棋
		int lj = 1;//判断是否为连接端下棋
		int pd = 0;
		private void ChessBoard1_MouseClick(object sender, MouseEventArgs e)
		{
			x = e.X / 40;
			y = e.Y / 40;
			if (btnSend.Text == "连接" || btnSend.Text == "重设")
			{
				ShowStone_3(x, y);
				btnSend.Text = "重设";
				rtbInput.ReadOnly = true;

			}
			if (btnSend.Text == "发送")
			{
				if (flag == 1 && jt % 2 == 0)
				{
					try
					{
						jt += 1;
						string msg = x + "-" + y;//中间-是分隔符
						byte[] buffer = System.Text.Encoding.UTF8.GetBytes(msg);
						SocketSend.Send(buffer);
						ShowStone_1(x, y);
						lblFirst.Text = "对方下棋";
					}
					catch
					{
					}
				}
				else if (flag == 2 && lj % 2 == 0)
				{
					lj += 1;
					string msg = x + "-" + y;//中间-是分隔符
					byte[] buffer = Encoding.UTF8.GetBytes(msg);
					SocketSend.Send(buffer);
					ShowStone_1(x, y);
					lblFirst.Text = "对方下棋";
				}
			}
		}

		private void ShowStone_3(int x, int y)
		{
		
			if (stonetype[x, y] == 0)
			{
				pd++;
				if (pd % 2 != 0)//单数
				{
					Chesspb[x, y].Image = Properties.Resources.黑;//棋子显示的颜色
					Chesspb[x, y].Visible = true;//显示棋子
					stonetype[x, y] = 1;
					欢乐五子棋.CPT.Stone stone = new 欢乐五子棋.CPT.Stone();
					stone.StoneVoice(); 
					lblMsg1.Text = "等待白棋下棋";
					stone.StoneVoice();
				}
				else
				{
					Chesspb[x, y].Image = Properties.Resources.白;//棋子显示的颜色
					Chesspb[x, y].Visible = true;//显示棋子
					stonetype[x, y] = 2;
					lblMsg1.Text = "等待黑棋下棋";
					欢乐五子棋.CPT.Stone stone = new 欢乐五子棋.CPT.Stone();
					stone.StoneVoice();
				}
			}
			
			Rule();
		}

		//将点击隐形的棋子显示出来
		private void ShowStone_1(int x, int y)
		{
                if (flag % 2 != 0)//单数
                {
                    Chesspb[x, y].Image = Properties.Resources.黑;//棋子显示的颜色
                    Chesspb[x, y].Visible = true;//显示棋子
                    stonetype[x, y] = 1;
                    欢乐五子棋.CPT.Stone stone = new 欢乐五子棋.CPT.Stone();
                    stone.StoneVoice();
                }
                else
                {
                    Chesspb[x, y].Image = Properties.Resources.白;//棋子显示的颜色;
                    Chesspb[x, y].Visible = true;//显示棋子
                    stonetype[x, y] = 2;
                    欢乐五子棋.CPT.Stone stone = new 欢乐五子棋.CPT.Stone();
                    stone.StoneVoice();
                }
			Rule();
		}
		//子线程不能直接修改主线程的控件属性，需要用如下方法代码处理
		//接收棋盘
		private void ShowStone_2(int x, int y)
		{ 
				if (flag % 2 == 0)//单数
				{
					Chesspb[x, y].BeginInvoke(new Action(() => {
                        Chesspb[x, y].Image = Properties.Resources.黑;//棋子显示的颜色 
					}));
					Chesspb[x, y].BeginInvoke(new Action(() => { Chesspb[x, y].Visible = true; }));
					stonetype[x, y] = 1;
				欢乐五子棋.CPT.Stone stone = new 欢乐五子棋.CPT.Stone();
				stone.StoneVoice();
				jt += 1;
				lj += 1;
			}
				else
				{
					Chesspb[x, y].BeginInvoke(new Action(() => {
                        Chesspb[x, y].Image = Properties.Resources.白;//棋子显示的颜色 
					}));
					Chesspb[x, y].BeginInvoke(new Action(() => { Chesspb[x, y].Visible = true; }));
					stonetype[x, y] = 2;
					欢乐五子棋.CPT.Stone stone = new 欢乐五子棋.CPT.Stone();
					stone.StoneVoice();
					jt += 1;
					lj += 1;
			}
			Rule();
		}

		private void OLMain_Load(object sender, EventArgs e)
		{
			rtbShow.Text = "该模式的网络为局域网模式！\n提示：需要一方点击连接，另一方输入对方IP连接！\n例如：172.168.0.1";
			ShowIP();
			btnSend.Text = "连接";
		}

		//IP显示
		private void ShowIP()
		{
			string hostname = Dns.GetHostName();//得到主机名  
			IPHostEntry localhost = Dns.GetHostEntry(hostname);
			//得到IP
			IPAddress localaddr = localhost.AddressList[1];
			//显示IP在lblShowIP.Text中
			this.lblShowIP.Text = string.Format("{0}", localaddr);
		}

		Socket socketwatch;
		void Listen(object o)
		{
			Socket SocketSend = o as Socket;
			//等待客户端连接
			while (true)
			{
				SocketSend = socketwatch.Accept();
				//追加文本
				rtbShow.AppendText("连接成功！" + "\n");
				//开启一个新线程不停接收客户端发过来的新消息
				Thread thread = new Thread(Recive);
				thread.IsBackground = true;
				thread.Start(SocketSend);
			}
		}
		Socket SocketSend;
		//接收读取
		void Recive(object o)
		{
			SocketSend = o as Socket;
			while (true)
			{
				try
				{
					byte[] buffer = new byte[1024 * 1024 * 2];
					int num = SocketSend.Receive(buffer);
					if (num == 0)
					{
						break;
					}
					string msg = Encoding.UTF8.GetString(buffer, 0, num);
					char[] ch = Encoding.UTF8.GetChars(buffer, 0, num);
					//表示msg中是否包含了“-”，如果包含就是等于负一。就表明字符串msg中包含的是棋子信息
					if (msg.IndexOf("-") != -1)
					{
                        //用字符串数组拆分去“-”的两个数据x,y
                        string[] strs = Regex.Split(msg, "-", RegexOptions.IgnoreCase);
                        //获取拆分数据
                        int x1 = int.Parse(strs[0]);
                        int y1 = int.Parse(strs[1]);
                         ShowStone_2(x1, y1);//绘制在接收棋盘中
                            this.lblFirst.Text = "己方下棋";
                            if (flag == 1)
                            {
                                pbB.Visible = true;
                                pbW.Visible = false;
                            }
                            else if (flag == 2)
                            {
                                pbB.Visible = false;
                                pbW.Visible = true;
                            }
					}
					else
					{
						rtbShow.AppendText(msg + "\n");
					}
				}
				catch (Exception)
				{
					Application.Run();
				}
			}
		}
		//连接IP
		Thread thread_1;
		Thread thread_2;
		private void BtnSend_Click(object sender, EventArgs e)
		{
			if (btnSend.Text == "发送")
			{
				try
				{
					string flagfirst = null;
					if (flag==1)
					{
						flagfirst = "黑棋方";
					}
					else
					{
						flagfirst = "白棋方";
					}
					string Input = rtbInput.Text.Trim();
					string msg = string.Format("{0}:{1}", flagfirst, Input);
                    if (msg == string.Format("{0}:" + "", flagfirst)) 
                    {
                        MessageBox.Show("消息不能为空！");
                    }
                    else
                    {

                        byte[] buffer = Encoding.UTF8.GetBytes(msg);
                        SocketSend.Send(buffer);
                        rtbShow.AppendText(msg + "\n");
                        rtbInput.Clear();
                    }
				}
				catch
				{
					MessageBox.Show("未连接成功！请检查网络是否完好！");
				}
			}
			else if (btnSend.Text == "重设")
			{
				Reset();
				btnSend.Text = "连接";
				rtbInput.ReadOnly = false;
				pd = 0;
				lblMsg1.Text = "等待黑子下棋";
			}
			else
			{
				try
				{
					//监听
					socketwatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					if (rtbInput.Text == "")
					{
						IPAddress ip = IPAddress.Any;
						//端口
						IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32("6666"));
						socketwatch.Bind(point);
						flag = 1;
						btnSend.Text = "发送";
						socketwatch.Listen(1000000);
						//开启多线程
						thread_1 = new Thread(Listen);
						thread_1.IsBackground = true;
						thread_1.Start(socketwatch);
						//清理上面的对话
						rtbShow.Clear();
						pbB.Visible = true;
						pbW.Visible = false;
						pbShow.Visible = false;
						lblMsg1.Text = "";
						rtbShow.AppendText("正在监听" + "\n");
						lblFirst.Text = "己方下棋";
						
					}
					else
					{
						flag = 2;
						IPAddress ip = IPAddress.Parse(rtbInput.Text);
						//定义端口号
						IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32("6666"));
						//获得远程服务器ip和端口号
						socketwatch.Connect(point);
						btnSend.Text = "发送";
						thread_2 = new Thread(Recive);
						thread_2.IsBackground = true;
						thread_2.Start(socketwatch);
						//清理上面的对话
						rtbShow.Clear();
						rtbShow.AppendText("连接成功！" + "\n");
						rtbInput.Clear();
						lblFirst.Text = "对方下棋";
						pbB.Visible = false;
						pbW.Visible = true;
						pbShow.Visible = false;
						lblMsg1.Text = "";
					}
				}
				catch { }

			}
		}

        //棋子颜色
        private static void StoneColor(int choose) 
        {
            
        }

		int _x, _y;
		private void OLMain_MouseDown(object sender, MouseEventArgs e)
		{
			_x = e.X;
			_y = e.Y;

		}

		private void OLMain_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - _x;
				this.Top += e.Y - _y;
			}
		}

        //返回主界面
        private void BtnRT_Click(object sender, EventArgs e)
		{
			MainForm mf = new MainForm();
			mf.Show();
            this.Hide();
		}

		//重置
		public void Reset()
		{
			stonetype = new int[15, 15];
			for (int x = 0; x < 15; x++)
			{
				for (int y = 0; y < 15; y++)
                {
                    Chesspb[x, y].Visible = false;//将控件设为隐藏
                    Chesspb[x, y].BackgroundImage = null;//背景图片
				}
			}
		}

		/// <summary>
		/// 判断输赢的算法
		/// </summary>
		public void Rule()
		{
			//竖排
			for (int i = 0; i < 15; i++)
			{
				for (int j = 0; j < 11; j++)
				{
					if (stonetype[i, j] == 1 && stonetype[i, j + 1] == 1 && stonetype[i, j + 2] == 1 && stonetype[i, j + 3] == 1 && stonetype[i, j + 4] == 1)
					{
						MessageBox.Show("恭喜！黑棋胜利！");
						Reset();
					}
					if (stonetype[i, j] == 2 && stonetype[i, j + 1] == 2 && stonetype[i, j + 2] == 2 && stonetype[i, j + 3] == 2 && stonetype[i, j + 4] == 2)
					{
						MessageBox.Show("恭喜！白棋胜利！");
						Reset();
					}
				}
			}

			//横排
			for (int i = 0; i < 11; i++)
			{
				for (int j = 0; j < 15; j++)
				{
					if (stonetype[i, j] == 1 && stonetype[i + 1, j] == 1 && stonetype[i + 2, j] == 1 && stonetype[i + 3, j] == 1 && stonetype[i + 4, j] == 1)
					{
						MessageBox.Show("恭喜！黑棋胜利！");
						Reset();
					}
					if (stonetype[i, j] == 2 && stonetype[i + 1, j] == 2 && stonetype[i + 2, j] == 2 && stonetype[i + 3, j] == 2 && stonetype[i + 4, j] == 2)
					{
						MessageBox.Show("恭喜！白棋胜利！");
						Reset();
					}
				}
			}

			//斜排
			for (int i = 4; i < 15; i++)
			{
				for (int j = 0; j < 11; j++)
				{
					if (stonetype[i, j] == 1 && stonetype[i - 1, j + 1] == 1 && stonetype[i - 2, j + 2] == 1 && stonetype[i - 3, j + 3] == 1 && stonetype[i - 4, j + 4] == 1)
					{
						MessageBox.Show("恭喜！黑棋胜利！");
						Reset();
					}
					if (stonetype[i, j] == 2 && stonetype[i - 1, j + 1] == 2 && stonetype[i - 2, j + 2] == 2 && stonetype[i - 3, j + 3] == 2 && stonetype[i - 4, j + 4] == 2)
					{
						MessageBox.Show("恭喜！白棋胜利！");
						Reset();
					}
				}
			}
			//反斜排
			for (int i = 0; i < 11; i++)
			{
				for (int j = 0; j < 11; j++)
				{
					if (stonetype[i, j] == 1 && stonetype[i + 1, j + 1] == 1 && stonetype[i + 2, j + 2] == 1 && stonetype[i + 3, j + 3] == 1 && stonetype[i + 4, j + 4] == 1)
					{
						MessageBox.Show("恭喜！黑棋胜利！");
						Reset();
					}
					if (stonetype[i, j] == 2 && stonetype[i + 1, j + 1] == 2 && stonetype[i + 2, j + 2] == 2 && stonetype[i + 3, j + 3] == 2 && stonetype[i + 4, j + 4] == 2)
					{
						MessageBox.Show("恭喜！白棋胜利！");
						Reset();
					}
				}
			}
		}
	}
}
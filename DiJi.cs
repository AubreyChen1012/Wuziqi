using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace DiJi
{

    class size
    {

        //public static int pmk { get { return 680; } }  // 屏幕宽
        //public static int pmg { get { return 710; } } // 屏幕高
        //public static int qpk { get { return 600; } } //棋盘宽
        //public static int qpg { get { return 600; } } // 棋盘高
        public static int qzk { get { return 40; } } //棋子格子宽
        public static int r { get { return 30; } } //棋子直径


    }
    class csh
    {
        public static void kaishi(int size, int[,] wz)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    wz[i, j] = 0;
                }
            }
        }
    }
    class guize   //点击棋盘 判断位置，为其赋值
    {
        //public  static PictureBox[] hqgz = new PictureBox[225];//用于悔棋的数组

       
        public static int hq(PictureBox[] hq, int bs,int [,]wz,int z,int s)
        {
            hq[bs-1].Visible = false;
          int x=  (hq[bs - 1].Location.X-z+15)/40;
            int y = (hq[bs - 1].Location.Y-s+15)/40;
            wz[x, y] = 0;
            bs--;
            return bs;



        }
        public static void qp(Form F, int[,] wz, int size, int z, int s, Pen pn)
        {

            Graphics g = F.CreateGraphics();

            int a = DiJi.size.qzk;  //棋盘格子宽度

            for (int j = 0; j < size; j++)    //建设棋盘
            {
                g.DrawLine(pn, z, j * a + s, a * (size - 1) + z, j * a + s);
                g.DrawLine(pn, j * a + z, s, j * a + z, a * (size - 1) + s);

            }

        }
        public static bool cf(MouseEventArgs e, int[,] wz,  int z, int s, PictureBox[] hq)
        {
            int gzk = DiJi.size.qzk;
            int x1 = e.X - z;
            int y1 = e.Y - s;


            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    try
                    {
                        int a = (i * gzk - x1) * (i * gzk - x1) + (j * gzk - y1) * (j * gzk - y1); //两点的距离的平方

                        if (Math.Sqrt(a) < 20)
                        {

                            if (wz[i, j] == 0)
                            {

                                
                                return true;
                            }
                        }
                    }  
                    catch (Exception)
                    {
                        return false;

                    }
                }
            }
            return false;
        }

      

        public static PictureBox fuzhi(MouseEventArgs e, int[,] wz, bool type, Graphics g, SolidBrush n1, SolidBrush n2, int r, int z, int s, PictureBox[] hq, int bs, PictureBox[,] xs)
    {

        /* Graphics g = p.CreateGraphics(); */
        //调用某控件或窗体的CreateGraphics方法以获取对Graphics对象的引用
        int gzk = DiJi.size.qzk;
        int x1 = e.X - z;
        int y1 = e.Y - s;

        //Image img1 = Image.FromFile((" E:\\棋盘\\欢乐五子棋\\欢乐五子棋\\images\\1236.png"));

        //Graphics p = Graphics.FromImage(img1);
        //string wanjia1 = Application.StartupPath + "\\images\\121.png";
        //string wanjia2 = Application.StartupPath + "\\images\\122.png";


        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                try
                {
                    int a = (i * gzk - x1) * (i * gzk - x1) + (j * gzk - y1) * (j * gzk - y1); //两点的距离的平方

                    if (Math.Sqrt(a) < 20)
                    {

                        //if (wz[i, j] != 0)
                        //{

                        //    break;
                        //}
                        int x2 = i * gzk + z - r / 2;
                        int y2 = j * gzk + s - r / 2;

                        //Graphics p = xs[i, j].CreateGraphics();
                        if (type==true)
                        {
                            wz[i, j] = 1;

                            //System.Reflection.Assembly thisExe = System.Reflection.Assembly.GetCallingAssembly();
                            //Stream bfile = thisExe.GetManifestResourceStream("hlwzq.images.121.png");
                            //Image imgblack = Image.FromStream(bfile);
                            //p.DrawImage(imgblack, x2, y2, imgblack.Width, imgblack.Height);
                            //p.DrawImage(img1, i * gzk + z - r / 2, j * gzk + s - r / 2);
                            //g.FillEllipse(n1, x2, y2, r, r);
                            xs[i, j].ImageLocation = ".\\棋子图片\\黑.png";
                            //bfile.Close();

                            //xs[i, j].Image = Image.FromFile(wanjia2);
                            xs[i, j].Visible = true;
                            hq[bs] = xs[i, j];

                            return /*type = !type;*/ hq[bs];


                        }
                        else
                        {
                            wz[i, j] = 2;

                                //System.Reflection.Assembly thisExe = System.Reflection.Assembly.GetCallingAssembly();
                                //Stream bfile = thisExe.GetManifestResourceStream("hlwqz.images.1235.png");

                                //Image imgwhite = Image.FromStream(bfile);
                                //bfile.Close();
                                //p.DrawImage(imgwhite, x2 * 30, y2 * 30, r, r);

                                //g.FillEllipse(n2, x2, y2, r, r);
                                xs[i, j].ImageLocation = ".\\棋子图片\\白.png";
                                xs[i, j].Visible = true;
                            hq[bs] = xs[i, j];
                            return /*type = !type;*/ hq[bs];
                           
                        }

                    }

                }
                catch (Exception)
                {


                }

            }
        }return hq[bs]; 




            //int x1 = (e.X-z) / gzk;
            //int y1 = (e.Y-s) / gzk;   //根据X，Y坐标来确定位置
            //int x2 = (e.X-z) / gzk * gzk - r / 2 + z;
            //int y2 = (e.Y-s) / gzk * gzk - r / 2 + s;
            //try
            //{
            //    if (wz[x1, y1] != 0)
            //    {
            //        return type;
            //    }
            //    if (type == true)
            //    {
            //        wz[x1, y1] = 1;
            //        hq[bs] = x2;
            //        hq[bs + 1] = y2;
            //     g.FillEllipse(n1, x2, y2, r, r);  //画圆
            //    type = !type;
            //        return type;

            //    }
            //    else
            //    {
            //        wz[x1, y1] = 2;
            //        hq[bs] = x2;
            //        hq[bs + 1] = y2;
            //    g.FillEllipse(n2, x2, y2, r, r); // 画圆
            //    type = !type;
            //        return type;

            //    }

            //}
            //catch (Exception)
            //{
            //    return type;

            //}
        }
    public static void panduan(int size, int[,] wz, int bs)
    {
        for (int i = 0; i < size - 4; i++)
        {
            for (int j = 0; j < size - 4; j++)
            {

                if ((wz[i, j] == wz[i, j + 1] && wz[i, j + 1] == wz[i, j + 2] && wz[i, j + 2] == wz[i, j + 3] && wz[i, j + 3] == wz[i, j + 4] && wz[i, j] == 1)||    //竖向判断
                    (wz[i, j] == wz[i + 1, j] && wz[i + 1, j] == wz[i + 2, j] && wz[i + 2, j] == wz[i + 3, j] && wz[i + 3, j] == wz[i + 4, j] && wz[i, j] == 1) ||   //横向判断
                    (wz[i, j] == wz[i + 1, j + 1] && wz[i + 1, j + 1] == wz[i + 2, j + 2]&& wz[i + 2, j + 2] == wz[i + 3, j + 3] && wz[i + 3, j + 3] == wz[i + 4, j + 4] && wz[i, j] == 1)||   //左斜判断
                    (wz[i, j + 4] == wz[i + 1, j + 3] && wz[i + 1, j + 3] == wz[i + 2, j + 2] && wz[i + 2, j + 2] == wz[i + 3, j + 1] && wz[i + 3, j + 1] == wz[i + 4, j] && wz[i, j + 4] == 1)   //右斜判断
                    )
                {
                    MessageBox.Show("玩家一胜利");

                  
                    //玩家一是否胜利
                }
                if ((wz[i, j] == wz[i, j + 1] && wz[i, j + 1] == wz[i, j + 2] && wz[i, j + 2] == wz[i, j + 3] && wz[i, j + 3] == wz[i, j + 4] && wz[i, j] == 2) ||    //竖向判断
                   (wz[i, j] == wz[i + 1, j] && wz[i + 1, j] == wz[i + 2, j] && wz[i + 2, j] == wz[i + 3, j] && wz[i + 3, j] == wz[i + 4, j] && wz[i, j] == 2) ||   //横向判断
                   (wz[i, j] == wz[i + 1, j + 1] && wz[i + 1, j + 1] == wz[i + 2, j + 2] && wz[i + 2, j + 2] == wz[i + 3, j + 3] && wz[i + 3, j + 3] == wz[i + 4, j + 4] && wz[i, j] == 2) ||   //左斜判断
                   (wz[i, j + 4] == wz[i + 1, j + 3] && wz[i + 1, j + 3] == wz[i + 2, j + 2] && wz[i + 2, j + 2] == wz[i + 3, j + 1] && wz[i + 3, j + 1] == wz[i + 4, j] && wz[i, j + 4] == 2)   //右斜判断
                   )
                {
                    MessageBox.Show("玩家二胜利");


                    //玩家一是否胜利
                }
               
                if (bs == 449)
                {
                        MessageBox.Show("平局");
                }
            }
        }


        //for (int i = 0; i < size; i++)
        //{
        //    for (int j = 0; j < size; j++)
        //    {
        //        if (wz[i, j] == 0)
        //        {
        //            break;

        //        }
        //        if (i == size - 1 && j == size - 1)
        //            {
        //                MessageBox.Show("平局");
        //            }
        //    }
        //}

    } //判断是否赢了

}

}

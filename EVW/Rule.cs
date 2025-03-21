using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 欢乐五子棋.EVW
{
	//人人对战规则类
	class Rule
	{
          //点击棋盘 判断位置，为其赋值
        


        public static void hq(Graphics g,int[] hq, int bs,SolidBrush n1,SolidBrush n2,int r)
        {
            for (int i = 0; i < bs; i+=2)
            {
                if (hq[i]==0)
                {
                    break;
                }
                if (i%2==0)
                {
                    g.FillEllipse(n2, hq[i], hq[i + 1], r, r);
                }
                else
                {
                    g.FillEllipse(n1, hq[i], hq[i + 1], r, r);
                }
                
            }


        }
            public static void qp(Form F, int[,] wz, int size, int z, int s, Pen pn)
            {

                Graphics g = F.CreateGraphics();

                int a = MainSize.gzk; //棋盘格子宽度

                for (int j = 0; j < size; j++)    //建设棋盘
                {
                    g.DrawLine(pn, z, j * a + s, a * (size - 1) + z, j * a + s);
                    g.DrawLine(pn, j * a + z, s, j * a + z, a * (size - 1) + s);
                
                }
            }
            public static bool fuzhi(MouseEventArgs e, int[,] wz, bool type, Graphics g, SolidBrush n1, SolidBrush n2, int r, int z, int s, int[] hq, int bs)
            {

               /* Graphics g = p.CreateGraphics(); *///调用某控件或窗体的CreateGraphics方法以获取对Graphics对象的引用
                int gzk = MainSize.gzk;
            int x1 = e.X - z;
            int y1 = e.Y - s;
            bs += 2;
            //Image img1 = Image.FromFile((" E:\\棋盘\\欢乐五子棋\\欢乐五子棋\\images\\1236.png"));

            //Graphics p = Graphics.FromImage(img1);


            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    try
                    {
                        int a = (i * gzk - x1) * (i * gzk - x1) + (j * gzk - y1) * (j * gzk - y1); //两点的距离的平方

                        if (Math.Sqrt(a) < 20)
                        {

                            if (wz[i, j] != 0)
                            {

                                return type;
                            }
                            int x2 = i * gzk + z -r/2;
                            int y2 = j * gzk + s -r/2;
                            if (type == true)
                            {
                                wz[i, j] = 1;
                                g.FillEllipse(n1,x2 , y2, r, r);
                                //p.DrawImage(img1,i*gzk+z-r/2,j*gzk+s-r/2);
                                hq[bs] = x2;
                                hq[bs+1] = y2;
                                return type = !type;
                            }
                            else
                            {
                                wz[i, j] = 2;
                                g.FillEllipse(n2, x2, y2, r, r);
                                hq[bs] = x2;
                                hq[bs+1] = y2;
                                return type = !type;
                            }
                        }

                    }
                    catch (Exception)
                    {


                    }

                }
            }
            return type;



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
            

	}
}

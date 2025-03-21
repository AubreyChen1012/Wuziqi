using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
namespace 欢乐五子棋
{
    class Stone1
    {

        public static string qzlj1 = ".\\棋子图片\\黑.png";
        public static string qzlj2 = ".\\棋子图片\\白.png";
        public static int[,] wz = new int[15, 15]; //数组
        public static int hq(PictureBox[] hq, int bs, int z, int s)
        {
            hq[bs - 1].Visible = false;
            int x = (hq[bs - 1].Location.X - z + 15) / 40;
            int y = (hq[bs - 1].Location.Y - s + 15) / 40;
            wz[x, y] = 0;
            bs--;

            return bs;



        }
        public static bool cf(MouseEventArgs e, int z, int s, PictureBox[] hq)
        {
            int gzk = MainSize.gzk;
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
        public static PictureBox fuzhi(MouseEventArgs e, bool type, int r, int z, int s, PictureBox[] hq, int bs, PictureBox[,] xs)
        {

            int gzk = MainSize.gzk;
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
                            int x2 = i * gzk + z - r / 2;
                            int y2 = j * gzk + s - r / 2;
                            if (type == true)
                            {
                                wz[i, j] = 1;

                                xs[i, j].ImageLocation = qzlj1;
                                xs[i, j].Visible = true;
                                hq[bs] = xs[i, j];

                                return hq[bs];


                            }
                            else
                            {
                                wz[i, j] = 2;
                                xs[i, j].ImageLocation = qzlj2;
                                xs[i, j].Visible = true;
                                hq[bs] = xs[i, j];
                                return hq[bs];

                            }

                        }

                    }
                    catch (Exception)
                    {


                    }

                }
            }
            return hq[bs];





        }
        public static void kaishi(int size)
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
}

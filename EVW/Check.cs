using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace 欢乐五子棋.EVW
{
    //规则判断类
    class Check
    {
        public static void panduan(int size, int[,] wz)
        {

            for (int i = 0; i < size - 4; i++)
            {
                for (int j = 0; j < size - 4; j++)
                {

                    if (wz[i, j] == wz[i, j + 1] && wz[i, j + 1] == wz[i, j + 2] &&
                        wz[i, j + 2] == wz[i, j + 3] && wz[i, j + 3] == wz[i, j + 4] && wz[i, j] == 1)
                    {
                        MessageBox.Show("玩家一胜利");

                        //竖向判断
                        //玩家一是否胜利
                    }
                    if (wz[i, j] == wz[i + 1, j] && wz[i + 1, j] == wz[i + 2, j]
                        && wz[i + 2, j] == wz[i + 3, j] && wz[i + 3, j] == wz[i + 4, j] && wz[i, j] == 1)
                    {
                        MessageBox.Show("玩家一胜利");
                        //横向判断
                        //玩家一是否胜利
                    }
                    if (wz[i, j] == wz[i + 1, j + 1] && wz[i + 1, j + 1] == wz[i + 2, j + 2]
                        && wz[i + 2, j + 2] == wz[i + 3, j + 3] && wz[i + 3, j + 3] == wz[i + 4, j + 4] && wz[i, j] == 1)
                    {
                        MessageBox.Show("玩家一胜利");
                        //左斜判断
                        //玩家一是否胜利
                    }
                    if (wz[i, j + 4] == wz[i + 1, j + 3] && wz[i + 1, j + 3] == wz[i + 2, j + 2]
                      && wz[i + 2, j + 2] == wz[i + 3, j + 1] && wz[i + 3, j + 1] == wz[i + 4, j] && wz[i, j + 4] == 1)
                    {
                        MessageBox.Show("玩家一胜利");
                        //右斜判断
                        //玩家一是否胜利
                    }
                    if (wz[i, j] == wz[i, j + 1] && wz[i, j + 1] == wz[i, j + 2]
                        && wz[i, j + 2] == wz[i, j + 3] && wz[i, j + 3] == wz[i, j + 4] && wz[i, j] == 2)
                    {
                        MessageBox.Show("玩家二胜利");
                        //竖向判断
                        //玩家二是否胜利
                    }
                    if (wz[i, j] == wz[i + 1, j + 1] && wz[i + 1, j + 1] == wz[i + 2, j + 2]
                        && wz[i + 2, j + 2] == wz[i + 3, j + 3] && wz[i + 3, j + 3] == wz[i + 4, j + 4] && wz[i, j] == 2)
                    {
                        MessageBox.Show("玩家二胜利");
                        //左斜判断
                        //玩家二是否胜利
                    }
                    if (wz[i, j + 4] == wz[i + 1, j + 3] && wz[i + 1, j + 3] == wz[i + 2, j + 2]
                                             && wz[i + 2, j + 2] == wz[i + 3, j + 1] && wz[i + 3, j + 1] == wz[i + 4, j] && wz[i, j + 4] == 2)
                    {
                        MessageBox.Show("玩家二胜利");
                        //右斜判断
                        //玩家二是否胜利
                    }
                    if (wz[i, j] == wz[i + 1, j] && wz[i + 1, j] == wz[i + 2, j]
                           && wz[i + 2, j] == wz[i + 3, j] && wz[i + 3, j] == wz[i + 4, j] && wz[i, j] == 2)
                    {
                        MessageBox.Show("玩家二胜利");
                        //横向判断
                        //玩家二是否胜利
                    }
                }
            }


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    if (wz[i, j] == 0)
                    {
                  
                        break;


                    }  
                    if (i == size - 1 && j == size - 1)
                        {
                            MessageBox.Show("平局");
                        }

                }
            }

        } //判断是否赢了

    }
}

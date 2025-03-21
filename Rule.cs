using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace 欢乐五子棋
{
    class Rule
    {
        static int[,] wz = EVWStone.wz;
        public static void panduan(int size, int bs)
        {



            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i < 11 && j < 11)
                    {
                        if ((wz[i, j] == wz[i, j + 1] && wz[i, j + 1] == wz[i, j + 2] && wz[i, j + 2] == wz[i, j + 3] && wz[i, j + 3] == wz[i, j + 4] && wz[i, j] == 1) ||    //竖向判断
                      (wz[i, j] == wz[i + 1, j] && wz[i + 1, j] == wz[i + 2, j] && wz[i + 2, j] == wz[i + 3, j] && wz[i + 3, j] == wz[i + 4, j] && wz[i, j] == 1) ||   //横向判断
                      (wz[i, j] == wz[i + 1, j + 1] && wz[i + 1, j + 1] == wz[i + 2, j + 2] && wz[i + 2, j + 2] == wz[i + 3, j + 3] && wz[i + 3, j + 3] == wz[i + 4, j + 4] && wz[i, j] == 1) ||   //左斜判断
                      (wz[i, j + 4] == wz[i + 1, j + 3] && wz[i + 1, j + 3] == wz[i + 2, j + 2] && wz[i + 2, j + 2] == wz[i + 3, j + 1] && wz[i + 3, j + 1] == wz[i + 4, j] && wz[i, j + 4] == 1)   //右斜判断
                      )
                        {
                            DialogResult result = MessageBox.Show("玩家一胜利，是否再来局", "游戏结束", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                EVWMain.ZLYJ = true;
                            }
                            EVWMain.start = false;
                            //玩家一是否胜利
                        }
                        if ((wz[i, j] == wz[i, j + 1] && wz[i, j + 1] == wz[i, j + 2] && wz[i, j + 2] == wz[i, j + 3] && wz[i, j + 3] == wz[i, j + 4] && wz[i, j] == 2) ||    //竖向判断
                           (wz[i, j] == wz[i + 1, j] && wz[i + 1, j] == wz[i + 2, j] && wz[i + 2, j] == wz[i + 3, j] && wz[i + 3, j] == wz[i + 4, j] && wz[i, j] == 2) ||   //横向判断
                           (wz[i, j] == wz[i + 1, j + 1] && wz[i + 1, j + 1] == wz[i + 2, j + 2] && wz[i + 2, j + 2] == wz[i + 3, j + 3] && wz[i + 3, j + 3] == wz[i + 4, j + 4] && wz[i, j] == 2) ||   //左斜判断
                           (wz[i, j + 4] == wz[i + 1, j + 3] && wz[i + 1, j + 3] == wz[i + 2, j + 2] && wz[i + 2, j + 2] == wz[i + 3, j + 1] && wz[i + 3, j + 1] == wz[i + 4, j] && wz[i, j + 4] == 2)   //右斜判断
                           )
                        {
                            DialogResult result = MessageBox.Show("玩家二胜利，是否再来局", "游戏结束", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                EVWMain.ZLYJ = true;
                            }
                            EVWMain.start = false;
                            
                            //玩家一是否胜利
                        }
                    }
                    if (i >= 11 && j < 11)
                    {
                        if ((wz[i, j] == wz[i, j + 1] && wz[i, j + 1] == wz[i, j + 2] && wz[i, j + 2] == wz[i, j + 3] && wz[i, j + 3] == wz[i, j + 4] && wz[i, j] == 1))
                        {
                            DialogResult result = MessageBox.Show("玩家一胜利，是否再来局", "游戏结束", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                EVWMain.ZLYJ = true;
                            }
                            EVWMain.start = false;
                            //玩家一是否胜利
                        }
                        if ((wz[i, j] == wz[i, j + 1] && wz[i, j + 1] == wz[i, j + 2] && wz[i, j + 2] == wz[i, j + 3] && wz[i, j + 3] == wz[i, j + 4] && wz[i, j] == 2))
                        {
                            DialogResult result = MessageBox.Show("玩家二胜利，是否再来局", "游戏结束", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                EVWMain.ZLYJ = true;
                            }
                            EVWMain.start = false;
                            //玩家二是否胜利
                        }
                    }
                    if (i < 11 && j >= 11)
                    {
                        if ((wz[i, j] == wz[i + 1, j] && wz[i + 1, j] == wz[i + 2, j] && wz[i + 2, j] == wz[i + 3, j] && wz[i + 3, j] == wz[i + 4, j] && wz[i, j] == 1))
                        {
                            MessageBox.Show("玩家一胜利");
                            EVWMain.start = false;
                            //玩家1是否胜利
                        }
                        if ((wz[i, j] == wz[i + 1, j] && wz[i + 1, j] == wz[i + 2, j] && wz[i + 2, j] == wz[i + 3, j] && wz[i + 3, j] == wz[i + 4, j] && wz[i, j] == 2))
                        {
                            MessageBox.Show("玩家二胜利");
                            EVWMain.start = false;
                            //玩家2是否胜利
                        }
                    }



                }
            }
            if (bs == 225)
            {
                MessageBox.Show("平局");
                EVWMain.start = false;
            }
        }//判断是否赢了






    }
}


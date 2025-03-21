using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace 欢乐五子棋
{
    class ChessBoard
    {
        public static Pen pn = new Pen(Color.Gray); //棋盘线的颜色
        public static void DrawCB(Graphics g, int size, int s, int z)
        {

            int a = MainSize.gzk;  //棋盘格子宽度
            for (int j = 0; j < size; j++)    //建设棋盘
            {
                g.DrawLine(pn, z, j * a + s, a * (size - 1) + z, j * a + s);
                g.DrawLine(pn, j * a + z, s, j * a + z, a * (size - 1) + s);
            }
        }
    }
}

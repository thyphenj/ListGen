using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paint
{
    class Clue
    {
        public int X;
        public int Y;
        public string Num;
        public direction Dir;
        public int Len;
        public string Text;

        public Clue(int y, int x, string num, direction dir,  int len, string text )
        {
            Y = y;
            X = x;
            Num = num;
            Dir = dir;
            Len = len;
            Text = text;
        }
    }
}

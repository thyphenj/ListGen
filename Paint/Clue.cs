using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListGen
{
    class Clue
    {
        public int X;
        public int Y;
        public string Num;
        public ClueDirection Dir;
        public int Len;
        public string Text;

        private static ClueDirection DefaultDirection = ClueDirection.ac;

        public Clue(int y, int x, string num, ClueDirection dir, int len, string text)
        {
            Y = y;
            X = x;
            Num = num;
            Dir = dir;
            Len = len;
            Text = text;

            setDefaultDirection(Dir);
        }

        public Clue(int y, int x, string num, int len, string text)
        {
            Y = y;
            X = x;
            Num = num;
            Dir = DefaultDirection;
            Len = len;
            Text = text;
        }

        public void setDefaultDirection ( ClueDirection dir)
        {
            DefaultDirection = dir;
        }

        public override string ToString()
        {
            string retval = $"   {Num.ToString().PadLeft(2)}{Dir}   {Text} ({Len.ToString()})";
            return retval;
        }

    }
}

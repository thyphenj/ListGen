using System.Drawing;

namespace Paint
{
    class Cell
    {
        private static readonly int OFFSET = 10;
        private static readonly int CELLSIZE = 20;

        public Point Location { get; set; }
        public int[] Thickness { get; set; }
        public int Y;
        public int X;

        public Clue Clue;

        public Cell(int y, int x)
        {
            Y = y;
            X = x;

            Location = new Point(OFFSET + CELLSIZE * x, OFFSET + CELLSIZE * y);
            Thickness = new int[] { 1, 1 };
        }

        public void AddClue(Clue clue)
        {
            Clue = clue;
        }

        public void DrawCell(Graphics graphics)
        {
            using (var pen = new Pen(Color.Black))
            {
                pen.Width = Thickness[0];
                graphics.DrawLine(pen, Location.X + CELLSIZE, Location.Y, Location.X + CELLSIZE, Location.Y + CELLSIZE);
                pen.Width = Thickness[1];
                graphics.DrawLine(pen, Location.X + CELLSIZE, Location.Y + CELLSIZE, Location.X, Location.Y + CELLSIZE);

                if (Clue != null)
                    using (var drawFont = new Font("Arial", 8))
                    {
                        var drawBrush = new SolidBrush(Color.Black);
                        System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                        graphics.DrawString(Clue.Num, drawFont, drawBrush, Location.X + 2, Location.Y + 2, drawFormat);
                    }

                pen.Width = 2;
                if (X == 0)
                    graphics.DrawLine(pen, Location.X, Location.Y, Location.X, Location.Y + CELLSIZE);
                if (Y == 0)
                    graphics.DrawLine(pen, Location.X, Location.Y, Location.X + CELLSIZE, Location.Y);

            }
        }
    }
}
using System.Drawing;

namespace Paint
{
    enum thickness { thin = 1, thick = 5 };
    class Cell
    {
        private static readonly int OFFSET = 10;
        private static readonly int CELLSIZE = 40;

        public Point Location { get; set; }
        public thickness[] Thickness { get; set; }

        public int Y { get; set; }
        public int X { get; set; }

        public Clue[] Clue { get; set; }

        public Cell(int y, int x)
        {
            Y = y;
            X = x;

            Location = new Point(OFFSET + CELLSIZE * X, OFFSET + CELLSIZE * Y);
            Thickness = new thickness[] { thickness.thick, thickness.thick };

            Clue = new Clue[2];
        }

        public void AddClue(Clue clue)
        {
            Clue[(int)clue.Dir] = clue;
        }

        public void SetDirection(direction dir)
        {
            if (dir == direction.ac)
                Thickness[0] = thickness.thin;
            else
                Thickness[1] = thickness.thin;

        }

        public void DrawCell(Graphics graphics)
        {
            using (var pen = new Pen(Color.Black))
            {
                // --- draw Eastern and Northern borders fir the top row and leftmost column
                pen.Width = (int)thickness.thick; ;
                if (X == 0)
                    graphics.DrawLine(pen, Location.X, Location.Y, Location.X, Location.Y + CELLSIZE);
                if (Y == 0)
                    graphics.DrawLine(pen, Location.X, Location.Y, Location.X + CELLSIZE, Location.Y);

                // --- draw Eastern boarder
                pen.Width = (int)Thickness[0];
                graphics.DrawLine(pen, Location.X + CELLSIZE, Location.Y, Location.X + CELLSIZE, Location.Y + CELLSIZE);


                // --- draw Southern border
                pen.Width = (int)Thickness[1];
                graphics.DrawLine(pen, Location.X + CELLSIZE, Location.Y + CELLSIZE, Location.X, Location.Y + CELLSIZE);

                // --- draw the clue number
                if (Clue[0] != null || Clue[1] != null)
                    using (var drawFont = new Font("Arial", 8))
                    using (var drawBrush = new SolidBrush(Color.Black))
                    using (var drawFormat = new StringFormat())
                        graphics.DrawString(Clue[Clue[0] == null ? 1 : 0].Num, drawFont, drawBrush, Location.X + 2, Location.Y + 2, drawFormat);
            }
        }
    }
}
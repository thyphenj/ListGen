using System.Drawing;
using System.Collections.Generic;

namespace ListGen
{
    class Cell
    {
        private static readonly int OFFSET = 30;
        private static readonly int CELLSIZE = 50;

        public Point Location { get; set; }
        public LineThickness[] Thickness { get; set; }

        public int Y { get; set; }
        public int X { get; set; }

        public Clue[] Clue { get; set; }
        public Dictionary<string,Clue> Clue2 { get; set; }

        public Cell(int y, int x)
        {
            Y = y;
            X = x;

            Location = new Point(OFFSET + CELLSIZE * X, OFFSET + CELLSIZE * Y);
            Thickness = new LineThickness[] { LineThickness.lineThick, LineThickness.lineThick };

            Clue = new Clue[2];
   
        }

        public void AddClue(Clue clue)
        {
            Clue[(int)clue.Dir] = clue;
        }

        public void SetDirection(ClueDirection dir)
        {
            // --- if we have an across clue coming through this cell clear the East border
            // --- if it's a down clue then remove the South border
            if (dir == ClueDirection.ac)
                Thickness[0] = LineThickness.lineThin;
            else
                Thickness[1] = LineThickness.lineThin;

        }

        public void DrawCell(Graphics graphics)
        {
            using (var pen = new Pen(Color.Black))
            {
                // --- draw Western and Northern borders for the top row and leftmost column
                pen.Width = (int)LineThickness.lineThick; ;
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
                    using (var drawFont = new Font("Arial", 12))
                    using (var drawBrush = new SolidBrush(Color.Black))
                    using (var drawFormat = new StringFormat())
                        graphics.DrawString(Clue[Clue[0] == null ? 1 : 0].Num, drawFont, drawBrush, Location.X + 2, Location.Y + 2, drawFormat);
            }
        }
    }
}

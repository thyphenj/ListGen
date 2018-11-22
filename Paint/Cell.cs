using System.Drawing;

namespace Paint
{
    class Cell
    {
        private static readonly int OFFSET = 10;
        private static readonly int CELLSIZE = 20;

        public Point Location { get; set; }
        public int[] Thickness { get; set; }

        public Cell(int y, int x)
        {
            Location = new Point(OFFSET + CELLSIZE * x, OFFSET + CELLSIZE * y);
            Thickness = new int[] { 1, 1 };
        }

        public void AddClue(Clue clue)
        {
            System.Console.WriteLine(clue.Text);
        }

        public void DrawCell(Graphics graphics)
        {
            using (var pen = new Pen(Color.Black))
            {
                pen.Width = Thickness[0];
                graphics.DrawLine(pen, Location.X + CELLSIZE, Location.Y, Location.X + CELLSIZE, Location.Y + CELLSIZE);
                pen.Width = Thickness[1];
                graphics.DrawLine(pen, Location.X + CELLSIZE, Location.Y + CELLSIZE, Location.X, Location.Y + CELLSIZE);
            }
        }
    }
}
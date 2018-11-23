using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace Paint
{
    class Grid
    {
        public Cell[,] Cells;
        readonly int Height;
        readonly int Width;

        public Grid(int height, int width)
        {
            Width = width;
            Height = height;

            Cells = new Cell[Height, Width];

            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    Cells[i, j] = new Cell(i, j);
        }

        public void AddClues(List<Clue> clues)
        {
            foreach (Clue clue in clues)
            {
                int y = clue.Y;
                int x = clue.X;

                Cells[y, x].AddClue(clue);

                for (int i = 0; i < clue.Len - 1; i++)
                    if (clue.Dir == ClueDirection.ac)
                        Cells[y, x + i].SetDirection(clue.Dir);
                    else
                        Cells[y + i, x].SetDirection(clue.Dir);
            }
        }

        public void DrawGrid(Graphics graphics)
        {
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    if (Cells[i, j] != null)
                        Cells[i, j].DrawCell(graphics);
        }

        public void DrawClues(Graphics graphics, List<Clue> clues)
        {
            string str = "Across\n\n";
            foreach (var clue in clues.Where(a => a.Dir == ClueDirection.ac))
            {
                str += $"  {clue.Num.PadLeft(2)}   {clue.Text} ({clue.Len})\n";
            }
            str += "\nDown\n\n";
            foreach (var clue in clues.Where(a => a.Dir == ClueDirection.dn))
            {
                str += $"  {clue.Num.PadLeft(2)}   {clue.Text} ({clue.Len})\n";
            }

            using (var drawFont = new Font("Arial", 10))
            using (var drawBrush = new SolidBrush(Color.Black))
            using (var drawFormat = new StringFormat())
                foreach (var clue in clues.Where(a => a.Dir == ClueDirection.ac))
                {
                    graphics.DrawString(str, drawFont, drawBrush, 400, 10, drawFormat);
                }
        }
    }
}

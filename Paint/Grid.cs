using System.Drawing;
using System.Collections.Generic;

namespace Paint
{
    class Grid
    {
        readonly Cell[,] Cells;
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
                if (clue.Dir == direction.ac)
                {
                    if (x > 0) Cells[y, x - 1].Thickness[0] = 2;
                    Cells[y, x - 1 + clue.Len].Thickness[0] = 2;
                }
                else
                {
                    if (y > 0) Cells[y - 1, x].Thickness[1] = 2;
                    Cells[y - 1 + clue.Len, x].Thickness[1] = 2;
                }
            }
        }

        public void Draw(Graphics graphics)
        {
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    if (Cells[i, j] != null)
                        Cells[i, j].DrawCell(graphics);
        }
    }
}
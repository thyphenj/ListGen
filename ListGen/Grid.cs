using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListGen
{
    class Grid
    {
        readonly int Height;
        readonly int Width;

        public Cell[,] Cells;

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

        public string AcrossCluesString(List<Clue> clues)
        {
            string str = "Across\n\n";
            foreach (var clue in clues.Where(a => a.Dir == ClueDirection.ac))
            {
                str += clue.ToString() + "\n";
            }
            return str + "\n";
        }

        public string DownCluesString(List<Clue> clues)
        {
            string str = "Down\n\n";
            foreach (var clue in clues.Where(a => a.Dir == ClueDirection.dn))
            {
                str += clue.ToString() + "\n";
            }
            return str + "\n";
        }

        public void DrawClues(Graphics graphics, List<Clue> clues, ClueDirection dir)
        {
            using (var drawFont = new Font("Arial", 10))
            using (var drawBrush = new SolidBrush(Color.Black))
            {
                string cl;
                if ( dir == ClueDirection.ac)
                    cl  = AcrossCluesString(clues);
                else
                    cl = DownCluesString(clues);

                graphics.DrawString(cl, drawFont, drawBrush, 10, 10);
            }
        }
    }
}

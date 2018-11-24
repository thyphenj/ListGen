using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace ListGen
{
    class Puzzle
    {
        public int number;
        public string title;
        public string author;

        public string rubric;

        public Grid grid;
        public List<Clue> clues;

        public Puzzle()
        {
            Listener4399();
            //Listener4451();
            //Listener4516();
        }

        public void Draw(PaintEventArgs ev)
        {
            System.Drawing.Graphics g = ev.Graphics;

            DrawHeader(g);

            grid.DrawGrid(g);

            DrawRubric(g);

            grid.DrawClues(g, clues);
        }
        public void DrawHeader(Graphics g)
        {
            using (var drawFont = new Font("Arial", 18))
            using (var drawBrush = new SolidBrush(Color.Black))
            using (var drawFormat = new StringFormat())
            {
                g.DrawString($"The Listener CrossWord No {number} {title} by {author}", drawFont, drawBrush, 0, 0, drawFormat);
            }

        }

        public void DrawRubric(Graphics g)
        {
            using (var drawFont = new Font("Arial", 18))
            using (var drawBrush = new SolidBrush(Color.Black))
            using (var drawFormat = new StringFormat())
            {
                g.DrawString(rubric, drawFont, drawBrush, 10, 400, drawFormat);
            }
        }
        private void Listener4399()
        {
            number = 4399;
            title = "Square Time Sums";
            author = "Oyler";
            rubric =
                "The letter variables used in the clues form four triples (A, B, C), (J, K, L), (P, Q, R) and (X, Y, Z).\n" +
                "where each triple consists of square numbers of two, three and four digits respectively, that between\n" +
                "them contain all the digits from 1 to 9 inclusive. After filling the grid, solvers must identify and\n" +
                "highlight two complete rows and two complete columns that are related to the theme. No entry" +
                "starts with zero and all are different.";

            // --- Create a grid
            grid = new Grid(height: 9, width: 9);

            // --- Add some clues
            clues = new List<Clue>
                {
                    // --- ACROSS

                    new Clue( 0, 0, "1", 2, "J", ClueDirection.ac),
                    new Clue( 0, 2, "3", 2, "6ac + 7dn"),
                    new Clue( 0, 5, "6", 2, "17ac - B"),
                    new Clue( 0, 7, "8", 2, "Multiple of 42dn"),

                    new Clue( 1, 0, "9", 3, "K"),
                    new Clue( 1, 4, "11", 2, "P"),
                    new Clue( 1, 6, "13", 3, "Multiple of(44dn - J)"),

                    new Clue( 2, 0, "15", 4, "L"),
                    new Clue( 2, 4, "16", 2, "P - A"),
                    new Clue( 2, 6, "17", 3, "Multiple of 5dn"),

                    new Clue( 3, 0, "18", 2, "A - X"),
                    new Clue( 3, 2, "20", 3, "7 x A"),
                    new Clue( 3, 5, "22", 2, "Factor of Q"),
                    new Clue( 3, 7, "23", 2, "Prime"),

                    new Clue( 4, 1, "25", 3, "Q"),
                    new Clue( 4, 5, "27", 3, "8 x P + 10 x X"),

                    new Clue( 5, 0, "29", 2, "X"),
                    new Clue( 5, 2, "31", 2, "Factor of C"),
                    new Clue( 5, 4, "33", 3, "27dn + 28dn"),
                    new Clue( 5, 7, "35", 2, "Factor of 36ac"),

                    new Clue( 6, 0, "36", 3, "Multiple of 35ac"),
                    new Clue( 6, 3, "37", 2, "P - 7dn"),
                    new Clue( 6, 5, "38", 4, "Multiple of (2 x A + 2 x J + 3 * X)"),

                    new Clue( 7, 0, "41", 3, "Prime"),
                    new Clue( 7, 3, "43", 2, "Prime"),
                    new Clue( 7, 6, "45", 3, "Y - 37ac"),

                    new Clue( 8, 0, "46", 2, "Reverse of 31ac"),
                    new Clue( 8, 2, "47", 2, "Factor of 16dn"),
                    new Clue( 8, 5, "48", 2, "Multiple of 37ac"),
                    new Clue( 8, 7, "49", 2, "A"),

                    // --- DOWN

                    new Clue( 0, 0, "1", 3, "7 x X", ClueDirection.dn),
                    new Clue( 0, 1, "2", 3, "Prime"),
                    new Clue( 0, 3, "4", 3, "K + P - A"),
                    new Clue( 0, 4, "5", 2, "Factor of C"),
                    new Clue( 0, 6, "7", 2, "P - 37ac"),
                    new Clue( 0, 7, "8", 4, "Z"),

                    new Clue( 1, 2, "10", 3, "33ac + 38dn"),
                    new Clue( 1, 5, "12", 3, "B - Q"),
                    new Clue( 1, 8, "14", 4, "B + Q - 22ac"),

                    new Clue( 2, 4, "16", 5, "2 x (C + L + R + Z)"),
                    new Clue( 2, 6, "17", 3, "B"),

                    new Clue( 3, 1, "19", 2, "Factor of 45ac"),
                    new Clue( 3, 3, "21", 2, "48ac - A"),

                    new Clue( 4, 0, "24", 4, "R"),
                    new Clue( 4, 2, "26", 3, "17ac - 31ac"),
                    new Clue( 4, 5, "27", 2, "33ac - 28dn"),
                    new Clue( 4, 7, "28", 2, "33ac - 27dn"),

                    new Clue( 5, 1, "30", 4, "C"),
                    new Clue( 5, 3, "32", 3, "Y"),
                    new Clue( 5, 6, "34", 3, "Prime"),

                    new Clue( 6, 5, "38", 3, "10dn - 33ac"),
                    new Clue( 6, 7, "39", 3, "Multiple of 43ac"),
                    new Clue( 6, 8, "40", 3, "19dn + Y"),

                    new Clue( 7, 2, "42", 2, "Prime"),
                    new Clue( 7, 4, "44", 2, "5 x 19dn")
                };

            // --- Put the clues on the grid
            grid.AddClues(clues);
        }

        private void Listener4451()
        {
            // --- Create a grid
            grid = new Grid(height: 4, width: 5);

            // --- Add some clues
            clues = new List<Clue>
            {
                new Clue( 0, 0, "1", 2, "Sum of all 20 digits in the grid", ClueDirection.ac),
                new Clue( 0, 2, "2", 3, "Multiple of another grid entry"),
                new Clue( 1, 0, "4", 3, "One row of the Playfair code-square"),
                new Clue( 2, 2, "7", 3, "Divisor of 3dn"),
                new Clue( 3, 0, "8", 3, "One column of the Playafair code-square"),
                new Clue( 3, 3, "9", 2, "The Playfair code-number for this puzzle"),

                new Clue( 0, 0, "1", 3, "A square minus the grid entry at 1ac", ClueDirection.dn),
                new Clue( 0, 2, "2", 2, "Sum of the digits of 7ac"),
                new Clue( 0, 3, "3", 3, "Reverse of 2ac"),
                new Clue( 1, 1, "5", 3, "Amagram of 6dn"),
                new Clue( 1, 4, "6", 3, "Square"),
                new Clue( 2, 2, "7", 2, "Prime")
            };

            // --- Put the clues on the grid
            grid.AddClues(clues);
        }

        private void Listener4516()
        {
            // --- Create a grid
            grid = new Grid(height: 9, width: 9);

            // --- Add some clues
            clues = new List<Clue>
                {
                    // --- ACROSS

                    new Clue( 0, 0, "1", 3, "150", ClueDirection.ac),
                    new Clue( 0, 3, "3", 3, "220"),
                    new Clue( 0, 7, "6", 2, "7"),
                    new Clue( 1, 4, "9", 5, "23994"),
                    new Clue( 2, 0, "10", 5, "137"),
                    new Clue( 2, 5, "11", 4, "57"),
                    new Clue( 3, 0, "13", 5, "32984"),
                    new Clue( 3, 5, "15", 3, "15"),
                    new Clue( 4, 0, "16", 3, "15"),
                    new Clue( 4, 6, "18", 3, "39"),
                    new Clue( 5, 1, "20", 3, "39"),
                    new Clue( 5, 4, "22", 5, "31746"),
                    new Clue( 6, 0, "25", 4, "1410"),
                    new Clue( 6, 4, "26", 5, "9044"),
                    new Clue( 7, 0, "27", 5, "10726"),
                    new Clue( 8, 0, "29", 2, "11"),
                    new Clue( 8, 3, "30", 3, "90"),
                    new Clue( 8, 6, "31", 3, "144"),



                    new Clue( 0, 0, "1", 4, "1596", ClueDirection.dn),
                    new Clue( 0, 2, "2", 2, "4"),
                    new Clue( 0, 3, "3", 4, "1190"),
                    new Clue( 0, 5, "4", 5, "145"),
                    new Clue( 0, 6, "5", 4, "306"),
                    new Clue( 0, 8, "7", 2, "13"),
                    new Clue( 1, 1, "8", 4, "35"),
                    new Clue( 1, 4, "9", 2, "13"),
                    new Clue( 2, 8, "12", 3, "290"),
                    new Clue( 3, 4, "14", 3, "27"),
                    new Clue( 4, 0, "16", 3, "19"),
                    new Clue( 4, 3, "17", 5, "22374"),
                    new Clue( 4, 7, "19", 4, "65"),
                    new Clue( 5, 2, "21", 4, "924"),
                    new Clue( 5, 5, "23", 4, "97"),
                    new Clue( 5, 8, "24", 4, "2754"),
                    new Clue( 6, 4, "26", 2, "5"),
                    new Clue( 7, 0, "27", 2, "6"),
                    new Clue( 7, 6, "28", 2, "9")
            };

            // --- Put the clues on the grid
            grid.AddClues(clues);
        }
    }
}

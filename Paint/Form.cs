using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form : System.Windows.Forms.Form
    {
        Grid grid;
        List<Clue> clues;

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs eva)
        {
            // --- Run with ONE of the puzzles
            Listener4399();
            // Listener4451();

            // --- Put the clues on the grid
            grid.AddClues(clues);
        }

        private void Form_Paint(object sender, PaintEventArgs ev)
        {
            grid.DrawGrid(ev.Graphics);

            grid.DrawClues(ev.Graphics, clues);
        }

        //--------------------------------------------------------------------------------------------------------------------------------

        private void Listener4399()
        {
            // --- Create a grid
            grid = new Grid(height: 9, width: 9);

            // --- Add some clues
            clues = new List<Clue>
            {
                new Clue( 0, 0, "1", ClueDirection.ac, 2, "J"),
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


                new Clue( 0, 0, "1", ClueDirection.dn, 3, "7 x X"),
                new Clue( 0, 1, "2", 3, "Prime"),
                new Clue( 0, 3, "4", 3, "K + P - A"),
                new Clue( 0, 4, "5", 2, "Factor of C"),
                new Clue( 0, 6, "7", 2, "P - 37ac"),
                new Clue( 0, 7, "8", 4, "Z"),
                new Clue( 1, 2, "10", 3, "33ac + 38dn"),
                new Clue( 1, 5, "12", 3, "B - Q"),
                new Clue( 1, 8, "14", 4, "B + Q - 22ac")
            };
        }

        private void Listener4451()
        {
            // --- Create a grid
            grid = new Grid(height: 4, width: 5);

            // --- Add some clues
            clues = new List<Clue>
            {
                new Clue( 0, 0, "1", ClueDirection.ac, 2, "Sum of all 20 digits in the grid"),
                new Clue( 0, 2, "2", 3, "Multiple of another grid entry"),
                new Clue( 1, 0, "4", 3, "One row of the Playfair code-square"),
                new Clue( 2, 2, "7", 3, "Divisor of 3dn"),
                new Clue( 3, 0, "8", 3, "One column of the Playafair code-square"),
                new Clue( 3, 3, "9", 2, "The Playfair code-number for this puzzle"),

                new Clue( 0, 0, "1", ClueDirection.dn, 3, "A square minus the grid entry at 1ac"),
                new Clue( 0, 2, "2", 2, "Sum of the digits of 7ac"),
                new Clue( 0, 3, "3", 3, "Reverse of 2ac"),
                new Clue( 1, 1, "5", 3, "Amagram of 6dn"),
                new Clue( 1, 4, "6", 3, "Square"),
                new Clue( 2, 2, "7", 2, "Prime")
            };

        }
    }
}

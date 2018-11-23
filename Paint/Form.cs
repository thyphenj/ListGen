using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Paint
{
    enum direction { ac = 0, dn = 1 };

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
            //Listener4399();
             Listener4451();
        }

        private void Listener4399()
        {
            //Create a grid
            grid = new Grid(height: 9, width: 9);

            //Add some clues
            clues = new List<Clue>
            {
                new Clue( 0, 0, "1", direction.ac, 2, "J"),
                new Clue( 0, 2, "3", direction.ac, 2, "6ac + 7dn"),
                new Clue( 0, 5, "6", direction.ac, 2, "17ac - B"),
                new Clue( 0, 7, "8", direction.ac, 2, "Multiple of 42dn"),

                new Clue( 1, 0, "9", direction.ac, 3, "K"),
                new Clue( 1, 4, "11", direction.ac, 2, "P"),
                new Clue( 1, 6, "13", direction.ac, 3, "Multiple of(44dn - J)"),

                new Clue( 2, 0, "15", direction.ac, 4, "L"),
                new Clue( 2, 4, "16", direction.ac, 2, "P - A"),
                new Clue( 2, 6, "17", direction.ac, 3, "Multiple of 5dn"),

                new Clue( 3, 0, "18", direction.ac, 2, "A - X"),
                new Clue( 3, 2, "20", direction.ac, 3, "7 x A"),
                new Clue( 3, 5, "22", direction.ac, 2, "Factor of Q"),
                new Clue( 3, 7, "23", direction.ac, 2, "Prime"),



                new Clue( 0, 0, "1", direction.dn, 3, "7 x X"),
                new Clue( 0, 1, "2", direction.dn, 3, "Prime"),
                new Clue( 0, 3, "4", direction.dn, 3, "K + P - A"),
                new Clue( 0, 4, "5", direction.dn, 2, "Factor of C"),
                new Clue( 0, 6, "7", direction.dn, 2, "P - 37ac"),
                new Clue( 0, 7, "8", direction.dn, 4, "Z"),
                new Clue( 1, 2, "10", direction.dn, 3, "33ac + 38dn"),
                new Clue( 1, 5, "12", direction.dn, 3, "B - Q"),
                new Clue( 1, 8, "14", direction.dn, 4, "B + Q - 22ac")
            };

            //Put the clues on the grid
            grid.AddClues(clues);
        }

        private void Listener4451()
        {
            //Create a grid
            grid = new Grid(height: 4, width: 5);

            //Add some clues
            clues = new List<Clue>
            {
                new Clue( 0, 0, "1", direction.ac, 2, "Sum of all 20 digits in the grid"),
                new Clue( 0, 2, "2", direction.ac, 3, "Multiple of another grid entry"),
                new Clue( 1, 0, "4", direction.ac, 3, "One row of the Playfair code-square"),
                new Clue( 2, 2, "7", direction.ac, 3, "Divisor of 3dn"),
                new Clue( 3, 0, "8", direction.ac, 3, "One column of the Playafair code-square"),
                new Clue( 3, 3, "9", direction.ac, 2, "The Playfair code-number for this puzzle"),

                new Clue( 0, 0, "1", direction.dn, 3, "A square minus the grid entry at 1ac"),
                new Clue( 0, 2, "2", direction.dn, 2, "Sum of the digits of 7ac"),
                new Clue( 0, 3, "3", direction.dn, 3, "Reverse of 2ac"),
                new Clue( 1, 1, "5", direction.dn, 3, "Amagram of 6dn"),
                new Clue( 1, 4, "6", direction.dn, 3, "Square"),
                new Clue( 2, 2, "7", direction.dn, 2, "Prime")
            };

            //Put the clues on the grid
            grid.AddClues(clues);

        }

        private void Form_Paint(object sender, PaintEventArgs ev)
        {
            grid.DrawGrid(ev.Graphics);

            grid.DrawClues(ev.Graphics, clues);
        }
    }
}

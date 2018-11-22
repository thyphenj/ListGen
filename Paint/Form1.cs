using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Paint
{
    enum direction {ac, dn };

    public partial class Form1 : Form
    {
        Grid grid;
        List<Clue> clues;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create a grid
            grid = new Grid(height:6, width:8);

            //Add some clues
            clues = new List<Clue>
            {
                new Clue(0, 0,"1", direction.ac,  4, "1 across at 0, 0 is 4 long"),
                new Clue(1, 2,"3", direction.dn,  2, "3 down at 1, 2 is 2 long")
            };

            //Put the clues on the grid
            grid.AddClues(clues);
        }

        private void Form1_Paint(object sender, PaintEventArgs ev)
        {
            grid.Draw(ev.Graphics);
        }
    }
}

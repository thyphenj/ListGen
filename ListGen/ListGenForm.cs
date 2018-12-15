using System;
using System.Drawing;
using System.Windows.Forms;

namespace ListGen
{
    public partial class ListGenForm : Form
    {
        private Puzzle puzzle;

        public ListGenForm()
        {
            InitializeComponent ();
        }

        private void Form_Load(object sender, EventArgs eva)
        {
            puzzle = new Puzzle ();

            lblTitle.Text = puzzle.ToString ();
            lblRubric.Text = puzzle.GetRubric ();
        }

        private void pnlGrid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlGrid.CreateGraphics ();
            puzzle.DrawGrid (g);
        }

        private void pnlClues_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlClues.CreateGraphics ();
            puzzle.DrawClues (g);
        }
    }
}

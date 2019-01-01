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

            this.Size = new Size (1400,830);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point (1, 1);

            puzzle = new Puzzle ();

            lblTitle.Text = puzzle.ToString ();
            lblRubric.Text = puzzle.GetRubric ();
        }

        private void pnlGrid_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlGrid.CreateGraphics ();
            puzzle.DrawGrid (g);
        }

        private void pnlAcross_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlAcross.CreateGraphics ();
            puzzle.DrawAcrossClues (g);
        }

        private void pnlDown_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlDown.CreateGraphics ();
            puzzle.DrawDownClues (g);
        }
    }
}

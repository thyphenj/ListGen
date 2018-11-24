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
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs eva)
        {
            puzzle = new Puzzle();

            lblTitle.Text = puzzle.ToString();
            lblRubric.Text = puzzle.GetRubric();

 
            
        }

        private void Form_Paint(object sender, PaintEventArgs ev)
        {
            Graphics g = pnlGrid.CreateGraphics();
            puzzle.Draw(g);
        }
    }
}

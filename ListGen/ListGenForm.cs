using System;
using System.Collections.Generic;
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
        }

        private void Form_Paint(object sender, PaintEventArgs ev)
        {
            puzzle.Draw(ev);
        }
    }
}

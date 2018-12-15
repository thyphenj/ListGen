namespace ListGen
{
    partial class ListGenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRubric = new System.Windows.Forms.Label();
            this.pnlClues = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlGrid.AutoSize = true;
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGrid.Location = new System.Drawing.Point(35, 64);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(614, 443);
            this.pnlGrid.TabIndex = 1;
            this.pnlGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrid_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(35, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 33);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "lblTitle";
            // 
            // lblRubric
            // 
            this.lblRubric.AutoSize = true;
            this.lblRubric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubric.Location = new System.Drawing.Point(35, 520);
            this.lblRubric.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRubric.Name = "lblRubric";
            this.lblRubric.Size = new System.Drawing.Size(72, 22);
            this.lblRubric.TabIndex = 4;
            this.lblRubric.Text = "lblRubric";
            // 
            // pnlClues
            // 
            this.pnlClues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlClues.AutoSize = true;
            this.pnlClues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClues.Location = new System.Drawing.Point(653, 64);
            this.pnlClues.Margin = new System.Windows.Forms.Padding(2);
            this.pnlClues.Name = "pnlClues";
            this.pnlClues.Size = new System.Drawing.Size(724, 443);
            this.pnlClues.TabIndex = 5;
            this.pnlClues.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClues_Paint);
            // 
            // ListGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1515, 583);
            this.Controls.Add(this.pnlClues);
            this.Controls.Add(this.lblRubric);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlGrid);
            this.Name = "ListGenForm";
            this.Text = "Listener";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRubric;
        private System.Windows.Forms.Panel pnlClues;
    }
}
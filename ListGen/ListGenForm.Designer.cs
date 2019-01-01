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
            this.pnlAcross = new System.Windows.Forms.Panel();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGrid.Location = new System.Drawing.Point(10, 92);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1000, 1000);
            this.pnlGrid.TabIndex = 1;
            this.pnlGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrid_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 65);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "lblTitle";
            // 
            // lblRubric
            // 
            this.lblRubric.AutoSize = true;
            this.lblRubric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubric.Location = new System.Drawing.Point(10, 1107);
            this.lblRubric.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRubric.Name = "lblRubric";
            this.lblRubric.Size = new System.Drawing.Size(122, 33);
            this.lblRubric.TabIndex = 1;
            this.lblRubric.Text = "lblRubric";
            // 
            // pnlAcross
            // 
            this.pnlAcross.AutoSize = true;
            this.pnlAcross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAcross.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAcross.Location = new System.Drawing.Point(1018, 92);
            this.pnlAcross.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAcross.Name = "pnlAcross";
            this.pnlAcross.Size = new System.Drawing.Size(800, 1000);
            this.pnlAcross.TabIndex = 5;
            this.pnlAcross.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAcross_Paint);
            // 
            // pnlDown
            // 
            this.pnlDown.AutoSize = true;
            this.pnlDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDown.Location = new System.Drawing.Point(1826, 92);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(800, 1000);
            this.pnlDown.TabIndex = 6;
            this.pnlDown.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDown_Paint);
            // 
            // ListGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2884, 1200);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.pnlAcross);
            this.Controls.Add(this.lblRubric);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlGrid);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.Panel pnlAcross;
        private System.Windows.Forms.Panel pnlDown;
    }
}
namespace SplooshKaboom
{
    partial class frmWinOrLost
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
            lblWinOrLost = new Label();
            SuspendLayout();
            // 
            // lblWinOrLost
            // 
            lblWinOrLost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWinOrLost.AutoSize = true;
            lblWinOrLost.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWinOrLost.Location = new Point(130, 117);
            lblWinOrLost.Name = "lblWinOrLost";
            lblWinOrLost.Size = new Size(570, 128);
            lblWinOrLost.TabIndex = 0;
            lblWinOrLost.Text = "Win Or Lose";
            // 
            // frmWinOrLost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblWinOrLost);
            Name = "frmWinOrLost";
            Text = "WinOrLose";
            FormClosing += endEvereything;
            FormClosed += endit;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWinOrLost;
    }
}
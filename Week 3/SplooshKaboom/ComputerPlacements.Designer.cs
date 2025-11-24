namespace SplooshKaboom
{
    partial class frmComputerPlacements
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
            components = new System.ComponentModel.Container();
            pnlBoard = new Panel();
            lblSub = new Label();
            lblDestroy = new Label();
            lblCruis = new Label();
            tmrEndTurn = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // pnlBoard
            // 
            pnlBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBoard.Location = new Point(203, 71);
            pnlBoard.Name = "pnlBoard";
            pnlBoard.Size = new Size(700, 700);
            pnlBoard.TabIndex = 0;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSub.Location = new Point(12, 9);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(129, 32);
            lblSub.TabIndex = 1;
            lblSub.Text = "Submarine";
            // 
            // lblDestroy
            // 
            lblDestroy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDestroy.AutoSize = true;
            lblDestroy.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDestroy.Location = new Point(984, 9);
            lblDestroy.Name = "lblDestroy";
            lblDestroy.Size = new Size(117, 32);
            lblDestroy.TabIndex = 2;
            lblDestroy.Text = "Destroyer";
            // 
            // lblCruis
            // 
            lblCruis.Anchor = AnchorStyles.Top;
            lblCruis.AutoSize = true;
            lblCruis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCruis.Location = new Point(492, 9);
            lblCruis.Name = "lblCruis";
            lblCruis.Size = new Size(88, 32);
            lblCruis.TabIndex = 3;
            lblCruis.Text = "Cruiser";
            // 
            // tmrEndTurn
            // 
            tmrEndTurn.Enabled = true;
            tmrEndTurn.Interval = 1000;
            tmrEndTurn.Tick += tmrEndTurn_Tick;
            // 
            // frmComputerPlacements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 783);
            Controls.Add(lblCruis);
            Controls.Add(lblDestroy);
            Controls.Add(lblSub);
            Controls.Add(pnlBoard);
            Name = "frmComputerPlacements";
            Text = "ComputerPlacements";
            Activated += CheckForButtons;
            Load += StartProgram;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBoard;
        private Label lblSub;
        private Label lblDestroy;
        private Label lblCruis;
        private System.Windows.Forms.Timer tmrEndTurn;
    }
}
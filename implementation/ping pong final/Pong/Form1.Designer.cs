namespace Pong
{
    partial class GameForm
    {
        
        private System.ComponentModel.IContainer components = null;

       
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RightPanel = new System.Windows.Forms.Panel();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Panel();
            this.scorep2panel = new System.Windows.Forms.Label();
            this.scorep1panel = new System.Windows.Forms.Label();
            this.ballPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Location = new System.Drawing.Point(12, 12);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(12, 49);
            this.LeftPanel.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.White;
            this.RightPanel.Location = new System.Drawing.Point(476, 12);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(12, 49);
            this.RightPanel.TabIndex = 1;
            this.RightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RightPanel_Paint);
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseLabel.ForeColor = System.Drawing.Color.White;
            this.pauseLabel.Location = new System.Drawing.Point(155, 62);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(190, 62);
            this.pauseLabel.TabIndex = 2;
            this.pauseLabel.Text = "START GAME\nPRESS ENTER";
            this.pauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pauseLabel.UseMnemonic = false;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.White;
            this.line.Location = new System.Drawing.Point(249, 0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(2, 200);
            this.line.TabIndex = 3;
            // 
            // scorep2panel
            // 
            this.scorep2panel.AutoSize = true;
            this.scorep2panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorep2panel.ForeColor = System.Drawing.Color.White;
            this.scorep2panel.Location = new System.Drawing.Point(257, 12);
            this.scorep2panel.Name = "scorep2panel";
            this.scorep2panel.Size = new System.Drawing.Size(25, 25);
            this.scorep2panel.TabIndex = 4;
            this.scorep2panel.Text = "0";
            // 
            // scorep1panel
            // 
            this.scorep1panel.AutoSize = true;
            this.scorep1panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorep1panel.ForeColor = System.Drawing.Color.White;
            this.scorep1panel.Location = new System.Drawing.Point(218, 12);
            this.scorep1panel.Name = "scorep1panel";
            this.scorep1panel.Size = new System.Drawing.Size(25, 25);
            this.scorep1panel.TabIndex = 5;
            this.scorep1panel.Text = "0";
            this.scorep1panel.Click += new System.EventHandler(this.scorep1panel_Click);
            // 
            // ballPanel
            // 
            this.ballPanel.BackColor = System.Drawing.Color.White;
            this.ballPanel.Location = new System.Drawing.Point(244, 94);
            this.ballPanel.Name = "ballPanel";
            this.ballPanel.Size = new System.Drawing.Size(12, 12);
            this.ballPanel.TabIndex = 6;
            this.ballPanel.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.ballPanel);
            this.Controls.Add(this.scorep1panel);
            this.Controls.Add(this.scorep2panel);
            this.Controls.Add(this.line);
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.Label scorep2panel;
        private System.Windows.Forms.Label scorep1panel;
        private System.Windows.Forms.Panel ballPanel;


    }
}
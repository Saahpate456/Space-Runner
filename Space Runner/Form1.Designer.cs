namespace Space_Runner
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.abilityLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(110, 22);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "scoreLabel";
            // 
            // abilityLabel
            // 
            this.abilityLabel.AutoSize = true;
            this.abilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.abilityLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abilityLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.abilityLabel.Location = new System.Drawing.Point(12, 438);
            this.abilityLabel.Name = "abilityLabel";
            this.abilityLabel.Size = new System.Drawing.Size(130, 22);
            this.abilityLabel.TabIndex = 2;
            this.abilityLabel.Text = "abilityLabel";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(325, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(110, 22);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "titleLabel";
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameoverLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameoverLabel.Location = new System.Drawing.Point(311, 43);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(140, 22);
            this.gameoverLabel.TabIndex = 4;
            this.gameoverLabel.Text = "gameoverLabel";
            // 
            // fuelLabel
            // 
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.BackColor = System.Drawing.Color.Transparent;
            this.fuelLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fuelLabel.Location = new System.Drawing.Point(12, 486);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(100, 22);
            this.fuelLabel.TabIndex = 5;
            this.fuelLabel.Text = "fuelLabel";
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 20;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subtitleLabel.Location = new System.Drawing.Point(204, 77);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(140, 22);
            this.subtitleLabel.TabIndex = 6;
            this.subtitleLabel.Text = "subtitleLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.fuelLabel);
            this.Controls.Add(this.gameoverLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.abilityLabel);
            this.Controls.Add(this.scoreLabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label abilityLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Label fuelLabel;
        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label subtitleLabel;
    }
}


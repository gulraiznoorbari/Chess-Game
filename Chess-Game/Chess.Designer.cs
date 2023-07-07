namespace Chess_Game
{
    partial class Chess
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PlayButton.Location = new System.Drawing.Point(167, 12);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(227, 43);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Let\'s Play Chess";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(570, 440);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Chess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chess_Game.Properties.Resources.loadingscreen2;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PlayButton);
            this.Name = "Chess";
            this.Text = "Chess";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}


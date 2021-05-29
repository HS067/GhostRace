namespace RacingGame
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
            this.Better = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p1Button = new System.Windows.Forms.RadioButton();
            this.p2Button = new System.Windows.Forms.RadioButton();
            this.p3Button = new System.Windows.Forms.RadioButton();
            this.txtMaxBet = new System.Windows.Forms.Label();
            this.numBetAmount = new System.Windows.Forms.NumericUpDown();
            this.numThingNumber = new System.Windows.Forms.NumericUpDown();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblBetStatus1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBetStatus2 = new System.Windows.Forms.Label();
            this.lblBetStatus3 = new System.Windows.Forms.Label();
            this.btnRace = new System.Windows.Forms.Button();
            this.PB4 = new System.Windows.Forms.PictureBox();
            this.PB3 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThingNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // Better
            // 
            this.Better.AutoSize = true;
            this.Better.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Better.Location = new System.Drawing.Point(377, 301);
            this.Better.Name = "Better";
            this.Better.Size = new System.Drawing.Size(34, 23);
            this.Better.TabIndex = 0;
            this.Better.Text = "Bet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ON GHost";
            // 
            // p1Button
            // 
            this.p1Button.AutoSize = true;
            this.p1Button.BackColor = System.Drawing.Color.Salmon;
            this.p1Button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Button.Location = new System.Drawing.Point(38, 291);
            this.p1Button.Name = "p1Button";
            this.p1Button.Size = new System.Drawing.Size(101, 30);
            this.p1Button.TabIndex = 2;
            this.p1Button.TabStop = true;
            this.p1Button.Tag = "0";
            this.p1Button.Text = "Player1";
            this.p1Button.UseVisualStyleBackColor = false;
            this.p1Button.CheckedChanged += new System.EventHandler(this.allBetters_CheckedChanged);
            // 
            // p2Button
            // 
            this.p2Button.AutoSize = true;
            this.p2Button.BackColor = System.Drawing.Color.Salmon;
            this.p2Button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Button.Location = new System.Drawing.Point(38, 322);
            this.p2Button.Name = "p2Button";
            this.p2Button.Size = new System.Drawing.Size(101, 30);
            this.p2Button.TabIndex = 3;
            this.p2Button.TabStop = true;
            this.p2Button.Tag = "1";
            this.p2Button.Text = "Player2";
            this.p2Button.UseVisualStyleBackColor = false;
            this.p2Button.CheckedChanged += new System.EventHandler(this.allBetters_CheckedChanged);
            // 
            // p3Button
            // 
            this.p3Button.AutoSize = true;
            this.p3Button.BackColor = System.Drawing.Color.Salmon;
            this.p3Button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3Button.Location = new System.Drawing.Point(38, 354);
            this.p3Button.Name = "p3Button";
            this.p3Button.Size = new System.Drawing.Size(101, 30);
            this.p3Button.TabIndex = 4;
            this.p3Button.TabStop = true;
            this.p3Button.Tag = "2";
            this.p3Button.Text = "Player3";
            this.p3Button.UseVisualStyleBackColor = false;
            this.p3Button.CheckedChanged += new System.EventHandler(this.allBetters_CheckedChanged);
            // 
            // txtMaxBet
            // 
            this.txtMaxBet.AutoSize = true;
            this.txtMaxBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxBet.Location = new System.Drawing.Point(178, 322);
            this.txtMaxBet.Name = "txtMaxBet";
            this.txtMaxBet.Size = new System.Drawing.Size(56, 16);
            this.txtMaxBet.TabIndex = 5;
            this.txtMaxBet.Text = "Max Bet";
            // 
            // numBetAmount
            // 
            this.numBetAmount.Location = new System.Drawing.Point(426, 301);
            this.numBetAmount.Name = "numBetAmount";
            this.numBetAmount.Size = new System.Drawing.Size(120, 20);
            this.numBetAmount.TabIndex = 6;
            // 
            // numThingNumber
            // 
            this.numThingNumber.Location = new System.Drawing.Point(426, 363);
            this.numThingNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numThingNumber.Name = "numThingNumber";
            this.numThingNumber.Size = new System.Drawing.Size(120, 20);
            this.numThingNumber.TabIndex = 7;
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBet.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBet.Location = new System.Drawing.Point(308, 399);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(238, 43);
            this.btnBet.TabIndex = 10;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblBetStatus1
            // 
            this.lblBetStatus1.AutoSize = true;
            this.lblBetStatus1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblBetStatus1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetStatus1.Location = new System.Drawing.Point(708, 291);
            this.lblBetStatus1.Name = "lblBetStatus1";
            this.lblBetStatus1.Size = new System.Drawing.Size(162, 18);
            this.lblBetStatus1.TabIndex = 11;
            this.lblBetStatus1.Text = "Player1 has not bet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 12;
            // 
            // lblBetStatus2
            // 
            this.lblBetStatus2.AutoSize = true;
            this.lblBetStatus2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblBetStatus2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetStatus2.Location = new System.Drawing.Point(708, 322);
            this.lblBetStatus2.Name = "lblBetStatus2";
            this.lblBetStatus2.Size = new System.Drawing.Size(162, 18);
            this.lblBetStatus2.TabIndex = 13;
            this.lblBetStatus2.Text = "Player2 has not bet";
            // 
            // lblBetStatus3
            // 
            this.lblBetStatus3.AutoSize = true;
            this.lblBetStatus3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblBetStatus3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetStatus3.Location = new System.Drawing.Point(708, 354);
            this.lblBetStatus3.Name = "lblBetStatus3";
            this.lblBetStatus3.Size = new System.Drawing.Size(162, 18);
            this.lblBetStatus3.TabIndex = 14;
            this.lblBetStatus3.Text = "Player3 has not bet";
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRace.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnRace.Location = new System.Drawing.Point(671, 399);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(269, 41);
            this.btnRace.TabIndex = 22;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // PB4
            // 
            this.PB4.BackColor = System.Drawing.Color.Black;
            this.PB4.Image = global::RacingGame.Resource1.ghost4;
            this.PB4.Location = new System.Drawing.Point(19, 211);
            this.PB4.Name = "PB4";
            this.PB4.Size = new System.Drawing.Size(87, 63);
            this.PB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB4.TabIndex = 20;
            this.PB4.TabStop = false;
            // 
            // PB3
            // 
            this.PB3.BackColor = System.Drawing.Color.Black;
            this.PB3.Image = global::RacingGame.Resource1.ghost3;
            this.PB3.Location = new System.Drawing.Point(19, 155);
            this.PB3.Name = "PB3";
            this.PB3.Size = new System.Drawing.Size(87, 59);
            this.PB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB3.TabIndex = 19;
            this.PB3.TabStop = false;
            // 
            // PB2
            // 
            this.PB2.BackColor = System.Drawing.Color.Black;
            this.PB2.Image = global::RacingGame.Resource1.ghost2;
            this.PB2.Location = new System.Drawing.Point(19, 87);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(88, 72);
            this.PB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB2.TabIndex = 18;
            this.PB2.TabStop = false;
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.Color.Transparent;
            this.PB1.Image = global::RacingGame.Resource1.ghost1;
            this.PB1.Location = new System.Drawing.Point(20, 23);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(87, 69);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB1.TabIndex = 17;
            this.PB1.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::RacingGame.Resource1.bg;
            this.pbBackground.Location = new System.Drawing.Point(3, 3);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(973, 271);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 21;
            this.pbBackground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(979, 442);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.PB4);
            this.Controls.Add(this.PB3);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.lblBetStatus3);
            this.Controls.Add(this.lblBetStatus2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBetStatus1);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.numThingNumber);
            this.Controls.Add(this.numBetAmount);
            this.Controls.Add(this.txtMaxBet);
            this.Controls.Add(this.p3Button);
            this.Controls.Add(this.p2Button);
            this.Controls.Add(this.p1Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Better);
            this.Controls.Add(this.pbBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThingNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Better;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton p1Button;
        private System.Windows.Forms.RadioButton p2Button;
        private System.Windows.Forms.RadioButton p3Button;
        private System.Windows.Forms.Label txtMaxBet;
        private System.Windows.Forms.NumericUpDown numBetAmount;
        private System.Windows.Forms.NumericUpDown numThingNumber;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblBetStatus1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBetStatus2;
        private System.Windows.Forms.Label lblBetStatus3;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.PictureBox PB3;
        private System.Windows.Forms.PictureBox PB4;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Button btnRace;
    }
}


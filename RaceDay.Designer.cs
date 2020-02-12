namespace A_Day_at_the_Races
{
    partial class RacesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacesForm));
            this.finishLine = new System.Windows.Forms.PictureBox();
            this.Racetrack = new System.Windows.Forms.Panel();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.betsLabel = new System.Windows.Forms.Label();
            this.dogToWinUD = new System.Windows.Forms.NumericUpDown();
            this.bucksLabel = new System.Windows.Forms.Label();
            this.dollarUD = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.bettingParlorLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.finishLine)).BeginInit();
            this.Racetrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogToWinUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarUD)).BeginInit();
            this.SuspendLayout();
            // 
            // finishLine
            // 
            this.finishLine.BackColor = System.Drawing.Color.White;
            this.finishLine.Image = ((System.Drawing.Image)(resources.GetObject("finishLine.Image")));
            this.finishLine.Location = new System.Drawing.Point(819, 0);
            this.finishLine.Name = "finishLine";
            this.finishLine.Size = new System.Drawing.Size(156, 292);
            this.finishLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finishLine.TabIndex = 0;
            this.finishLine.TabStop = false;
            // 
            // Racetrack
            // 
            this.Racetrack.BackColor = System.Drawing.Color.SandyBrown;
            this.Racetrack.Controls.Add(this.dog4);
            this.Racetrack.Controls.Add(this.dog3);
            this.Racetrack.Controls.Add(this.dog2);
            this.Racetrack.Controls.Add(this.dog1);
            this.Racetrack.Controls.Add(this.finishLine);
            this.Racetrack.Controls.Add(this.panel3);
            this.Racetrack.Controls.Add(this.panel4);
            this.Racetrack.Controls.Add(this.panel2);
            this.Racetrack.Location = new System.Drawing.Point(12, 12);
            this.Racetrack.Name = "Racetrack";
            this.Racetrack.Size = new System.Drawing.Size(975, 292);
            this.Racetrack.TabIndex = 1;
            // 
            // dog4
            // 
            this.dog4.BackColor = System.Drawing.Color.Transparent;
            this.dog4.Image = ((System.Drawing.Image)(resources.GetObject("dog4.Image")));
            this.dog4.Location = new System.Drawing.Point(10, 234);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(150, 50);
            this.dog4.TabIndex = 6;
            this.dog4.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.BackColor = System.Drawing.Color.Transparent;
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(10, 157);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(150, 50);
            this.dog3.TabIndex = 5;
            this.dog3.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.BackColor = System.Drawing.Color.Transparent;
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(10, 80);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(150, 50);
            this.dog2.TabIndex = 4;
            this.dog2.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.BackColor = System.Drawing.Color.Transparent;
            this.dog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(10, 3);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(150, 50);
            this.dog1.TabIndex = 3;
            this.dog1.TabStop = false;
            this.dog1.Click += new System.EventHandler(this.dog1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(825, 15);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(825, 15);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 15);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.betsLabel);
            this.panel5.Controls.Add(this.dogToWinUD);
            this.panel5.Controls.Add(this.bucksLabel);
            this.panel5.Controls.Add(this.dollarUD);
            this.panel5.Controls.Add(this.betsButton);
            this.panel5.Controls.Add(this.nameLabel);
            this.panel5.Controls.Add(this.alRadioButton);
            this.panel5.Controls.Add(this.bobRadioButton);
            this.panel5.Controls.Add(this.joeRadioButton);
            this.panel5.Controls.Add(this.minimumBetLabel);
            this.panel5.Controls.Add(this.bettingParlorLabel);
            this.panel5.Location = new System.Drawing.Point(12, 312);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(975, 162);
            this.panel5.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(700, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 71);
            this.button1.TabIndex = 15;
            this.button1.Text = "Race!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel6.Controls.Add(this.joeBetLabel);
            this.panel6.Controls.Add(this.alBetLabel);
            this.panel6.Controls.Add(this.bobBetLabel);
            this.panel6.Location = new System.Drawing.Point(172, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(370, 71);
            this.panel6.TabIndex = 14;
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.AutoSize = true;
            this.joeBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeBetLabel.Location = new System.Drawing.Point(3, 2);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(102, 18);
            this.joeBetLabel.TabIndex = 11;
            this.joeBetLabel.Text = "Joe\'s bet label";
            // 
            // alBetLabel
            // 
            this.alBetLabel.AutoSize = true;
            this.alBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alBetLabel.Location = new System.Drawing.Point(3, 47);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(89, 18);
            this.alBetLabel.TabIndex = 13;
            this.alBetLabel.Text = "Al\'s bet label";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.AutoSize = true;
            this.bobBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobBetLabel.Location = new System.Drawing.Point(3, 24);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(104, 18);
            this.bobBetLabel.TabIndex = 12;
            this.bobBetLabel.Text = "Bob\'s bet label";
            // 
            // betsLabel
            // 
            this.betsLabel.AutoSize = true;
            this.betsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betsLabel.Location = new System.Drawing.Point(175, 29);
            this.betsLabel.Name = "betsLabel";
            this.betsLabel.Size = new System.Drawing.Size(43, 16);
            this.betsLabel.TabIndex = 10;
            this.betsLabel.Text = "Bets:";
            // 
            // dogToWinUD
            // 
            this.dogToWinUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogToWinUD.Location = new System.Drawing.Point(496, 128);
            this.dogToWinUD.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogToWinUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogToWinUD.Name = "dogToWinUD";
            this.dogToWinUD.Size = new System.Drawing.Size(46, 22);
            this.dogToWinUD.TabIndex = 9;
            this.dogToWinUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bucksLabel
            // 
            this.bucksLabel.AutoSize = true;
            this.bucksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bucksLabel.Location = new System.Drawing.Point(350, 131);
            this.bucksLabel.Name = "bucksLabel";
            this.bucksLabel.Size = new System.Drawing.Size(140, 16);
            this.bucksLabel.TabIndex = 8;
            this.bucksLabel.Text = "bucks on dog number:";
            // 
            // dollarUD
            // 
            this.dollarUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dollarUD.Location = new System.Drawing.Point(296, 127);
            this.dollarUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dollarUD.Name = "dollarUD";
            this.dollarUD.Size = new System.Drawing.Size(48, 22);
            this.dollarUD.TabIndex = 7;
            this.dollarUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betsButton
            // 
            this.betsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.betsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betsButton.Location = new System.Drawing.Point(215, 128);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(75, 23);
            this.betsButton.TabIndex = 6;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = false;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(118, 131);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 16);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Player";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alRadioButton.Location = new System.Drawing.Point(19, 95);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(87, 20);
            this.alRadioButton.TabIndex = 4;
            this.alRadioButton.Text = "Al has $50";
            this.alRadioButton.UseVisualStyleBackColor = true;
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobRadioButton.Location = new System.Drawing.Point(19, 72);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(100, 20);
            this.bobRadioButton.TabIndex = 3;
            this.bobRadioButton.Text = "Bob has $50";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeRadioButton.Location = new System.Drawing.Point(19, 49);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 20);
            this.joeRadioButton.TabIndex = 2;
            this.joeRadioButton.Text = "Joe has $50";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(19, 29);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(130, 16);
            this.minimumBetLabel.TabIndex = 1;
            this.minimumBetLabel.Text = "MinimumBetLabel";
            // 
            // bettingParlorLabel
            // 
            this.bettingParlorLabel.AutoSize = true;
            this.bettingParlorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bettingParlorLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.bettingParlorLabel.Location = new System.Drawing.Point(19, 4);
            this.bettingParlorLabel.Name = "bettingParlorLabel";
            this.bettingParlorLabel.Size = new System.Drawing.Size(102, 16);
            this.bettingParlorLabel.TabIndex = 0;
            this.bettingParlorLabel.Text = "Betting Parlor";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 486);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Racetrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RacesForm";
            this.Text = "A Day at the Races";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RacesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finishLine)).EndInit();
            this.Racetrack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogToWinUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox finishLine;
        private System.Windows.Forms.Panel Racetrack;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label bettingParlorLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label betsLabel;
        private System.Windows.Forms.NumericUpDown dogToWinUD;
        private System.Windows.Forms.Label bucksLabel;
        private System.Windows.Forms.NumericUpDown dollarUD;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Timer timer1;
    }
}


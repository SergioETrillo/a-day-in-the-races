namespace aDayattheRaces_p188
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dogNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.poundLabel = new System.Windows.Forms.Label();
            this.poundsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RaceButton = new System.Windows.Forms.Button();
            this.AlBetLabel = new System.Windows.Forms.Label();
            this.BobBetLabel = new System.Windows.Forms.Label();
            this.JoeBetLabel = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.AlRadioButton = new System.Windows.Forms.RadioButton();
            this.BobRadioButton = new System.Windows.Forms.RadioButton();
            this.JoeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.RaceTrackPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poundsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceTrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dogNumericUpDown);
            this.groupBox1.Controls.Add(this.poundLabel);
            this.groupBox1.Controls.Add(this.poundsNumericUpDown);
            this.groupBox1.Controls.Add(this.RaceButton);
            this.groupBox1.Controls.Add(this.AlBetLabel);
            this.groupBox1.Controls.Add(this.BobBetLabel);
            this.groupBox1.Controls.Add(this.JoeBetLabel);
            this.groupBox1.Controls.Add(this.betLabel);
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.AlRadioButton);
            this.groupBox1.Controls.Add(this.BobRadioButton);
            this.groupBox1.Controls.Add(this.JoeRadioButton);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlour";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dogNumericUpDown
            // 
            this.dogNumericUpDown.Location = new System.Drawing.Point(295, 114);
            this.dogNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumericUpDown.Name = "dogNumericUpDown";
            this.dogNumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.dogNumericUpDown.TabIndex = 13;
            this.dogNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // poundLabel
            // 
            this.poundLabel.AutoSize = true;
            this.poundLabel.Location = new System.Drawing.Point(172, 114);
            this.poundLabel.Name = "poundLabel";
            this.poundLabel.Size = new System.Drawing.Size(116, 13);
            this.poundLabel.TabIndex = 12;
            this.poundLabel.Text = "pounds on dog number";
            // 
            // poundsNumericUpDown
            // 
            this.poundsNumericUpDown.Location = new System.Drawing.Point(119, 113);
            this.poundsNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.poundsNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.poundsNumericUpDown.Name = "poundsNumericUpDown";
            this.poundsNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.poundsNumericUpDown.TabIndex = 11;
            this.poundsNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // RaceButton
            // 
            this.RaceButton.Location = new System.Drawing.Point(578, 65);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(75, 65);
            this.RaceButton.TabIndex = 10;
            this.RaceButton.Text = "Race!";
            this.RaceButton.UseVisualStyleBackColor = true;
            this.RaceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // AlBetLabel
            // 
            this.AlBetLabel.AutoSize = true;
            this.AlBetLabel.Location = new System.Drawing.Point(244, 87);
            this.AlBetLabel.Name = "AlBetLabel";
            this.AlBetLabel.Size = new System.Drawing.Size(121, 13);
            this.AlBetLabel.TabIndex = 9;
            this.AlBetLabel.Text = "Al hasn´t placed any bet";
            // 
            // BobBetLabel
            // 
            this.BobBetLabel.AutoSize = true;
            this.BobBetLabel.Location = new System.Drawing.Point(244, 65);
            this.BobBetLabel.Name = "BobBetLabel";
            this.BobBetLabel.Size = new System.Drawing.Size(131, 13);
            this.BobBetLabel.TabIndex = 8;
            this.BobBetLabel.Text = "Bob hasn´t placed any bet";
            // 
            // JoeBetLabel
            // 
            this.JoeBetLabel.AutoSize = true;
            this.JoeBetLabel.Location = new System.Drawing.Point(244, 41);
            this.JoeBetLabel.Name = "JoeBetLabel";
            this.JoeBetLabel.Size = new System.Drawing.Size(129, 13);
            this.JoeBetLabel.TabIndex = 7;
            this.JoeBetLabel.Text = "Joe hasn´t placed any bet";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLabel.Location = new System.Drawing.Point(241, 20);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(32, 13);
            this.betLabel.TabIndex = 6;
            this.betLabel.Text = "Bets";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(50, 111);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(46, 23);
            this.betButton.TabIndex = 5;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 114);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(24, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Joe";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // AlRadioButton
            // 
            this.AlRadioButton.AutoSize = true;
            this.AlRadioButton.Location = new System.Drawing.Point(11, 85);
            this.AlRadioButton.Name = "AlRadioButton";
            this.AlRadioButton.Size = new System.Drawing.Size(107, 17);
            this.AlRadioButton.TabIndex = 3;
            this.AlRadioButton.Text = "Al has 45 pounds";
            this.AlRadioButton.UseVisualStyleBackColor = true;
            this.AlRadioButton.CheckedChanged += new System.EventHandler(this.AlRadioButton_CheckedChanged);
            // 
            // BobRadioButton
            // 
            this.BobRadioButton.AutoSize = true;
            this.BobRadioButton.Location = new System.Drawing.Point(11, 61);
            this.BobRadioButton.Name = "BobRadioButton";
            this.BobRadioButton.Size = new System.Drawing.Size(117, 17);
            this.BobRadioButton.TabIndex = 2;
            this.BobRadioButton.Text = "Bob has 75 pounds";
            this.BobRadioButton.UseVisualStyleBackColor = true;
            this.BobRadioButton.CheckedChanged += new System.EventHandler(this.BobRadioButton_CheckedChanged);
            // 
            // JoeRadioButton
            // 
            this.JoeRadioButton.AutoSize = true;
            this.JoeRadioButton.Checked = true;
            this.JoeRadioButton.Location = new System.Drawing.Point(11, 37);
            this.JoeRadioButton.Name = "JoeRadioButton";
            this.JoeRadioButton.Size = new System.Drawing.Size(115, 17);
            this.JoeRadioButton.TabIndex = 1;
            this.JoeRadioButton.TabStop = true;
            this.JoeRadioButton.Text = "Joe has 50 pounds";
            this.JoeRadioButton.UseVisualStyleBackColor = true;
            this.JoeRadioButton.CheckedChanged += new System.EventHandler(this.JoeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(11, 20);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(99, 13);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimum Bet: £5";
            // 
            // RaceTrackPictureBox
            // 
            this.RaceTrackPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RaceTrackPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RaceTrackPictureBox.BackgroundImage")));
            this.RaceTrackPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RaceTrackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.RaceTrackPictureBox.Name = "RaceTrackPictureBox";
            this.RaceTrackPictureBox.Size = new System.Drawing.Size(674, 244);
            this.RaceTrackPictureBox.TabIndex = 1;
            this.RaceTrackPictureBox.TabStop = false;
            // 
            // pictureBoxDog1
            // 
            this.pictureBoxDog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDog1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog1.Image")));
            this.pictureBoxDog1.Location = new System.Drawing.Point(27, 22);
            this.pictureBoxDog1.Name = "pictureBoxDog1";
            this.pictureBoxDog1.Size = new System.Drawing.Size(75, 20);
            this.pictureBoxDog1.TabIndex = 2;
            this.pictureBoxDog1.TabStop = false;
            // 
            // pictureBoxDog2
            // 
            this.pictureBoxDog2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDog2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog2.Image")));
            this.pictureBoxDog2.Location = new System.Drawing.Point(27, 82);
            this.pictureBoxDog2.Name = "pictureBoxDog2";
            this.pictureBoxDog2.Size = new System.Drawing.Size(75, 20);
            this.pictureBoxDog2.TabIndex = 3;
            this.pictureBoxDog2.TabStop = false;
            // 
            // pictureBoxDog3
            // 
            this.pictureBoxDog3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDog3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog3.Image")));
            this.pictureBoxDog3.Location = new System.Drawing.Point(27, 148);
            this.pictureBoxDog3.Name = "pictureBoxDog3";
            this.pictureBoxDog3.Size = new System.Drawing.Size(75, 20);
            this.pictureBoxDog3.TabIndex = 4;
            this.pictureBoxDog3.TabStop = false;
            // 
            // pictureBoxDog4
            // 
            this.pictureBoxDog4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDog4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog4.Image")));
            this.pictureBoxDog4.Location = new System.Drawing.Point(27, 213);
            this.pictureBoxDog4.Name = "pictureBoxDog4";
            this.pictureBoxDog4.Size = new System.Drawing.Size(75, 20);
            this.pictureBoxDog4.TabIndex = 5;
            this.pictureBoxDog4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 427);
            this.Controls.Add(this.pictureBoxDog4);
            this.Controls.Add(this.pictureBoxDog3);
            this.Controls.Add(this.pictureBoxDog2);
            this.Controls.Add(this.pictureBoxDog1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RaceTrackPictureBox);
            this.Name = "Form1";
            this.Text = "A day in the Races";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poundsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceTrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown dogNumericUpDown;
        private System.Windows.Forms.Label poundLabel;
        private System.Windows.Forms.NumericUpDown poundsNumericUpDown;
        private System.Windows.Forms.Button RaceButton;
        private System.Windows.Forms.Label AlBetLabel;
        private System.Windows.Forms.Label BobBetLabel;
        private System.Windows.Forms.Label JoeBetLabel;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton AlRadioButton;
        private System.Windows.Forms.RadioButton BobRadioButton;
        private System.Windows.Forms.RadioButton JoeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.PictureBox RaceTrackPictureBox;
        private System.Windows.Forms.PictureBox pictureBoxDog1;
        private System.Windows.Forms.PictureBox pictureBoxDog2;
        private System.Windows.Forms.PictureBox pictureBoxDog3;
        private System.Windows.Forms.PictureBox pictureBoxDog4;
        private System.Windows.Forms.Timer timer1;
    }
}


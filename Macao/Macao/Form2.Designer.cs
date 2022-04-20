namespace Macao
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxTable = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPlay7_Spades = new System.Windows.Forms.Button();
            this.labelCartiPlayer = new System.Windows.Forms.Label();
            this.buttonPlay7_Clubs = new System.Windows.Forms.Button();
            this.labelCartiAi = new System.Windows.Forms.Label();
            this.buttonPlay7_Diamonds = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPlay7_Hearts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDraw = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelWait = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonMacao = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPageTotal = new System.Windows.Forms.Label();
            this.labelPageCurrent = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerAiRound = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(713, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Return to menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxTable
            // 
            this.pictureBoxTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxTable.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTable.Image")));
            this.pictureBoxTable.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTable.Name = "pictureBoxTable";
            this.pictureBoxTable.Size = new System.Drawing.Size(101, 160);
            this.pictureBoxTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTable.TabIndex = 1;
            this.pictureBoxTable.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.buttonPlay7_Spades);
            this.panel1.Controls.Add(this.labelCartiPlayer);
            this.panel1.Controls.Add(this.buttonPlay7_Clubs);
            this.panel1.Controls.Add(this.labelCartiAi);
            this.panel1.Controls.Add(this.buttonPlay7_Diamonds);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonPlay7_Hearts);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelColor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelNr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxTable);
            this.panel1.Location = new System.Drawing.Point(245, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 160);
            this.panel1.TabIndex = 2;
            // 
            // buttonPlay7_Spades
            // 
            this.buttonPlay7_Spades.Location = new System.Drawing.Point(258, 115);
            this.buttonPlay7_Spades.Name = "buttonPlay7_Spades";
            this.buttonPlay7_Spades.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay7_Spades.TabIndex = 7;
            this.buttonPlay7_Spades.Text = "Spades";
            this.buttonPlay7_Spades.UseVisualStyleBackColor = true;
            this.buttonPlay7_Spades.Visible = false;
            this.buttonPlay7_Spades.Click += new System.EventHandler(this.buttonPlay7_Spades_Click);
            // 
            // labelCartiPlayer
            // 
            this.labelCartiPlayer.AutoSize = true;
            this.labelCartiPlayer.Location = new System.Drawing.Point(192, 88);
            this.labelCartiPlayer.Name = "labelCartiPlayer";
            this.labelCartiPlayer.Size = new System.Drawing.Size(13, 13);
            this.labelCartiPlayer.TabIndex = 9;
            this.labelCartiPlayer.Text = "0";
            // 
            // buttonPlay7_Clubs
            // 
            this.buttonPlay7_Clubs.Location = new System.Drawing.Point(258, 83);
            this.buttonPlay7_Clubs.Name = "buttonPlay7_Clubs";
            this.buttonPlay7_Clubs.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay7_Clubs.TabIndex = 6;
            this.buttonPlay7_Clubs.Text = "Clubs";
            this.buttonPlay7_Clubs.UseVisualStyleBackColor = true;
            this.buttonPlay7_Clubs.Visible = false;
            this.buttonPlay7_Clubs.Click += new System.EventHandler(this.buttonPlay7_Clubs_Click);
            // 
            // labelCartiAi
            // 
            this.labelCartiAi.AutoSize = true;
            this.labelCartiAi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartiAi.Location = new System.Drawing.Point(191, 112);
            this.labelCartiAi.Name = "labelCartiAi";
            this.labelCartiAi.Size = new System.Drawing.Size(20, 24);
            this.labelCartiAi.TabIndex = 8;
            this.labelCartiAi.Text = "0";
            // 
            // buttonPlay7_Diamonds
            // 
            this.buttonPlay7_Diamonds.Location = new System.Drawing.Point(258, 52);
            this.buttonPlay7_Diamonds.Name = "buttonPlay7_Diamonds";
            this.buttonPlay7_Diamonds.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay7_Diamonds.TabIndex = 5;
            this.buttonPlay7_Diamonds.Text = "Diamonds";
            this.buttonPlay7_Diamonds.UseVisualStyleBackColor = true;
            this.buttonPlay7_Diamonds.Visible = false;
            this.buttonPlay7_Diamonds.Click += new System.EventHandler(this.buttonPlay7_Diamonds_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carti Player:";
            // 
            // buttonPlay7_Hearts
            // 
            this.buttonPlay7_Hearts.Location = new System.Drawing.Point(258, 23);
            this.buttonPlay7_Hearts.Name = "buttonPlay7_Hearts";
            this.buttonPlay7_Hearts.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay7_Hearts.TabIndex = 4;
            this.buttonPlay7_Hearts.Text = "Hearts";
            this.buttonPlay7_Hearts.UseVisualStyleBackColor = true;
            this.buttonPlay7_Hearts.Visible = false;
            this.buttonPlay7_Hearts.Click += new System.EventHandler(this.buttonPlay7_Hearts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Carti Ai:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(192, 17);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(25, 13);
            this.labelColor.TabIndex = 5;
            this.labelColor.Text = "Any";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numar:";
            // 
            // labelNr
            // 
            this.labelNr.AutoSize = true;
            this.labelNr.Location = new System.Drawing.Point(192, 47);
            this.labelNr.Name = "labelNr";
            this.labelNr.Size = new System.Drawing.Size(25, 13);
            this.labelNr.TabIndex = 3;
            this.labelNr.Text = "Any";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Culoare:";
            // 
            // labelDraw
            // 
            this.labelDraw.AutoSize = true;
            this.labelDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDraw.Location = new System.Drawing.Point(741, 57);
            this.labelDraw.Name = "labelDraw";
            this.labelDraw.Size = new System.Drawing.Size(35, 37);
            this.labelDraw.TabIndex = 11;
            this.labelDraw.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(638, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 37);
            this.label7.TabIndex = 10;
            this.label7.Text = "Draw:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.labelWait);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelDraw);
            this.panel2.Controls.Add(this.buttonMacao);
            this.panel2.Controls.Add(this.buttonDraw);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelPageTotal);
            this.panel2.Controls.Add(this.labelPageCurrent);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 211);
            this.panel2.TabIndex = 3;
            // 
            // labelWait
            // 
            this.labelWait.AutoSize = true;
            this.labelWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWait.Location = new System.Drawing.Point(741, 16);
            this.labelWait.Name = "labelWait";
            this.labelWait.Size = new System.Drawing.Size(35, 37);
            this.labelWait.TabIndex = 17;
            this.labelWait.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(638, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "Wait:";
            // 
            // buttonMacao
            // 
            this.buttonMacao.BackColor = System.Drawing.Color.Transparent;
            this.buttonMacao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonMacao.Location = new System.Drawing.Point(645, 126);
            this.buttonMacao.Name = "buttonMacao";
            this.buttonMacao.Size = new System.Drawing.Size(62, 38);
            this.buttonMacao.TabIndex = 15;
            this.buttonMacao.Text = "Macao!";
            this.buttonMacao.UseVisualStyleBackColor = false;
            this.buttonMacao.Click += new System.EventHandler(this.buttonMacao_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(645, 170);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(62, 38);
            this.buttonDraw.TabIndex = 14;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "/";
            // 
            // labelPageTotal
            // 
            this.labelPageTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPageTotal.AutoSize = true;
            this.labelPageTotal.Location = new System.Drawing.Point(763, 94);
            this.labelPageTotal.Name = "labelPageTotal";
            this.labelPageTotal.Size = new System.Drawing.Size(13, 13);
            this.labelPageTotal.TabIndex = 12;
            this.labelPageTotal.Text = "1";
            // 
            // labelPageCurrent
            // 
            this.labelPageCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPageCurrent.AutoSize = true;
            this.labelPageCurrent.Location = new System.Drawing.Point(726, 94);
            this.labelPageCurrent.Name = "labelPageCurrent";
            this.labelPageCurrent.Size = new System.Drawing.Size(13, 13);
            this.labelPageCurrent.TabIndex = 11;
            this.labelPageCurrent.Text = "1";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(754, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(713, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(538, 56);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(101, 160);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(431, 56);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(101, 160);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(324, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(101, 160);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(217, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 160);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(110, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerAiRound
            // 
            this.timerAiRound.Interval = 1250;
            this.timerAiRound.Tick += new System.EventHandler(this.timerAiRound_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 37);
            this.label8.TabIndex = 17;
            this.label8.Text = "AI turn!";
            this.label8.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Macao - Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNr;
        private System.Windows.Forms.Label labelCartiPlayer;
        private System.Windows.Forms.Label labelCartiAi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPageTotal;
        private System.Windows.Forms.Label labelPageCurrent;
        private System.Windows.Forms.Button buttonPlay7_Hearts;
        private System.Windows.Forms.Button buttonPlay7_Diamonds;
        private System.Windows.Forms.Button buttonPlay7_Clubs;
        private System.Windows.Forms.Button buttonPlay7_Spades;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonMacao;
        private System.Windows.Forms.Label labelDraw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerAiRound;
        private System.Windows.Forms.Label labelWait;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}
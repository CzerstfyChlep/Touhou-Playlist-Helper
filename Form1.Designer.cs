namespace TouhouPlaylistHelper
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
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.TitleOutBox = new System.Windows.Forms.TextBox();
            this.AuthorOutBox = new System.Windows.Forms.TextBox();
            this.CharacterOutBox1 = new System.Windows.Forms.TextBox();
            this.GameOutBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IdOutBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.VocalOutBox = new System.Windows.Forms.TextBox();
            this.CharacterOutBox2 = new System.Windows.Forms.TextBox();
            this.CharacterOutBox4 = new System.Windows.Forms.TextBox();
            this.CharacterOutBox3 = new System.Windows.Forms.TextBox();
            this.CharacterOutBox6 = new System.Windows.Forms.TextBox();
            this.CharacterOutBox5 = new System.Windows.Forms.TextBox();
            this.LoadNew = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(12, 12);
            this.TitleBox.Multiline = true;
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.ReadOnly = true;
            this.TitleBox.Size = new System.Drawing.Size(421, 46);
            this.TitleBox.TabIndex = 0;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(12, 64);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ReadOnly = true;
            this.DescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionBox.Size = new System.Drawing.Size(421, 461);
            this.DescriptionBox.TabIndex = 1;
            // 
            // TitleOutBox
            // 
            this.TitleOutBox.Location = new System.Drawing.Point(456, 24);
            this.TitleOutBox.Name = "TitleOutBox";
            this.TitleOutBox.Size = new System.Drawing.Size(269, 20);
            this.TitleOutBox.TabIndex = 2;
            // 
            // AuthorOutBox
            // 
            this.AuthorOutBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AuthorOutBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AuthorOutBox.Location = new System.Drawing.Point(456, 63);
            this.AuthorOutBox.Name = "AuthorOutBox";
            this.AuthorOutBox.Size = new System.Drawing.Size(223, 20);
            this.AuthorOutBox.TabIndex = 3;
            // 
            // CharacterOutBox1
            // 
            this.CharacterOutBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CharacterOutBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CharacterOutBox1.Location = new System.Drawing.Point(456, 102);
            this.CharacterOutBox1.Name = "CharacterOutBox1";
            this.CharacterOutBox1.Size = new System.Drawing.Size(132, 20);
            this.CharacterOutBox1.TabIndex = 4;
            this.CharacterOutBox1.TextChanged += new System.EventHandler(this.CharacterOutBox_TextChanged);
            // 
            // GameOutBox
            // 
            this.GameOutBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GameOutBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.GameOutBox.Location = new System.Drawing.Point(456, 193);
            this.GameOutBox.Name = "GameOutBox";
            this.GameOutBox.Size = new System.Drawing.Size(223, 20);
            this.GameOutBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Next\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IdOutBox
            // 
            this.IdOutBox.Location = new System.Drawing.Point(456, 232);
            this.IdOutBox.Name = "IdOutBox";
            this.IdOutBox.Size = new System.Drawing.Size(269, 20);
            this.IdOutBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Character";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Game";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pos:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(685, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 21);
            this.button2.TabIndex = 14;
            this.button2.Text = "R";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(685, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 21);
            this.button3.TabIndex = 15;
            this.button3.Text = "Last";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(292, 559);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 21);
            this.button4.TabIndex = 18;
            this.button4.Text = "Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vocal";
            // 
            // VocalOutBox
            // 
            this.VocalOutBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.VocalOutBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.VocalOutBox.Location = new System.Drawing.Point(63, 560);
            this.VocalOutBox.Name = "VocalOutBox";
            this.VocalOutBox.Size = new System.Drawing.Size(223, 20);
            this.VocalOutBox.TabIndex = 16;
            // 
            // CharacterOutBox2
            // 
            this.CharacterOutBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CharacterOutBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CharacterOutBox2.Location = new System.Drawing.Point(593, 102);
            this.CharacterOutBox2.Name = "CharacterOutBox2";
            this.CharacterOutBox2.Size = new System.Drawing.Size(132, 20);
            this.CharacterOutBox2.TabIndex = 19;
            // 
            // CharacterOutBox4
            // 
            this.CharacterOutBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CharacterOutBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CharacterOutBox4.Location = new System.Drawing.Point(593, 128);
            this.CharacterOutBox4.Name = "CharacterOutBox4";
            this.CharacterOutBox4.Size = new System.Drawing.Size(132, 20);
            this.CharacterOutBox4.TabIndex = 21;
            // 
            // CharacterOutBox3
            // 
            this.CharacterOutBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CharacterOutBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CharacterOutBox3.Location = new System.Drawing.Point(456, 128);
            this.CharacterOutBox3.Name = "CharacterOutBox3";
            this.CharacterOutBox3.Size = new System.Drawing.Size(132, 20);
            this.CharacterOutBox3.TabIndex = 20;
            // 
            // CharacterOutBox6
            // 
            this.CharacterOutBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CharacterOutBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CharacterOutBox6.Location = new System.Drawing.Point(593, 154);
            this.CharacterOutBox6.Name = "CharacterOutBox6";
            this.CharacterOutBox6.Size = new System.Drawing.Size(132, 20);
            this.CharacterOutBox6.TabIndex = 23;
            // 
            // CharacterOutBox5
            // 
            this.CharacterOutBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CharacterOutBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CharacterOutBox5.Location = new System.Drawing.Point(456, 154);
            this.CharacterOutBox5.Name = "CharacterOutBox5";
            this.CharacterOutBox5.Size = new System.Drawing.Size(132, 20);
            this.CharacterOutBox5.TabIndex = 22;
            // 
            // LoadNew
            // 
            this.LoadNew.AutoSize = true;
            this.LoadNew.Checked = true;
            this.LoadNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LoadNew.Location = new System.Drawing.Point(456, 313);
            this.LoadNew.Name = "LoadNew";
            this.LoadNew.Size = new System.Drawing.Size(72, 17);
            this.LoadNew.TabIndex = 24;
            this.LoadNew.Text = "LoadNew";
            this.LoadNew.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 531);
            this.Controls.Add(this.LoadNew);
            this.Controls.Add(this.CharacterOutBox6);
            this.Controls.Add(this.CharacterOutBox5);
            this.Controls.Add(this.CharacterOutBox4);
            this.Controls.Add(this.CharacterOutBox3);
            this.Controls.Add(this.CharacterOutBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VocalOutBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdOutBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GameOutBox);
            this.Controls.Add(this.CharacterOutBox1);
            this.Controls.Add(this.AuthorOutBox);
            this.Controls.Add(this.TitleOutBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.TitleBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TextBox TitleOutBox;
        private System.Windows.Forms.TextBox AuthorOutBox;
        private System.Windows.Forms.TextBox CharacterOutBox1;
        private System.Windows.Forms.TextBox GameOutBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IdOutBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VocalOutBox;
        private System.Windows.Forms.TextBox CharacterOutBox2;
        private System.Windows.Forms.TextBox CharacterOutBox4;
        private System.Windows.Forms.TextBox CharacterOutBox3;
        private System.Windows.Forms.TextBox CharacterOutBox6;
        private System.Windows.Forms.TextBox CharacterOutBox5;
        private System.Windows.Forms.CheckBox LoadNew;
    }
}


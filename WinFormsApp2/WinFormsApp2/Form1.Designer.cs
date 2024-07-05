namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnstart = new Button();
            lab_p1 = new Label();
            lab_p2 = new Label();
            txt_p1 = new TextBox();
            txt_p2 = new TextBox();
            groupBox1 = new GroupBox();
            rad_p1_o = new RadioButton();
            rad_p1_x = new RadioButton();
            groupBox2 = new GroupBox();
            rad_p2_o = new RadioButton();
            rad_p2_x = new RadioButton();
            btn_score = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnstart
            // 
            btnstart.BackColor = SystemColors.ButtonHighlight;
            btnstart.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstart.Location = new Point(310, 339);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(186, 66);
            btnstart.TabIndex = 0;
            btnstart.Text = "start";
            btnstart.UseVisualStyleBackColor = false;
            btnstart.Click += strat_play;
            // 
            // lab_p1
            // 
            lab_p1.AutoSize = true;
            lab_p1.Font = new Font("Cooper Black", 16.2F);
            lab_p1.Location = new Point(0, 40);
            lab_p1.Name = "lab_p1";
            lab_p1.Size = new Size(176, 32);
            lab_p1.TabIndex = 1;
            lab_p1.Text = "Player_One";
            // 
            // lab_p2
            // 
            lab_p2.AutoSize = true;
            lab_p2.Font = new Font("Cooper Black", 16.2F);
            lab_p2.Location = new Point(0, 42);
            lab_p2.Name = "lab_p2";
            lab_p2.Size = new Size(185, 32);
            lab_p2.TabIndex = 2;
            lab_p2.Text = "Player_Two";
            // 
            // txt_p1
            // 
            txt_p1.Font = new Font("Cooper Black", 16.2F);
            txt_p1.Location = new Point(182, 37);
            txt_p1.Name = "txt_p1";
            txt_p1.Size = new Size(125, 38);
            txt_p1.TabIndex = 3;
            // 
            // txt_p2
            // 
            txt_p2.Font = new Font("Cooper Black", 16.2F);
            txt_p2.Location = new Point(190, 39);
            txt_p2.Name = "txt_p2";
            txt_p2.Size = new Size(125, 38);
            txt_p2.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad_p1_o);
            groupBox1.Controls.Add(rad_p1_x);
            groupBox1.Controls.Add(lab_p1);
            groupBox1.Controls.Add(txt_p1);
            groupBox1.Location = new Point(25, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 127);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // rad_p1_o
            // 
            rad_p1_o.AutoSize = true;
            rad_p1_o.Font = new Font("Cooper Black", 13.8F);
            rad_p1_o.Location = new Point(182, 97);
            rad_p1_o.Name = "rad_p1_o";
            rad_p1_o.Size = new Size(51, 30);
            rad_p1_o.TabIndex = 5;
            rad_p1_o.TabStop = true;
            rad_p1_o.Text = "O";
            rad_p1_o.UseVisualStyleBackColor = true;
            rad_p1_o.CheckedChanged += rad_p1_o_CheckedChanged;
            // 
            // rad_p1_x
            // 
            rad_p1_x.AutoSize = true;
            rad_p1_x.Font = new Font("Cooper Black", 13.8F);
            rad_p1_x.Location = new Point(39, 97);
            rad_p1_x.Name = "rad_p1_x";
            rad_p1_x.Size = new Size(51, 30);
            rad_p1_x.TabIndex = 4;
            rad_p1_x.TabStop = true;
            rad_p1_x.Text = "X";
            rad_p1_x.UseVisualStyleBackColor = true;
            rad_p1_x.CheckedChanged += rad_p1_x_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rad_p2_o);
            groupBox2.Controls.Add(rad_p2_x);
            groupBox2.Controls.Add(lab_p2);
            groupBox2.Controls.Add(txt_p2);
            groupBox2.Location = new Point(467, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 127);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // rad_p2_o
            // 
            rad_p2_o.AutoSize = true;
            rad_p2_o.Font = new Font("Cooper Black", 13.8F);
            rad_p2_o.Location = new Point(172, 97);
            rad_p2_o.Name = "rad_p2_o";
            rad_p2_o.Size = new Size(51, 30);
            rad_p2_o.TabIndex = 6;
            rad_p2_o.TabStop = true;
            rad_p2_o.Text = "O";
            rad_p2_o.UseVisualStyleBackColor = true;
            rad_p2_o.CheckedChanged += rad_p2_o_CheckedChanged;
            // 
            // rad_p2_x
            // 
            rad_p2_x.AutoSize = true;
            rad_p2_x.Font = new Font("Cooper Black", 13.8F);
            rad_p2_x.Location = new Point(37, 97);
            rad_p2_x.Name = "rad_p2_x";
            rad_p2_x.Size = new Size(51, 30);
            rad_p2_x.TabIndex = 5;
            rad_p2_x.TabStop = true;
            rad_p2_x.Text = "X";
            rad_p2_x.UseVisualStyleBackColor = true;
            rad_p2_x.CheckedChanged += rad_p2_x_CheckedChanged;
            // 
            // btn_score
            // 
            btn_score.BackColor = SystemColors.ButtonHighlight;
            btn_score.Font = new Font("Copperplate Gothic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_score.Location = new Point(675, 383);
            btn_score.Name = "btn_score";
            btn_score.Size = new Size(88, 55);
            btn_score.TabIndex = 7;
            btn_score.Text = "scores";
            btn_score.UseVisualStyleBackColor = false;
            btn_score.Click += btn_score_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_score);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnstart);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnstart;
        private Label lab_p1;
        private Label lab_p2;
        private TextBox txt_p1;
        private TextBox txt_p2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rad_p1_o;
        private RadioButton rad_p1_x;
        private RadioButton rad_p2_o;
        private RadioButton rad_p2_x;
        private Button btn_score;
    }
}

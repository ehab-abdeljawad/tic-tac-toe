namespace WinFormsApp2
{
    partial class scores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scores));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            pla1 = new Label();
            pal2 = new Label();
            lab_sco1 = new Label();
            lab_sco2 = new Label();
            text_p1 = new TextBox();
            text_p2 = new TextBox();
            text_s1 = new TextBox();
            text_s2 = new TextBox();
            btn_edit = new Button();
            btn_backto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(105, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(613, 199);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            button1.Location = new Point(211, 390);
            button1.Name = "button1";
            button1.Size = new Size(71, 48);
            button1.TabIndex = 1;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pla1
            // 
            pla1.AutoSize = true;
            pla1.BackColor = SystemColors.ControlLightLight;
            pla1.Font = new Font("Cooper Black", 12F);
            pla1.Location = new Point(160, 17);
            pla1.Name = "pla1";
            pla1.Size = new Size(87, 23);
            pla1.TabIndex = 2;
            pla1.Text = "player1";
            // 
            // pal2
            // 
            pal2.AutoSize = true;
            pal2.BackColor = SystemColors.ControlLightLight;
            pal2.Font = new Font("Cooper Black", 12F);
            pal2.Location = new Point(160, 79);
            pal2.Name = "pal2";
            pal2.Size = new Size(87, 23);
            pal2.TabIndex = 3;
            pal2.Text = "player2";
            // 
            // lab_sco1
            // 
            lab_sco1.AutoSize = true;
            lab_sco1.BackColor = SystemColors.ControlLightLight;
            lab_sco1.Font = new Font("Cooper Black", 12F);
            lab_sco1.Location = new Point(433, 21);
            lab_sco1.Name = "lab_sco1";
            lab_sco1.Size = new Size(77, 23);
            lab_sco1.TabIndex = 4;
            lab_sco1.Text = "score1";
            // 
            // lab_sco2
            // 
            lab_sco2.AutoSize = true;
            lab_sco2.BackColor = SystemColors.ControlLightLight;
            lab_sco2.Font = new Font("Cooper Black", 12F);
            lab_sco2.Location = new Point(433, 83);
            lab_sco2.Name = "lab_sco2";
            lab_sco2.Size = new Size(77, 23);
            lab_sco2.TabIndex = 5;
            lab_sco2.Text = "score2";
            // 
            // text_p1
            // 
            text_p1.Font = new Font("Arial Rounded MT Bold", 12F);
            text_p1.Location = new Point(272, 12);
            text_p1.Name = "text_p1";
            text_p1.Size = new Size(125, 31);
            text_p1.TabIndex = 6;
            // 
            // text_p2
            // 
            text_p2.Font = new Font("Arial Rounded MT Bold", 12F);
            text_p2.Location = new Point(272, 79);
            text_p2.Name = "text_p2";
            text_p2.Size = new Size(125, 31);
            text_p2.TabIndex = 7;
            // 
            // text_s1
            // 
            text_s1.Font = new Font("Arial Rounded MT Bold", 12F);
            text_s1.Location = new Point(523, 17);
            text_s1.Name = "text_s1";
            text_s1.Size = new Size(125, 31);
            text_s1.TabIndex = 8;
            // 
            // text_s2
            // 
            text_s2.Font = new Font("Arial Rounded MT Bold", 12F);
            text_s2.Location = new Point(523, 79);
            text_s2.Name = "text_s2";
            text_s2.Size = new Size(125, 31);
            text_s2.TabIndex = 9;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = SystemColors.ControlLightLight;
            btn_edit.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btn_edit.Location = new Point(502, 390);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(71, 48);
            btn_edit.TabIndex = 10;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_backto
            // 
            btn_backto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_backto.Location = new Point(12, 390);
            btn_backto.Name = "btn_backto";
            btn_backto.Size = new Size(59, 40);
            btn_backto.TabIndex = 11;
            btn_backto.Text = "Back";
            btn_backto.UseVisualStyleBackColor = true;
            btn_backto.Click += btn_backto_Click;
            // 
            // scores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_backto);
            Controls.Add(btn_edit);
            Controls.Add(text_s2);
            Controls.Add(text_s1);
            Controls.Add(text_p2);
            Controls.Add(text_p1);
            Controls.Add(lab_sco2);
            Controls.Add(lab_sco1);
            Controls.Add(pal2);
            Controls.Add(pla1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "scores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "scores";
            Load += scores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label pla1;
        private Label pal2;
        private Label lab_sco1;
        private Label lab_sco2;
        private TextBox text_p1;
        private TextBox text_p2;
        private TextBox text_s1;
        private TextBox text_s2;
        private Button btn_edit;
        private Button btn_backto;
    }
}
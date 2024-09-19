namespace AI_8Puzzle
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.btn_batdau = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_giaitoiuu = new System.Windows.Forms.Button();
            this.btn_bfs = new System.Windows.Forms.Button();
            this.btn_choilai = new System.Windows.Forms.Button();
            this.btn_tamdung = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox_22 = new System.Windows.Forms.PictureBox();
            this.pictureBox_12 = new System.Windows.Forms.PictureBox();
            this.pictureBox_21 = new System.Windows.Forms.PictureBox();
            this.pictureBox_11 = new System.Windows.Forms.PictureBox();
            this.pictureBox_02 = new System.Windows.Forms.PictureBox();
            this.pictureBox_20 = new System.Windows.Forms.PictureBox();
            this.pictureBox_10 = new System.Windows.Forms.PictureBox();
            this.pictureBox_01 = new System.Windows.Forms.PictureBox();
            this.pictureBox_00 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.img_goc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCountMove = new System.Windows.Forms.Label();
            this.lbtime = new System.Windows.Forms.Label();
            this.lbNumberStep = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_00)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_goc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_batdau
            // 
            this.btn_batdau.BackColor = System.Drawing.Color.LightCoral;
            this.btn_batdau.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_batdau.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_batdau.Location = new System.Drawing.Point(3, 124);
            this.btn_batdau.Name = "btn_batdau";
            this.btn_batdau.Size = new System.Drawing.Size(550, 52);
            this.btn_batdau.TabIndex = 0;
            this.btn_batdau.Text = "Bắt đầu";
            this.btn_batdau.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_giaitoiuu);
            this.groupBox1.Controls.Add(this.btn_bfs);
            this.groupBox1.Controls.Add(this.btn_choilai);
            this.groupBox1.Controls.Add(this.btn_tamdung);
            this.groupBox1.Controls.Add(this.btn_batdau);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_giaitoiuu
            // 
            this.btn_giaitoiuu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_giaitoiuu.Location = new System.Drawing.Point(297, 75);
            this.btn_giaitoiuu.Name = "btn_giaitoiuu";
            this.btn_giaitoiuu.Size = new System.Drawing.Size(208, 42);
            this.btn_giaitoiuu.TabIndex = 4;
            this.btn_giaitoiuu.Text = "Giải tối ưu";
            this.btn_giaitoiuu.UseVisualStyleBackColor = true;
            this.btn_giaitoiuu.Click += new System.EventHandler(this.btn_giaitoiuu_Click);
            // 
            // btn_bfs
            // 
            this.btn_bfs.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_bfs.Location = new System.Drawing.Point(47, 75);
            this.btn_bfs.Name = "btn_bfs";
            this.btn_bfs.Size = new System.Drawing.Size(208, 42);
            this.btn_bfs.TabIndex = 3;
            this.btn_bfs.Text = "Giải BFS";
            this.btn_bfs.UseVisualStyleBackColor = true;
            this.btn_bfs.Click += new System.EventHandler(this.btn_bfs_Click);
            // 
            // btn_choilai
            // 
            this.btn_choilai.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_choilai.Location = new System.Drawing.Point(297, 23);
            this.btn_choilai.Name = "btn_choilai";
            this.btn_choilai.Size = new System.Drawing.Size(208, 42);
            this.btn_choilai.TabIndex = 2;
            this.btn_choilai.Text = "Chơi lại";
            this.btn_choilai.UseVisualStyleBackColor = true;
            this.btn_choilai.Click += new System.EventHandler(this.btn_choilai_Click);
            // 
            // btn_tamdung
            // 
            this.btn_tamdung.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_tamdung.Location = new System.Drawing.Point(47, 23);
            this.btn_tamdung.Name = "btn_tamdung";
            this.btn_tamdung.Size = new System.Drawing.Size(208, 42);
            this.btn_tamdung.TabIndex = 1;
            this.btn_tamdung.Text = "Tạm dừng";
            this.btn_tamdung.UseVisualStyleBackColor = true;
            this.btn_tamdung.Click += new System.EventHandler(this.btn_tamdung_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox_22);
            this.groupBox2.Controls.Add(this.pictureBox_12);
            this.groupBox2.Controls.Add(this.pictureBox_21);
            this.groupBox2.Controls.Add(this.pictureBox_11);
            this.groupBox2.Controls.Add(this.pictureBox_02);
            this.groupBox2.Controls.Add(this.pictureBox_20);
            this.groupBox2.Controls.Add(this.pictureBox_10);
            this.groupBox2.Controls.Add(this.pictureBox_01);
            this.groupBox2.Controls.Add(this.pictureBox_00);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 535);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khung ảnh";
            // 
            // pictureBox_22
            // 
            this.pictureBox_22.Location = new System.Drawing.Point(381, 359);
            this.pictureBox_22.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_22.Name = "pictureBox_22";
            this.pictureBox_22.Size = new System.Drawing.Size(173, 160);
            this.pictureBox_22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_22.TabIndex = 8;
            this.pictureBox_22.TabStop = false;
            this.pictureBox_22.Tag = "22";
            this.pictureBox_22.Click += new System.EventHandler(this.pictureBox_22_Click);
            // 
            // pictureBox_12
            // 
            this.pictureBox_12.Image = global::AI_8Puzzle.Properties.Resources._6;
            this.pictureBox_12.Location = new System.Drawing.Point(381, 194);
            this.pictureBox_12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_12.Name = "pictureBox_12";
            this.pictureBox_12.Size = new System.Drawing.Size(173, 160);
            this.pictureBox_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_12.TabIndex = 7;
            this.pictureBox_12.TabStop = false;
            this.pictureBox_12.Tag = "12";
            this.pictureBox_12.Click += new System.EventHandler(this.pictureBox_12_Click);
            // 
            // pictureBox_21
            // 
            this.pictureBox_21.Image = global::AI_8Puzzle.Properties.Resources._8;
            this.pictureBox_21.Location = new System.Drawing.Point(202, 359);
            this.pictureBox_21.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_21.Name = "pictureBox_21";
            this.pictureBox_21.Size = new System.Drawing.Size(173, 160);
            this.pictureBox_21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_21.TabIndex = 6;
            this.pictureBox_21.TabStop = false;
            this.pictureBox_21.Tag = "21";
            this.pictureBox_21.Click += new System.EventHandler(this.pictureBox_21_Click);
            // 
            // pictureBox_11
            // 
            this.pictureBox_11.Image = global::AI_8Puzzle.Properties.Resources._5;
            this.pictureBox_11.Location = new System.Drawing.Point(202, 194);
            this.pictureBox_11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_11.Name = "pictureBox_11";
            this.pictureBox_11.Size = new System.Drawing.Size(173, 160);
            this.pictureBox_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_11.TabIndex = 5;
            this.pictureBox_11.TabStop = false;
            this.pictureBox_11.Tag = "11";
            this.pictureBox_11.Click += new System.EventHandler(this.pictureBox_11_Click);
            // 
            // pictureBox_02
            // 
            this.pictureBox_02.Image = global::AI_8Puzzle.Properties.Resources._3;
            this.pictureBox_02.Location = new System.Drawing.Point(381, 29);
            this.pictureBox_02.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_02.Name = "pictureBox_02";
            this.pictureBox_02.Size = new System.Drawing.Size(173, 160);
            this.pictureBox_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_02.TabIndex = 4;
            this.pictureBox_02.TabStop = false;
            this.pictureBox_02.Tag = "02";
            this.pictureBox_02.Click += new System.EventHandler(this.pictureBox_02_Click);
            // 
            // pictureBox_20
            // 
            this.pictureBox_20.Image = global::AI_8Puzzle.Properties.Resources._7;
            this.pictureBox_20.Location = new System.Drawing.Point(23, 359);
            this.pictureBox_20.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_20.Name = "pictureBox_20";
            this.pictureBox_20.Size = new System.Drawing.Size(173, 160);
            this.pictureBox_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_20.TabIndex = 3;
            this.pictureBox_20.TabStop = false;
            this.pictureBox_20.Tag = "20";
            this.pictureBox_20.Click += new System.EventHandler(this.pictureBox_20_Click);
            // 
            // pictureBox_10
            // 
            this.pictureBox_10.Image = global::AI_8Puzzle.Properties.Resources._4;
            this.pictureBox_10.Location = new System.Drawing.Point(23, 194);
            this.pictureBox_10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_10.Name = "pictureBox_10";
            this.pictureBox_10.Size = new System.Drawing.Size(173, 160);
            this.pictureBox_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_10.TabIndex = 2;
            this.pictureBox_10.TabStop = false;
            this.pictureBox_10.Tag = "10";
            this.pictureBox_10.Click += new System.EventHandler(this.pictureBox_10_Click);
            // 
            // pictureBox_01
            // 
            this.pictureBox_01.Image = global::AI_8Puzzle.Properties.Resources._2;
            this.pictureBox_01.Location = new System.Drawing.Point(202, 29);
            this.pictureBox_01.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_01.Name = "pictureBox_01";
            this.pictureBox_01.Size = new System.Drawing.Size(173, 160);
            this.pictureBox_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_01.TabIndex = 1;
            this.pictureBox_01.TabStop = false;
            this.pictureBox_01.Tag = "01";
            this.pictureBox_01.Click += new System.EventHandler(this.pictureBox_01_Click);
            // 
            // pictureBox_00
            // 
            this.pictureBox_00.Image = global::AI_8Puzzle.Properties.Resources._1;
            this.pictureBox_00.Location = new System.Drawing.Point(23, 29);
            this.pictureBox_00.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_00.Name = "pictureBox_00";
            this.pictureBox_00.Size = new System.Drawing.Size(173, 160);
            this.pictureBox_00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_00.TabIndex = 0;
            this.pictureBox_00.TabStop = false;
            this.pictureBox_00.Tag = "00";
            this.pictureBox_00.Click += new System.EventHandler(this.pictureBox_00_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.img_goc);
            this.groupBox3.Location = new System.Drawing.Point(39, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 323);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hình gốc";
            // 
            // img_goc
            // 
            this.img_goc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_goc.Image = global::AI_8Puzzle.Properties.Resources.ngo_nghinh_anh_meo_cute_nupet_1;
            this.img_goc.Location = new System.Drawing.Point(3, 23);
            this.img_goc.Name = "img_goc";
            this.img_goc.Size = new System.Drawing.Size(464, 297);
            this.img_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_goc.TabIndex = 0;
            this.img_goc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 67);
            this.label1.TabIndex = 4;
            this.label1.Text = "00:00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1131, 72);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(315, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(490, 62);
            this.label4.TabIndex = 5;
            this.label4.Text = "Game ghép tranh 8 ô";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbCountMove);
            this.panel2.Controls.Add(this.lbtime);
            this.panel2.Controls.Add(this.lbNumberStep);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(575, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 644);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbCountMove
            // 
            this.lbCountMove.AutoSize = true;
            this.lbCountMove.BackColor = System.Drawing.Color.Transparent;
            this.lbCountMove.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCountMove.ForeColor = System.Drawing.Color.IndianRed;
            this.lbCountMove.Location = new System.Drawing.Point(37, 422);
            this.lbCountMove.Name = "lbCountMove";
            this.lbCountMove.Size = new System.Drawing.Size(193, 31);
            this.lbCountMove.TabIndex = 8;
            this.lbCountMove.Text = "Số bước duyệt: 0";
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.BackColor = System.Drawing.Color.Transparent;
            this.lbtime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbtime.Location = new System.Drawing.Point(37, 343);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(243, 31);
            this.lbtime.TabIndex = 5;
            this.lbtime.Text = "Thời gian giải: 2000ms";
            this.lbtime.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbNumberStep
            // 
            this.lbNumberStep.AutoSize = true;
            this.lbNumberStep.BackColor = System.Drawing.Color.Transparent;
            this.lbNumberStep.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNumberStep.ForeColor = System.Drawing.Color.IndianRed;
            this.lbNumberStep.Location = new System.Drawing.Point(37, 384);
            this.lbNumberStep.Name = "lbNumberStep";
            this.lbNumberStep.Size = new System.Drawing.Size(154, 31);
            this.lbNumberStep.TabIndex = 7;
            this.lbNumberStep.Text = "Số bước đi: 0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_next);
            this.panel3.Controls.Add(this.btn_back);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 644);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_next
            // 
            this.btn_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_next.BackgroundImage")));
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_next.Location = new System.Drawing.Point(518, 536);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(54, 42);
            this.btn_next.TabIndex = 9;
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::AI_8Puzzle.Properties.Resources.icons8_left_208px;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(2, 537);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 42);
            this.btn_back.TabIndex = 8;
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1131, 716);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_00)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_goc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_batdau;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox img_goc;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lbtime;
        private Button btn_giaitoiuu;
        private Button btn_bfs;
        private Button btn_choilai;
        private Button btn_tamdung;
        private Label label4;
        private Label lbNumberStep;
        private Button btn_next;
        private Button btn_back;
        private Label lbCountMove;
        private PictureBox pictureBox_20;
        private PictureBox pictureBox_10;
        private PictureBox pictureBox_01;
        private PictureBox pictureBox_00;
        private PictureBox pictureBox_22;
        private PictureBox pictureBox_12;
        private PictureBox pictureBox_21;
        private PictureBox pictureBox_11;
        private PictureBox pictureBox_02;
    }
}

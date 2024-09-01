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
            btn_batdau = new Button();
            groupBox1 = new GroupBox();
            btn_giaitoiuu = new Button();
            btn_bfs = new Button();
            btn_choilai = new Button();
            btn_tamdung = new Button();
            groupBox2 = new GroupBox();
            pbx9 = new PictureBox();
            pbx6 = new PictureBox();
            pbx8 = new PictureBox();
            pbx5 = new PictureBox();
            pbx3 = new PictureBox();
            pbx7 = new PictureBox();
            pbx4 = new PictureBox();
            pbx2 = new PictureBox();
            pbx1 = new PictureBox();
            groupBox3 = new GroupBox();
            img_goc = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            btn_next = new Button();
            btn_back = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_goc).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_batdau
            // 
            btn_batdau.BackColor = Color.LightCoral;
            btn_batdau.Dock = DockStyle.Bottom;
            btn_batdau.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_batdau.Location = new Point(3, 124);
            btn_batdau.Name = "btn_batdau";
            btn_batdau.Size = new Size(550, 52);
            btn_batdau.TabIndex = 0;
            btn_batdau.Text = "Bắt đầu";
            btn_batdau.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_giaitoiuu);
            groupBox1.Controls.Add(btn_bfs);
            groupBox1.Controls.Add(btn_choilai);
            groupBox1.Controls.Add(btn_tamdung);
            groupBox1.Controls.Add(btn_batdau);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 465);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 179);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btn_giaitoiuu
            // 
            btn_giaitoiuu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_giaitoiuu.Location = new Point(297, 75);
            btn_giaitoiuu.Name = "btn_giaitoiuu";
            btn_giaitoiuu.Size = new Size(208, 42);
            btn_giaitoiuu.TabIndex = 4;
            btn_giaitoiuu.Text = "Giải tối ưu";
            btn_giaitoiuu.UseVisualStyleBackColor = true;
            // 
            // btn_bfs
            // 
            btn_bfs.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_bfs.Location = new Point(47, 75);
            btn_bfs.Name = "btn_bfs";
            btn_bfs.Size = new Size(208, 42);
            btn_bfs.TabIndex = 3;
            btn_bfs.Text = "Giải BFS";
            btn_bfs.UseVisualStyleBackColor = true;
            // 
            // btn_choilai
            // 
            btn_choilai.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_choilai.Location = new Point(297, 23);
            btn_choilai.Name = "btn_choilai";
            btn_choilai.Size = new Size(208, 42);
            btn_choilai.TabIndex = 2;
            btn_choilai.Text = "Chơi lại";
            btn_choilai.UseVisualStyleBackColor = true;
            // 
            // btn_tamdung
            // 
            btn_tamdung.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_tamdung.Location = new Point(47, 23);
            btn_tamdung.Name = "btn_tamdung";
            btn_tamdung.Size = new Size(208, 42);
            btn_tamdung.TabIndex = 1;
            btn_tamdung.Text = "Tạm dừng";
            btn_tamdung.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pbx9);
            groupBox2.Controls.Add(pbx6);
            groupBox2.Controls.Add(pbx8);
            groupBox2.Controls.Add(pbx5);
            groupBox2.Controls.Add(pbx3);
            groupBox2.Controls.Add(pbx7);
            groupBox2.Controls.Add(pbx4);
            groupBox2.Controls.Add(pbx2);
            groupBox2.Controls.Add(pbx1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(574, 535);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khung ảnh";
            // 
            // pbx9
            // 
            pbx9.Location = new Point(381, 359);
            pbx9.Margin = new Padding(4);
            pbx9.Name = "pbx9";
            pbx9.Size = new Size(173, 160);
            pbx9.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx9.TabIndex = 8;
            pbx9.TabStop = false;
            // 
            // pbx6
            // 
            pbx6.Location = new Point(381, 194);
            pbx6.Margin = new Padding(4);
            pbx6.Name = "pbx6";
            pbx6.Size = new Size(173, 160);
            pbx6.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx6.TabIndex = 7;
            pbx6.TabStop = false;
            // 
            // pbx8
            // 
            pbx8.Location = new Point(202, 359);
            pbx8.Margin = new Padding(4);
            pbx8.Name = "pbx8";
            pbx8.Size = new Size(173, 160);
            pbx8.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx8.TabIndex = 6;
            pbx8.TabStop = false;
            // 
            // pbx5
            // 
            pbx5.Location = new Point(202, 194);
            pbx5.Margin = new Padding(4);
            pbx5.Name = "pbx5";
            pbx5.Size = new Size(173, 160);
            pbx5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx5.TabIndex = 5;
            pbx5.TabStop = false;
            // 
            // pbx3
            // 
            pbx3.Location = new Point(381, 29);
            pbx3.Margin = new Padding(4);
            pbx3.Name = "pbx3";
            pbx3.Size = new Size(173, 160);
            pbx3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx3.TabIndex = 4;
            pbx3.TabStop = false;
            // 
            // pbx7
            // 
            pbx7.Location = new Point(23, 359);
            pbx7.Margin = new Padding(4);
            pbx7.Name = "pbx7";
            pbx7.Size = new Size(173, 160);
            pbx7.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx7.TabIndex = 3;
            pbx7.TabStop = false;
            // 
            // pbx4
            // 
            pbx4.Location = new Point(23, 194);
            pbx4.Margin = new Padding(4);
            pbx4.Name = "pbx4";
            pbx4.Size = new Size(173, 160);
            pbx4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx4.TabIndex = 2;
            pbx4.TabStop = false;
            // 
            // pbx2
            // 
            pbx2.Location = new Point(202, 29);
            pbx2.Margin = new Padding(4);
            pbx2.Name = "pbx2";
            pbx2.Size = new Size(173, 160);
            pbx2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx2.TabIndex = 1;
            pbx2.TabStop = false;
            // 
            // pbx1
            // 
            pbx1.Location = new Point(23, 29);
            pbx1.Margin = new Padding(4);
            pbx1.Name = "pbx1";
            pbx1.Size = new Size(173, 160);
            pbx1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx1.TabIndex = 0;
            pbx1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(img_goc);
            groupBox3.Location = new Point(39, 17);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(470, 323);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hình gốc";
            // 
            // img_goc
            // 
            img_goc.Dock = DockStyle.Fill;
            img_goc.Image = Properties.Resources.ngo_nghinh_anh_meo_cute_nupet_1;
            img_goc.Location = new Point(3, 23);
            img_goc.Name = "img_goc";
            img_goc.Size = new Size(464, 297);
            img_goc.SizeMode = PictureBoxSizeMode.StretchImage;
            img_goc.TabIndex = 0;
            img_goc.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(167, 555);
            label1.Name = "label1";
            label1.Size = new Size(231, 67);
            label1.TabIndex = 4;
            label1.Text = "00:00:00";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(1131, 72);
            panel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(315, 1);
            label4.Name = "label4";
            label4.Size = new Size(490, 62);
            label4.TabIndex = 5;
            label4.Text = "Game ghép tranh 8 ô";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(575, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 644);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(37, 422);
            label2.Name = "label2";
            label2.Size = new Size(193, 31);
            label2.TabIndex = 8;
            label2.Text = "Số bước duyệt: 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 343);
            label3.Name = "label3";
            label3.Size = new Size(243, 31);
            label3.TabIndex = 5;
            label3.Text = "Thời gian giải: 2000ms";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(37, 384);
            label5.Name = "label5";
            label5.Size = new Size(154, 31);
            label5.TabIndex = 7;
            label5.Text = "Số bước đi: 0";
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_next);
            panel3.Controls.Add(btn_back);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(574, 644);
            panel3.TabIndex = 7;
            // 
            // btn_next
            // 
            btn_next.BackgroundImage = (Image)resources.GetObject("btn_next.BackgroundImage");
            btn_next.BackgroundImageLayout = ImageLayout.Zoom;
            btn_next.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_next.Location = new Point(518, 536);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(54, 42);
            btn_next.TabIndex = 9;
            btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            btn_back.BackgroundImage = Properties.Resources.icons8_left_208px;
            btn_back.BackgroundImageLayout = ImageLayout.Zoom;
            btn_back.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.Location = new Point(2, 537);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(54, 42);
            btn_back.TabIndex = 8;
            btn_back.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1131, 716);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Index";
            Text = "Index";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_goc).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private Label label3;
        private Button btn_giaitoiuu;
        private Button btn_bfs;
        private Button btn_choilai;
        private Button btn_tamdung;
        private Label label4;
        private Label label5;
        private Button btn_next;
        private Button btn_back;
        private Label label2;
        private PictureBox pbx7;
        private PictureBox pbx4;
        private PictureBox pbx2;
        private PictureBox pbx1;
        private PictureBox pbx9;
        private PictureBox pbx6;
        private PictureBox pbx8;
        private PictureBox pbx5;
        private PictureBox pbx3;
    }
}

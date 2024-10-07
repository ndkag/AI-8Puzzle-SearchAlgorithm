using GhepTranhAS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhepTranhAS
{
    public partial class Form1 : Form
    {
        int[,] MaTran;
        ThuatToanAS AS;
        Stack<int[,]> stk;
        Button[,] Mangbt;
        int emptyX, emptyY;
        int n = 3;
        int SoLanDiChuyen = 0;


        public Form1()
        {
           InitializeComponent();
            MaTran = new[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 0 } // Ô trống ban đầu
            };
            AS  = new ThuatToanAS();
           
            stk = new Stack<int[,]>();
            Mangbt = new Button[n, n];
        }
  
       
        int anh=1;
        private void Form1_Load(object sender, EventArgs e)
        {
            Mangbt[0, 0] = button_00;
            Mangbt[0, 1] = button_01;
            Mangbt[0, 2] = button_02;
            Mangbt[1, 0] = button_10;
            Mangbt[1, 1] = button_11;
            Mangbt[1, 2] = button_12;
            Mangbt[2, 0] = button_20;
            Mangbt[2, 1] = button_21;
            Mangbt[2, 2] = button_22;
           
            //btnBauDau.Enabled = false;
            btnDung.Enabled = false;
        }
        public string layPath(int a, int anh)
        {
            string path = "";
            if(anh==1)
            {
                if (a == 1) path = Application.StartupPath + @"\anh\\hoa1.jpg";
                else if (a == 2) path = Application.StartupPath + @"\anh\\hoa2.jpg";
                else if (a == 3) path = Application.StartupPath + @"\anh\\hoa3.jpg";
                else if (a == 4) path = Application.StartupPath + @"\anh\\hoa4.jpg";
                else if (a == 5) path = Application.StartupPath + @"\anh\\hoa5.jpg";
                else if (a == 6) path = Application.StartupPath + @"\anh\\hoa6.jpg";
                else if (a == 7) path = Application.StartupPath + @"\anh\\hoa7.jpg";
                else if (a == 8) path = Application.StartupPath + @"\anh\\hoa8.jpg";
            }
            else if (anh == 2)
            {
         
                if (a == 1) path = Application.StartupPath + @"\anh\\mew_1.jpg";
                else if (a == 2) path = Application.StartupPath + @"\anh\\mew_2.jpg";
                else if (a == 3) path = Application.StartupPath + @"\anh\\mew_3.jpg";
                else if (a == 4) path = Application.StartupPath + @"\anh\\mew_4.jpg";
                else if (a == 5) path = Application.StartupPath + @"\anh\\mew_5.jpg";
                else if (a == 6) path = Application.StartupPath + @"\anh\\mew_6.jpg";
                else if (a == 7) path = Application.StartupPath + @"\anh\\mew_7.jpg";
                else if (a == 8) path = Application.StartupPath + @"\anh\\mew_8.jpg";
            }
            else 
            {
                if (a == 1) path = Application.StartupPath + @"\anh\\cong1.jpg";
                else if (a == 2) path = Application.StartupPath + @"\anh\\cong2.jpg";
                else if (a == 3) path = Application.StartupPath + @"\anh\\cong3.jpg";
                else if (a == 4) path = Application.StartupPath + @"\anh\\cong4.jpg";
                else if (a == 5) path = Application.StartupPath + @"\anh\\cong5.jpg";
                else if (a == 6) path = Application.StartupPath + @"\anh\\cong6.jpg";
                else if (a == 7) path = Application.StartupPath + @"\anh\\cong7.jpg";
                else if (a == 8) path = Application.StartupPath + @"\anh\\cong8.jpg";
            }

            return path;
        }

  
        private void button10_Click(object sender, EventArgs e)
        {
            if (anh == 1) anh = 2;
            else if (anh == 2) anh = 3;
            else anh = 1;
            btnChoiMoi_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "1": timer1.Interval = 1000; break;
                case "2": timer1.Interval = 800; break;
                case "3": timer1.Interval = 500; break;
                case "4": timer1.Interval = 200; break;

            }

            int[,] Temp = new int[n, n];

            if (stk.Count != 0)
            {
                Temp = stk.Pop();
                loadanh(Temp, Mangbt);

                SoLanDiChuyen++;
                lbSobuocdi.Text = SoLanDiChuyen.ToString();
            }
            else
                timer1.Enabled = false;
        }

        private void btnBauDau_Click(object sender, EventArgs e)
        {
            batDauTim();
            timer1.Enabled = true;
            btnBauDau.Enabled = false;
            btnDung.Enabled = true;
        }

        private void btnDung_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            btnDung.Enabled = false;
            btnBauDau.Enabled = true;
        }

        private void btnChoiMoi_Click(object sender, EventArgs e)
        {

            khoiTao8So();
            btnBauDau.Enabled = true;
            
           
        }
        void khoiTao8So()
        {
            MaTran = AS.randomMaTran(n);

            loadanh(MaTran, Mangbt);

            //stk = AS.timKetQua(MaTran, n);
            //stk.Pop();
            //comboBox1.Text = comboBox1.Items[0].ToString();
            //lbSobuocdi.Text = "0";
            //SoLanDiChuyen = 0;
            //btnBauDau.Enabled = false;
            //btnDung.Enabled = false;
            //timer1.Enabled = false;
        }
        void timViTriChong()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (MaTran[i, j] == 0) {
                        emptyX = i;
                        emptyY = j;
                    }
                }
            }
        }
        void diChuyenAnh(object sender, EventArgs e)
        {
            var clickedBox = sender as Button;
            timViTriChong();
            // Lấy vị trí của mảnh ghép trong ma trận dựa trên Tag (giả sử mỗi PictureBox có Tag là vị trí của nó)
            var clickedX = clickedBox.Tag.ToString()[0] - '0'; // Hàng
            var clickedY = clickedBox.Tag.ToString()[1] - '0'; // Cột
            if (Math.Abs(clickedX - emptyX) + Math.Abs(clickedY - emptyY) == 1)
            {
                // Hoán đổi vị trí của ô trống và mảnh ghép
                MaTran[emptyX, emptyY] = MaTran[clickedX, clickedY];
                MaTran[clickedX, clickedY] = 0;

                // Cập nhật lại vị trí của ô trống
                emptyX = clickedX;
                emptyY = clickedY;
            }
            updateButton(this);
            Debug.WriteLine("Ma Trận");
            Debug.WriteLine(BoardToString(MaTran));

        }
        void batDauTim()
        {
            stk = AS.timKetQua(MaTran, n);
            stk.Pop();
            comboBox1.Text = comboBox1.Items[0].ToString();
            lbSobuocdi.Text = "0";
            SoLanDiChuyen = 0;
            btnBauDau.Enabled = false;
            btnDung.Enabled = false;
            timer1.Enabled = false;
        }
        void loadanh(int[,] a, Button[,] b)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[i, j] == 0)
                    {
                        b[i, j].Text = "";
                        //b[i, j].BackColor = Color.MediumSeaGreen;
                        b[i, j].Image = null;
                    }
                    else
                    {
                        b[i, j].Image = Image.FromFile(layPath(a[i, j], anh));

                    }
                }
            }
            if (anh == 1) pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\anh\\hoa.jpg");
            else if(anh==2) pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\anh\\mew.jpg");
            else pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\anh\\cong.jpg");

        }
        void updateButton(Form form)
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var button = form.Controls.Find($"button_{i}{j}", true).FirstOrDefault() as Button;
                    if (button != null)
                    {
                        if (MaTran[i, j] == 0)
                        {
                            button.Image = null; // Nếu là ô trống thì không hiển thị hình
                            button.Text = "";    // Xóa text nếu có
                        }
                        else
                        {
                            button.Image = GetImageForPiece(MaTran[i, j]); // Hiển thị hình ảnh mảnh ghép
                            button.Text = "";    // Xóa text nếu có
                        }
                    }
                }
            }
        }

        private Image GetImageForPiece(int pieceNumber)
        {
            switch (pieceNumber)
            {
                case 1: return Resources.hoa1;
                case 2: return Resources.hoa2;
                case 3: return Resources.hoa3;
                case 4: return Resources.hoa4;
                case 5: return Resources.hoa5;
                case 6: return Resources.hoa6;
                case 7: return Resources.hoa7;
                case 8: return Resources.hoa8;
                default: return null;
            }
        }
        public string BoardToString(int[,] board)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++) sb.Append(board[i, j] + " ");
                sb.AppendLine();
            }

            return sb.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}

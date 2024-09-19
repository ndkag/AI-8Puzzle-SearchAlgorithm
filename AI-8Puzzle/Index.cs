﻿
using System.Diagnostics;

namespace AI_8Puzzle
{
    public partial class Index : Form
    {
        private PuzzleState puzzleState;
        private PuzzleGame puzzleGame;



   

        public Index()
        {

            InitializeComponent();
            puzzleGame = new PuzzleGame(); // Khởi tạo game
            //puzzleGame.ShuffleBoard(this);
            puzzleGame.random(this);
            puzzleGame.UpdateUI(this);


        }

        private void btn_tamdung_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Index_Load(object sender, EventArgs e)
        {
          

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_bfs_Click(object sender, EventArgs e)
        {

            // Tạo trạng thái ban đầu từ ma trận hiện tại
            puzzleState = new PuzzleState(puzzleGame.GetBoard(), puzzleGame.GetEmptyX(), puzzleGame.GetEmptyY());
          
            // Giải bài toán với BFS
            var (solutionPath, elapsedTime, steps) = puzzleState.SolveWithBFS(puzzleState, this);
      
            lbtime.Text = $"Thời gian: {elapsedTime.TotalSeconds} giây";
            lbNumberStep.Text = $"Số bước: {steps}";
            if (solutionPath != null)
            {
                // Duyệt qua từng trạng thái trong đường đi và cập nhật giao diện
                foreach (var state in solutionPath)
                {
                    puzzleGame.SetBoard(state.Board); // Cập nhật ma trận của puzzleGame
                    puzzleGame.UpdateUI(this); // Cập nhật giao diện
                }
                MessageBox.Show("Puzzle đã được giải bằng BFS!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy giải pháp!");
            }
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_choilai_Click(object sender, EventArgs e)
        {
           
            //puzzleGame.ShuffleBoard(this);
            puzzleGame.random(this);


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_02_Click(object sender, EventArgs e)
        {
            // Tìm PictureBox vừa được click
            PictureBox clickedBox = sender as PictureBox;

            // Lấy vị trí của mảnh ghép trong ma trận dựa trên Tag (giả sử mỗi PictureBox có Tag là vị trí của nó)
            int clickedX = (int)clickedBox.Tag.ToString()[0] - '0'; // Hàng
            int clickedY = (int)clickedBox.Tag.ToString()[1] - '0'; // Cột
         
            puzzleGame.MovePiece(clickedX, clickedY, this);
        }
       
        private void pictureBox_00_Click(object sender, EventArgs e)
        {
            // Tìm PictureBox vừa được click
            PictureBox clickedBox = sender as PictureBox;

            // Lấy vị trí của mảnh ghép trong ma trận dựa trên Tag (giả sử mỗi PictureBox có Tag là vị trí của nó)
            int clickedX = (int)clickedBox.Tag.ToString()[0] - '0'; // Hàng
            int clickedY = (int)clickedBox.Tag.ToString()[1] - '0'; // Cột
            
            puzzleGame.MovePiece(clickedX, clickedY, this);

        }

        private void pictureBox_01_Click(object sender, EventArgs e)
        {
            // Tìm PictureBox vừa được click
            PictureBox clickedBox = sender as PictureBox;

            // Lấy vị trí của mảnh ghép trong ma trận dựa trên Tag (giả sử mỗi PictureBox có Tag là vị trí của nó)
            int clickedX = (int)clickedBox.Tag.ToString()[0] - '0'; // Hàng
            int clickedY = (int)clickedBox.Tag.ToString()[1] - '0'; // Cột
         
            puzzleGame.MovePiece(clickedX, clickedY, this);
        }

        private void pictureBox_10_Click(object sender, EventArgs e)
        {
            // Tìm PictureBox vừa được click
            PictureBox clickedBox = sender as PictureBox;

            // Lấy vị trí của mảnh ghép trong ma trận dựa trên Tag (giả sử mỗi PictureBox có Tag là vị trí của nó)
            int clickedX = (int)clickedBox.Tag.ToString()[0] - '0'; // Hàng
            int clickedY = (int)clickedBox.Tag.ToString()[1] - '0'; // Cột
        
            puzzleGame.MovePiece(clickedX, clickedY, this);
        }

        private void pictureBox_11_Click(object sender, EventArgs e)
        {
            // Tìm PictureBox vừa được click
            PictureBox clickedBox = sender as PictureBox;

            // Lấy vị trí của mảnh ghép trong ma trận dựa trên Tag (giả sử mỗi PictureBox có Tag là vị trí của nó)
            int clickedX = (int)clickedBox.Tag.ToString()[0] - '0'; // Hàng
            int clickedY = (int)clickedBox.Tag.ToString()[1] - '0'; // Cột
  
            puzzleGame.MovePiece(clickedX, clickedY, this);
        }

        private void pictureBox_12_Click(object sender, EventArgs e)
        {
            // Tìm PictureBox vừa được click
            PictureBox clickedBox = sender as PictureBox;

            // Lấy vị trí của mảnh ghép trong ma trận dựa trên Tag (giả sử mỗi PictureBox có Tag là vị trí của nó)
            int clickedX = (int)clickedBox.Tag.ToString()[0] - '0'; // Hàng
            int clickedY = (int)clickedBox.Tag.ToString()[1] - '0'; // Cột
       
            puzzleGame.MovePiece(clickedX, clickedY, this);
        }

        private void pictureBox_20_Click(object sender, EventArgs e)
        {
            // Tìm PictureBox vừa được click
            PictureBox clickedBox = sender as PictureBox;

            // Lấy vị trí của mảnh ghép trong ma trận dựa trên Tag (giả sử mỗi PictureBox có Tag là vị trí của nó)
            int clickedX = (int)clickedBox.Tag.ToString()[0] - '0'; // Hàng
            int clickedY = (int)clickedBox.Tag.ToString()[1] - '0'; // Cột
       
            puzzleGame.MovePiece(clickedX, clickedY, this);
        }

        private void pictureBox_21_Click(object sender, EventArgs e)
        {
            // Tìm PictureBox vừa được click
            PictureBox clickedBox = sender as PictureBox;

            // Lấy vị trí của mảnh ghép trong ma trận dựa trên Tag (giả sử mỗi PictureBox có Tag là vị trí của nó)
            int clickedX = (int)clickedBox.Tag.ToString()[0] - '0'; // Hàng
            int clickedY = (int)clickedBox.Tag.ToString()[1] - '0'; // Cột
        
            puzzleGame.MovePiece(clickedX, clickedY, this);

        }
       
        private void pictureBox_22_Click(object sender, EventArgs e)
        {
            // Tìm PictureBox vừa được click
            PictureBox clickedBox = sender as PictureBox;

            // Lấy vị trí của mảnh ghép trong ma trận dựa trên Tag (giả sử mỗi PictureBox có Tag là vị trí của nó)
            int clickedX = (int)clickedBox.Tag.ToString()[0] - '0'; // Hàng
            int clickedY = (int)clickedBox.Tag.ToString()[1] - '0'; // Cột
          
            puzzleGame.MovePiece(clickedX, clickedY, this);
        }

       
    }
}

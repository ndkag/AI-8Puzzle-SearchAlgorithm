using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_8Puzzle
{
    public class PuzzleGame
    {
        public int[,] board; // Ma trận lưu trạng thái của puzzle
        public int emptyX { get; set; }
        public int emptyY { get; set; }
        public PuzzleGame(int [,]_board,int _emptyX,int _emptyY)
        {
            board = _board;
            emptyX = _emptyX;
            emptyY = _emptyY;
        }

        // Vị trí hiện tại của ô trống
        public int[,] GetBoard()
        {
            return board;
        }
        public int GetEmptyX()
        {
            return emptyX;
        }
       
        public int GetEmptyY()
        {
            return emptyX;
        }

        public PuzzleGame()
        {
            InitializeBoard();
        }
        public int[,] random(Form form)
        {

            // Test case 1: Có thể giải được (valid)
            int[,] testCase1 = new int[,]
            {
    { 1, 2, 0 },
    { 3, 4, 6 },
    { 7, 5, 8 }
            };

            // Test case 2: Có thể giải được (valid)
            int[,] testCase2 = new int[,]
            {
    { 1, 0, 3 },
    { 4, 2, 6 },
    { 7, 5, 8 }
            };

            // Test case 3: Có thể giải được (valid)
            int[,] testCase3 = new int[,]
            {
    { 1, 2, 3 },
    { 4, 6, 0 },
    { 7, 5, 8 }
            };

            // Test case 4: Có thể giải được (valid)
            int[,] testCase4 = new int[,]
            {
    { 1, 2, 3 },
    { 5, 0, 6 },
    { 4, 7, 8 }
            };

            // Test case 5: Có thể giải được (valid)
            int[,] testCase5 = new int[,]
            {
    { 4, 1, 3 },
    { 2, 0, 6 },
    { 7, 5, 8 }
            };

            Random rnd = new Random();
            int dice = rnd.Next(1, 3);   // creates a number between 1 and 6
            if (dice == 1)
            {
                SetBoard(testCase1);
                UpdateUI(form);
                Console.WriteLine();
                return testCase1;
            }
            if (dice == 2)
            {
                SetBoard(testCase2);
                UpdateUI(form);
                return testCase2;

            }
            if (dice == 3)
            {
                SetBoard(testCase3);
                UpdateUI(form);
                return testCase3;

            }
            if (dice == 4)
            {
                SetBoard(testCase4);
                UpdateUI(form);
                return testCase4;

            }
            if (dice == 5)
            {
                SetBoard(testCase5);
                UpdateUI(form);
                return testCase5;

            }

        return null;
        }
        // Khởi tạo ma trận ban đầu
        public void InitializeBoard()
        {
            board = new int[,]
            {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 0 } // Ô trống ban đầu
            };

            emptyX = 2; // Vị trí x của ô trống
            emptyY = 2; // Vị trí y của ô trống
        }

        // Kiểm tra xem có thể di chuyển mảnh ghép được nhấn hay không
        public bool CanMovePiece(int clickedX, int clickedY)
        {
            return Math.Abs(clickedX - emptyX) + Math.Abs(clickedY - emptyY) == 1;
        }

        // Thực hiện di chuyển mảnh ghép
        public void MovePiece(int clickedX, int clickedY, Form form)
        {
            if (CanMovePiece(clickedX, clickedY))
            {
                // Hoán đổi vị trí của ô trống và mảnh ghép
                board[emptyX, emptyY] = board[clickedX, clickedY];
                board[clickedX, clickedY] = 0;

                // Cập nhật lại vị trí của ô trống
                emptyX = clickedX;
                emptyY = clickedY;
                UpdateUI(form);
                if (IsGameWon())
                {
                    MessageBox.Show("Bạn đã chiến thắng");
                }
            }
        }

        // Trả về ma trận hiện tại của puzzle
        public int[,] SetBoard(int[,] newBoard)
        {
            // Cập nhật giá trị của ma trận board từ newBoard
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = newBoard[i, j];

                    // Nếu tìm thấy ô trống (0), cập nhật vị trí của ô trống
                    if (newBoard[i, j] == 0)
                    {
                        emptyX = i;
                        emptyY = j;
                    }
                }
            }
            return board;
        }


        // Cập nhật UI theo trạng thái hiện tại của puzzle
        public void UpdateUI(Form form)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PictureBox pictureBox = form.Controls.Find($"pictureBox_{i}{j}", true).FirstOrDefault() as PictureBox;
                    if (pictureBox != null)
                    {
                        if (board[i, j] == 0)
                        {
                            pictureBox.Image = null; // Nếu là ô trống thì không hiển thị hình
                        }
                        else
                        {
                            pictureBox.Image = GetImageForPiece(board[i, j]); // Hiển thị hình ảnh mảnh ghép
                        }
                    }
                }
            }
        }

        // Lấy hình ảnh cho mảnh ghép tương ứng (giả sử bạn có hình ảnh riêng cho từng mảnh ghép)
        private Image GetImageForPiece(int pieceNumber)
        {
            switch (pieceNumber)
            {
                case 1: return Properties.Resources._1;
                case 2: return Properties.Resources._2;
                case 3: return Properties.Resources._3;
                case 4: return Properties.Resources._4;
                case 5: return Properties.Resources._5;
                case 6: return Properties.Resources._6;
                case 7: return Properties.Resources._7;
                case 8: return Properties.Resources._8;
                default: return null;
            }
        }
        public void ShuffleBoard(Form form)
        {
            Random rng = new Random();
            List<int> pieces = new List<int>();

            // Thêm các mảnh ghép (1 đến 8) và ô trống (0) vào danh sách
            for (int i = 1; i <= 8; i++)
            {
                pieces.Add(i);
            }
            pieces.Add(0); // Ô trống

            // Hoán đổi vị trí ngẫu nhiên trong danh sách các mảnh ghép
            for (int i = pieces.Count - 1; i > 0; i--)
            {
                int randomIndex = rng.Next(0, i + 1);
                int temp = pieces[i];
                pieces[i] = pieces[randomIndex];
                pieces[randomIndex] = temp;
            }

            // Đưa các mảnh ghép đã hoán đổi vào ma trận board
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = pieces[index];
                    if (pieces[index] == 0)
                    {
                        // Cập nhật vị trí ô trống
                        emptyX = i;
                        emptyY = j;
                    }
                    index++;
                }
            }
            SetBoard(board);
            UpdateUI(form);
            // Kiểm tra nếu puzzle ở trạng thái không giải được, thì hoán đổi thêm một lần nữa
            if (!IsSolvable())
            {
                MessageBox.Show("Bài toán không thể giải");
                // Hoán đổi hai mảnh ghép bất kỳ (tránh ô trống) để tạo trạng thái giải được
                if (board[0, 0] != 0 && board[0, 1] != 0)
                {
                    int temp = board[0, 0];
                    board[0, 0] = board[0, 1];
                    board[0, 1] = temp;
                }
                else
                {
                    int temp = board[1, 0];
                    board[1, 0] = board[1, 1];
                    board[1, 1] = temp;
                }
            }

        }
        private bool IsSolvable()
        {
            // Chuyển board thành một danh sách một chiều để kiểm tra số lượng đảo ngược
            List<int> oneDArray = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != 0) // Bỏ qua ô trống
                    {
                        oneDArray.Add(board[i, j]);
                    }
                }
            }

            // Đếm số lượng đảo ngược
            int inversions = 0;
            for (int i = 0; i < oneDArray.Count - 1; i++)
            {
                for (int j = i + 1; j < oneDArray.Count; j++)
                {
                    if (oneDArray[i] > oneDArray[j])
                    {
                        inversions++;
                    }
                }
            }

            // Puzzle có thể giải được nếu số lượng đảo ngược là chẵn
            return inversions % 2 == 0;
        }

        public bool IsGameWon()
        {
            // Trạng thái đích mong muốn
            int[,] goalState = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 0 }
            };

            // So sánh trạng thái hiện tại của bảng với trạng thái đích
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != goalState[i, j])
                    {
                        return false; // Nếu có bất kỳ ô nào không khớp, trò chơi chưa hoàn thành
                    }
                }
            }
            return true; // Tất cả các ô đều khớp với trạng thái đích
        }





    }
}

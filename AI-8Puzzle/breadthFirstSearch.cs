using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; // Để sử dụng Stopwatch

namespace AI_8Puzzle
{
    public class PuzzleState
    {
        
        public int[,] Board { get; set; } // Ma trận lưu trạng thái puzzle
        public int BlankX { get; set; } // Vị trí x của ô trống
        public int BlankY { get; set; } // Vị trí y của ô trống
        public PuzzleState Parent { get; set; } // Trạng thái cha, dùng để tìm lại đường đi

        // Hàm khởi tạo
        public PuzzleState(int[,] board, int blankX, int blankY, PuzzleState parent = null)
        {
            Board = board;
            BlankX = blankX;
            BlankY = blankY;
            Parent = parent;
        }

        // Kiểm tra xem trạng thái hiện tại có phải trạng thái đích không
        public bool IsGoalState()
        {
            int[,] goalState = new int[,]
            {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 0 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Board[i, j] != goalState[i, j])
                        return false;
                }
            }
            return true;
        }

        // Tạo chuỗi đại diện cho trạng thái (dùng để so sánh trong tập hợp đã duyệt)
        public string GetStateKey()
        {
            string key = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    key += Board[i, j].ToString();
                }
            }
            return key;
        }
        //public List<PuzzleState> SolveWithBFS(PuzzleState initialState)
        //{


        //    // Hàng đợi cho các trạng thái cần duyệt
        //    Queue<PuzzleState> queue = new Queue<PuzzleState>();

        //    // Tập hợp các trạng thái đã duyệt
        //    HashSet<string> visited = new HashSet<string>();

        //    // Thêm trạng thái ban đầu vào hàng đợi
        //    queue.Enqueue(initialState);
        //    visited.Add(initialState.GetStateKey());

        //    // BFS
        //    while (queue.Count > 0)
        //    {
        //        var currentState = queue.Dequeue();

        //        // Kiểm tra nếu trạng thái hiện tại là trạng thái đích
        //        if (currentState.IsGoalState())
        //        {
        //            return GetSolutionPath(currentState); // Trả về đường đi từ trạng thái ban đầu đến trạng thái đích
        //        }

        //        // Tìm các trạng thái tiếp theo (di chuyển ô trống)
        //        foreach (var neighbor in GetNeighbors(currentState))
        //        {
        //            if (!visited.Contains(neighbor.GetStateKey()))
        //            {
        //                queue.Enqueue(neighbor);
        //                visited.Add(neighbor.GetStateKey());
        //            }
        //        }
        //    }

        //    return null; // Trả về null nếu không tìm thấy giải pháp
        //}
        private void UpdateUI(PuzzleState currentState, Form form)
        {
            PuzzleGame puzzleGame = new PuzzleGame();
            puzzleGame.SetBoard(currentState.Board); // Cập nhật ma trận của puzzleGame với trạng thái hiện tại
            puzzleGame.UpdateUI(form); // Cập nhật giao diện trên form
        }
        public (List<PuzzleState> path, TimeSpan elapsedTime, int steps) SolveWithBFS(PuzzleState initialState, Form form)
        {
            // Bắt đầu đo thời gian
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Hàng đợi cho các trạng thái cần duyệt
            Queue<PuzzleState> queue = new Queue<PuzzleState>();

            // Tập hợp các trạng thái đã duyệt
            HashSet<string> visited = new HashSet<string>();

            // Thêm trạng thái ban đầu vào hàng đợi
            queue.Enqueue(initialState);
            visited.Add(initialState.GetStateKey());

            // BFS
            while (queue.Count > 0)
            {
                var currentState = queue.Dequeue();
                UpdateUI(currentState, form);
                Thread.Sleep(500);
                // Kiểm tra nếu trạng thái hiện tại là trạng thái đích
                if (currentState.IsGoalState())
                {
                    stopwatch.Stop(); // Dừng đồng hồ khi tìm thấy giải pháp
                    List<PuzzleState> solutionPath = GetSolutionPath(currentState);

                    // Trả về kết quả: đường đi, thời gian thực hiện và số bước
                    return (solutionPath, stopwatch.Elapsed, solutionPath.Count - 1); // Trừ đi 1 vì không tính trạng thái ban đầu
                }

                // Tìm các trạng thái tiếp theo (di chuyển ô trống)
                foreach (var neighbor in GetNeighbors(currentState))
                {
                    if (!visited.Contains(neighbor.GetStateKey()))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor.GetStateKey());
                    }
                }
                
            }

            stopwatch.Stop();
            return (null, stopwatch.Elapsed, 0); // Trả về null nếu không tìm thấy giải pháp
        }
        public List<PuzzleState> GetNeighbors(PuzzleState state)
        {
            List<PuzzleState> neighbors = new List<PuzzleState>();

            // Tất cả các hướng di chuyển của ô trống
            int[,] directions = new int[,]
            {
                { -1, 0 }, // Lên
                { 1, 0 },  // Xuống
                { 0, -1 }, // Trái
                { 0, 1 }   // Phải
            };

            for (int i = 0; i < 4; i++)
            {
                int newX = state.BlankX + directions[i, 0];
                int newY = state.BlankY + directions[i, 1];

                if (newX >= 0 && newX < 3 && newY >= 0 && newY < 3)
                {
                    // Tạo trạng thái mới bằng cách di chuyển ô trống
                    int[,] newBoard = (int[,])state.Board.Clone();
                    newBoard[state.BlankX, state.BlankY] = newBoard[newX, newY];
                    newBoard[newX, newY] = 0;

                    // Thêm trạng thái mới vào danh sách lân cận
                    neighbors.Add(new PuzzleState(newBoard, newX, newY, state));
                }
            }

            return neighbors;
        }
        public List<PuzzleState> GetSolutionPath(PuzzleState goalState)
        {
            List<PuzzleState> path = new List<PuzzleState>();
            PuzzleState currentState = goalState;

            while (currentState != null)
            {
                path.Add(currentState);
                currentState = currentState.Parent; // Truy ngược lại cha của trạng thái
            }

            path.Reverse(); // Đảo ngược danh sách để có đường đi từ trạng thái ban đầu đến trạng thái đích
            return path;
        }


    }

}

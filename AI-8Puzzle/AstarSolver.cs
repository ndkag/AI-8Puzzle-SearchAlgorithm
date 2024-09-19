using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace AI_8Puzzle
{
    //public class AStarSolver
    //{
    //    public (List<PuzzleState> path, TimeSpan elapsedTime, int steps) SolveWithAStar(PuzzleState initialState)
    //    {
    //        // Bắt đầu đo thời gian
    //        Stopwatch stopwatch = new Stopwatch();
    //        stopwatch.Start();

    //        // Priority Queue để mở rộng các trạng thái theo độ ưu tiên f(n) = g(n) + h(n)
    //        var priorityQueue = new SortedList<int, PuzzleState>();

    //        // Tập hợp các trạng thái đã duyệt
    //        HashSet<string> visited = new HashSet<string>();

    //        // Thêm trạng thái ban đầu vào priorityQueue
    //        priorityQueue.Add(0, initialState);
    //        visited.Add(initialState.GetStateKey());

    //        while (priorityQueue.Count > 0)
    //        {
    //            // Lấy trạng thái có f(n) nhỏ nhất
    //            var currentState = priorityQueue.Values[0];
    //            priorityQueue.RemoveAt(0);

    //            // Kiểm tra nếu trạng thái hiện tại là trạng thái đích
    //            if (currentState.IsGoalState())
    //            {
    //                stopwatch.Stop(); // Dừng đồng hồ khi tìm thấy giải pháp
    //                List<PuzzleState> solutionPath = GetSolutionPath(currentState);

    //                // Trả về kết quả: đường đi, thời gian thực hiện và số bước
    //                return (solutionPath, stopwatch.Elapsed, solutionPath.Count - 1);
    //            }

    //            // Tìm các trạng thái tiếp theo (di chuyển ô trống)
    //            foreach (var neighbor in GetNeighbors(currentState))
    //            {
    //                if (!visited.Contains(neighbor.GetStateKey()))
    //                {
    //                    int priority = CalculateHeuristic(neighbor) + neighbor.Depth;
    //                    priorityQueue.Add(priority, neighbor);
    //                    visited.Add(neighbor.GetStateKey());
    //                }
    //            }
    //        }

    //        stopwatch.Stop();
    //        return (null, stopwatch.Elapsed, 0); // Trả về null nếu không tìm thấy giải pháp
    //    }

    //    // Hàm heuristic tính khoảng cách Manhattan
    //    private int CalculateHeuristic(PuzzleState state)
    //    {
    //        int[,] goalState = new int[,]
    //        {
    //        { 1, 2, 3 },
    //        { 4, 5, 6 },
    //        { 7, 8, 0 }
    //        };

    //        int manhattanDistance = 0;

    //        for (int i = 0; i < 3; i++)
    //        {
    //            for (int j = 0; j < 3; j++)
    //            {
    //                int value = state.Board[i, j];
    //                if (value != 0) // Không tính ô trống
    //                {
    //                    // Tìm vị trí mong muốn của giá trị hiện tại
    //                    int goalX = (value - 1) / 3;
    //                    int goalY = (value - 1) % 3;

    //                    // Tính khoảng cách Manhattan
    //                    manhattanDistance += Math.Abs(i - goalX) + Math.Abs(j - goalY);
    //                }
    //            }
    //        }

    //        return manhattanDistance;
    //    }
    //    public List<PuzzleState> GetSolutionPath(PuzzleState goalState)
    //    {
    //        List<PuzzleState> path = new List<PuzzleState>();
    //        PuzzleState currentState = goalState;

    //        while (currentState != null)
    //        {
    //            path.Add(currentState);
    //            currentState = currentState.Parent; // Truy ngược lại cha của trạng thái
    //        }

    //        path.Reverse(); // Đảo ngược danh sách để có đường đi từ trạng thái ban đầu đến trạng thái đích
    //        return path;
    //    }
    //    public List<PuzzleState> GetNeighbors(PuzzleState state)
    //    {
    //        List<PuzzleState> neighbors = new List<PuzzleState>();

    //        // Tất cả các hướng di chuyển của ô trống
    //        int[,] directions = new int[,]
    //        {
    //            { -1, 0 }, // Lên
    //            { 1, 0 },  // Xuống
    //            { 0, -1 }, // Trái
    //            { 0, 1 }   // Phải
    //        };

    //        for (int i = 0; i < 4; i++)
    //        {
    //            int newX = state.BlankX + directions[i, 0];
    //            int newY = state.BlankY + directions[i, 1];

    //            if (newX >= 0 && newX < 3 && newY >= 0 && newY < 3)
    //            {
    //                // Tạo trạng thái mới bằng cách di chuyển ô trống
    //                int[,] newBoard = (int[,])state.Board.Clone();
    //                newBoard[state.BlankX, state.BlankY] = newBoard[newX, newY];
    //                newBoard[newX, newY] = 0;

    //                // Thêm trạng thái mới vào danh sách lân cận
    //                neighbors.Add(new PuzzleState(newBoard, newX, newY, state));
    //            }
    //        }

    //        return neighbors;
    //    }
    //}

}

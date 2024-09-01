using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_8Puzzle
{
    class BreadthFirstSearch
    {
        public int _vertices { get; set; } // Số đỉnh của đồ thị
        public List<int>[] _adjacencyList; // Danh sách kề
        public BreadthFirstSearch(int vertices)
        {
            _vertices = vertices;
            _adjacencyList = new List<int>[vertices];
            for(int i = 0; i < vertices; i++)
            {
                _adjacencyList[i] = new List<int>();

            }

        }
        // Hàm thêm cạnh vào đồ thị
        public void AddEdge(int v, int w)
        {
            _adjacencyList[v].Add(w);
        }
    }
}

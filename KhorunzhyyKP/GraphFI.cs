using System;
using System.Linq;

namespace KhorunzhyyKP
{
    public class GraphFI
    {
        private bool[,] matrix;
        private int[] fi;
        private int edge = 0, node = 0;

        public bool[,] Matrix { get { return matrix; } }
        public int[] FI { get { return fi; } }
        
        public GraphFI(int[] FI){
            if (!CheckFI(FI))
                throw new Exception("Помилка формату представлення даних FI");
            calculateNodeAndEdge(FI, ref node, ref edge);
            matrix = ConvertToMatrix(FI, node);
            fi = FI;
        }
        public GraphFI(string FI){
            int[] fi = FI.Split(' ').Select(x => int.Parse(x)).ToArray();
            if (!CheckFI(fi))
                throw new Exception("Помилка формату представлення даних FI");
            calculateNodeAndEdge(fi, ref node, ref edge);
            matrix = ConvertToMatrix(fi, node);
            this.fi = fi;
        }

        /// <summary>
        /// Перевірка FI на наявність помилок
        /// </summary>
        /// <param name="FI"></param>
        /// <returns></returns>
        public bool CheckFI(int[] FI){
            if (FI == null)
                return false;
            int edge = 0, node = 0;
            calculateNodeAndEdge(FI, ref node, ref edge);
            if (node > 20) return false;
            if (edge > 50) return false;
            int n = node;
            for (int i = 0; i < FI.Length; i++)
            {
                if (FI[i] > n)
                    return false;
                if (FI[i] < 0)
                    return false;
            }

            bool[,] matrix = ConvertToMatrix(FI, node);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (matrix[i, j] == true && matrix[j, i] == false)
                        return false;
            return true;
        }

        /// <summary>
        /// Створення із FI матриці суміжності
        /// </summary>
        /// <param name="FI"></param>
        /// <returns></returns>
        private bool[,] ConvertToMatrix(int[] FI, int node){
            int n = node;
            bool[,] matrix = new bool[n, n];
            int edge = 0;

            for (int i = 0; i < FI.Length; i++)
                if (FI[i] != 0)
                    matrix[edge, FI[i] - 1] = true;
                else
                    edge++;
            return matrix;
        }

        /// <summary>
        /// Розрахунок кількості ребер 
        /// </summary>
        private void calculateNodeAndEdge(int[] FI, ref int node, ref int edge){
            for (int i = 0; i < FI.Length; i++)
                if (FI[i] == 0)
                    node++;
                else 
                    edge++;
            edge = edge / 2;
        }
    }
}

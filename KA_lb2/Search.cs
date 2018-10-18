using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KA_lb2
{

    //Каждую субматрицу можно представить в виде последовательности строк
    //и последовательности столбцов. 
    //Можно пройтись по строкам и найти столбцы, дающие максимальную сумму.
    //Например у нас есть количество возможных субматриц с границами rowStart и rowEnd
    //Надо найти границы ColStart и ColEnd, дающие максимальную сумму. 
    //Нам необходимо найти colStart и colEnd, которые дают нам максимально возможную сумму всех субматриц rowStart сверху и rowEnd снизу.
    //Можно вычислить сумму каждого столбца и использовать функцию findMaxSubArray.
    //Это означает, что максимальная субматрица должна простираться от(rowStart, colStart) до(rowEnd, colEnd).
    class Search
    {
        private int maxRowStart = 0;  // номер строки с которой начинается максимальная субматрица
        private int maxRowEnd = 0;   // номер строки которой заканчивается максимальная субматрица
        private int maxColStart = 0;  // номер столбца с которого начинается максимальная субматрица
        private int maxColEnd = 0;    // номер столбца с которым заканчивается максимальная субматрица

        private int maxSum = 0;

        private int[][] matrix;  // матрица, в которой ищем

        int n_str, // количество строк
            n_col; // количество столбцов

        public int N_str { get { return n_str; } set { n_str = value; } }
        public int N_col { get { return n_col; } set { n_col = value; } }
        public int MaxSum { get { return maxSum; } } 

        public Search(int[][] arr)
        {
            matrix = arr;
        }

        /// <summary>
        /// Функция образующая максимальную матрицу по заданным координатам
        /// </summary>
        /// <returns>максимальную подматрицу</returns>
        public int[][] getNewMatrix()
        {
            n_str = maxRowEnd - maxRowStart + 1;
            n_col = maxColEnd - maxColStart + 1;
            int[][] newMatrix = new int[n_str][];
            for (int i = 0; i < n_str; i++)
                newMatrix[i] = new int[n_col];
            for (int i = maxRowStart, k = 0; i <= maxRowEnd; i++, k++)
            {
                for(int j = maxColStart, l= 0; j <= maxColEnd; j++, l++)
                    newMatrix[k][l] = matrix[i][j];
            }
            return newMatrix;
        }

        /// <summary>
        /// Очистка массива.
        /// </summary>
        /// <param name="array">Массив</param>
        public static void clearArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = 0;
        }


        /// <summary>
        /// Поиск максимальной подматрицы.
        /// </summary>
        public void maxSubMatrix()
        {
            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;
            int start = 0;
            int fin = 0;
            int[] partialSum = new int[colCount];  // массив сумм подмассива

            // Идем по всем строкам
            for (int rowStart = 0; rowStart < rowCount; rowStart++)
            {
                // очищаем подмассив сумм
                clearArray(partialSum);

                //  для текущего прямоугольника, ограниченного rowstart и rowend считаем сумму элементов по столбцам
                for (int rowEnd = rowStart; rowEnd < rowCount; rowEnd++)
                {
                    for (int i = 0; i < colCount; i++)
                    {
                        partialSum[i] += matrix[rowEnd][i];
                    }

                    // ищем координаты столбцов, и считаем сумму
                    int tempMaxSum = findMaxSubArray(partialSum, out start, out fin);

                    // если полученная сумма, больше максимума 
                    // запоминаем сумму и координаты
                    if (tempMaxSum > maxSum)
                    {
                        maxRowStart = rowStart;
                        maxRowEnd = rowEnd;
                        maxColStart = start;
                        maxColEnd = fin;
                        maxSum = tempMaxSum;
                    }
                }
            }
        }

        /// <summary>
        /// Поиск максимального подмассива (одномерного)
        /// </summary>
        /// <param name="arr">Массив</param>
        /// <param name="maxSumStartIndex">Начальный индекс максимального подмассива</param>
        /// <param name="maxSumLastIndex">Конечный индекс максимального подмассива</param>
        /// <returns>Максимальную подсумму</returns>
        public static int findMaxSubArray(int[] arr, out int maxSumStartIndex, out int maxSumLastIndex)
        {
            maxSumStartIndex = 0;
            maxSumLastIndex = 0;
            int maxSum = arr[0];

            int lastSumStartIndex = 0;
            int lastSum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {

                lastSum += arr[i];
                if (lastSum < arr[i])
                {
                    lastSum = arr[i];
                    lastSumStartIndex = i;
                }

                if (maxSum < lastSum)
                {
                    maxSumStartIndex = lastSumStartIndex;
                    maxSumLastIndex = i;
                    maxSum = lastSum;
                }
            }
            return maxSum;
        }

           
    }
}

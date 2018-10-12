using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KA_lb2
{
    // Класс работы матрицы с dataGridView
    class MatrMake
    {
        int n_str, // количество строк
            n_col; // количество столбцов
        int[][] matrix; // обрабатываемая матрица

        public MatrMake(int _n_str, int _n_col)
        {
            n_str = _n_str; 
            n_col = _n_col;
            matrix = new int[n_str][];
            for (int i = 0; i < n_str; i++)
                matrix[i] = new int[n_col];
        }

        public int[][] getMatrix()
        {
            return matrix;
        }

        public int N_str { get{ return n_str;} set { n_str = value; }}
        public int N_col { get { return n_col; } set { n_col = value; } }

        public void setMatrix(int [][] matr)
        {
            matrix = matr;
        }

        /// <summary>
        /// Установка dataGrid
        /// </summary>
        /// <param name="countCol">Столбцы</param>
        /// <param name="countRow">Строки</param>
        /// <param name="width">Ширина ячейки</param>
        /// <param name="dv">DataGrid</param>
        public static void instailDataGrid(int countCol, int countRow, int width, DataGridView dv)
        {
            DataTable matr = new DataTable("matr");
            DataColumn[] cols = new DataColumn[countCol];

            for (int i = 0; i < countCol; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                matr.Columns.Add(cols[i]);
            }

            for (int i = 0; i < countRow; i++)
            {
                DataRow newRow;
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }

            dv.DataSource = matr;
            for (int i = 0; i < countCol; i++)
                dv.Columns[i].Width = width;
        }

        /// <summary>
        ///Заполнение матрицы из dataGrid 
        /// </summary>
        /// <param name="dgv">dataGrid </param>
        public void GridToMatrix(DataGridView dgv)
        {
            DataGridViewCell txtCell;
            for (int i = 0; i < n_str; i++)
            {
                for (int j = 0; j < n_col; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    string s = txtCell.Value.ToString();
                    if (s == "")
                        matrix[i][j] = 0;
                    else
                        matrix[i][j] = Int32.Parse(s);
                }
            }
        }

        /// <summary>
        /// Заполнение dataGrid
        /// </summary>
        /// <param name="dgv">dataGrid</param>
        public void MatrixToGrid(DataGridView dgv)
        {
            DataTable matr = new DataTable("matr");
            DataColumn[] cols = new DataColumn[n_col];

            for (int i = 0; i < n_col; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                matr.Columns.Add(cols[i]);
            }

            for (int i = 0; i < n_str; i++)
            {
                DataRow newRow;
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }

            dgv.DataSource = matr;

            for (int i = 0; i < n_col; i++)
                dgv.Columns[i].Width = 50;

            // занесение значений
            DataGridViewCell txtCell;
            for (int i = 0; i < n_str; i++)
            {
                for (int j = 0; j < n_col; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    txtCell.Value = matrix[i][j].ToString();
                }
            }
        }

        
    }
}

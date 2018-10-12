using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KA_lb2
{
    //13a. Поиск прямоугольного фрагмента с максимальной суммой в двумерной матрице.
    // Пример входных данных:     Результат:
    // -1 2 -8                      2
    // 0  9  2                      9

    public partial class mnForm : Form
    {
        int width = 50; // ширина ячейки
        int countCol; // кол-во столбцов
        int countRow; // кол-во строк
        public mnForm()
        {
            InitializeComponent();
            changeVisible(true, false);
            dtResult.Visible = false;
        }

        /// <summary>
        /// Установка заданного размера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            dtResult.Visible = false;
            if (getNumber())
                MatrMake.instailDataGrid(countCol, countRow, width, dtStart);
            changeVisible(true, true);
        }

        /// <summary>
        /// Поиск максимального прямоугольника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtResult.Visible = true;
            MatrMake matr = new MatrMake(countRow, countCol);
            matr.GridToMatrix(dtStart);
            Search search = new Search(matr.getMatrix());
            search.maxSubMatrix();
            matr.setMatrix(search.getNewMatrix());
            matr.N_col = search.N_col;
            matr.N_str = search.N_str;

            MatrMake.instailDataGrid(matr.N_col, matr.N_str, width, dtResult);

            matr.MatrixToGrid(dtResult);
            changeVisible(true, false);
        }

        /// <summary>
        /// Изменение доступности компонентов
        /// </summary>
        /// <param name="a">boolean для кнопки generate</param>
        /// <param name="b">boolean для кнопки search</param>
        private void changeVisible(bool a, bool b)
        {
            btnGenerate.Visible = a;
            btnSearch.Visible = b;
        }

        /// <summary>
        /// Получение значений кол-ва строк и столбцов
        /// </summary>
        /// <returns>Удалось ли корректно их считать</returns>
        private bool getNumber()
        {
            bool result = false;
            try
            {
                countCol = Convert.ToInt32(cbColColumns.Text);
                countRow = Convert.ToInt32(cbColRow.Text);
                result = true;
            }
            catch (FormatException e)
            {
                MessageBox.Show("Enter the arguments!", "Message");
            }
            return result;
        }


        /// <summary>
        /// Условие задачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You should to find a rectangular fragment \nwith a maximum sum in a two-dimensional matrix.", "Task");
        }
    }
}

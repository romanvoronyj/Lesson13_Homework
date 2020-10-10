using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Homework_Task4
{
    class MyMatrix
    {
        private  int matrixRowsQty;
        private int matrixColsQty;

        private int[,] matrix = null;
        public int MatrixRowsQty
        {
            get
            {
                return matrixRowsQty;
            }
            set
            {
                matrixRowsQty = value;
            }
        }
        public int MatrixColsQty
        {
            get
            {
                return matrixColsQty;
            }
            set
            {
                matrixColsQty = value;
            }
        }
        public MyMatrix(int matrixRowsQty, int matrixColsQty)
        {
            if(matrixRowsQty < 0 || matrixColsQty < 0)
            {
                Console.WriteLine("Значення аргументів не можуть бути від'ємними");
            }
            else
            {
                this.matrixColsQty = matrixColsQty;
                this.matrixRowsQty = matrixRowsQty;
                matrix = new int[matrixColsQty, matrixRowsQty]; 
            }
        }
        public void NewMatrix(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                Console.WriteLine("Значення аргументів не можуть бути від'ємними");
            }
            else
            {
                this.matrixColsQty = x;
                this.matrixRowsQty = y;
                matrix = new int[matrixColsQty, matrixRowsQty];
            }
        }


    }
}

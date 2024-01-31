using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TMSLesson1
{
    internal class Square
    {
        private int sideSize;
        private string squareColor;
        private int squareSpace;

        public Square(int sideSize, string squareColor)
        {
            this.sideSize = sideSize;
            this.squareColor = squareColor;
            CalculateSquareSpace(sideSize);
        }

        public int CalculateSquareSpace(int sideSize)
        {
            return squareSpace = sideSize * sideSize;
        }

        public void PrintInfoAboutSquare()
        {
            Console.WriteLine("Side size is " + sideSize);
            Console.WriteLine("Square color is " + squareColor);
            Console.WriteLine("Square space is " + CalculateSquareSpace(sideSize));
            Console.WriteLine();
        }

        public int getSideSize()
        {
            return sideSize;
        }
        
        public void setSideSize(int sideSize)
        {
            this.sideSize = sideSize;
        }
    }
}

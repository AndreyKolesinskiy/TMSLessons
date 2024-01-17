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
        public int sideSize;
        public string squareColor;
        public int squareSpace;

        public Square(int sideSize, string squareColor) 
        {
            this.sideSize = sideSize;
            this.squareColor = squareColor;
            calculateSquareSpace(sideSize);
        }

        public int calculateSquareSpace(int sideSize)
        {
             return squareSpace = sideSize*sideSize;
        }

        public void printInfoAboutSquare()
        {
            Console.WriteLine("Side size is " + sideSize);
            Console.WriteLine("Square color is " + squareColor);
            Console.WriteLine("Square space is " + calculateSquareSpace(sideSize));
            Console.WriteLine();
        }
    }
}

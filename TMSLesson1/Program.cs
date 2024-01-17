using TMSLesson1;

internal class Program
{
    private static void Main(string[] args)
    {
        Square greenSquare = new Square(5, "Green");
        Square darkBlueSquare = new Square(2, "Dark Blue");
        Square lightBlueSquare = new Square(15, "Light Blue");

        greenSquare.printInfoAboutSquare();
        darkBlueSquare.printInfoAboutSquare();
        lightBlueSquare.printInfoAboutSquare();
        greenSquare.sideSize = darkBlueSquare.sideSize * 3;

        greenSquare.printInfoAboutSquare();
    }
}
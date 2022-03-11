using System;
 
class Snake_and_ladder
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Snakes and Ladder");

        Random Dice = new Random(); // iniciate a Object
        int random = Dice.Next(1, 7);// variable

        Console.WriteLine(random);
    


    }
}

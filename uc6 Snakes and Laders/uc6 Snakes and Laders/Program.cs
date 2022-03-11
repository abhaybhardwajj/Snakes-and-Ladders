using System;

class Snake_and_ladder

{
    public int Position = 0;
    public const int Snakes = 1;
    public const int Ladder = 2;
    public int previous = 0;
    public int count = 0;

    public static void Main(string[] args)
    {
        Console.WriteLine("Snakes and Ladder");
        Snake_and_ladder player = new Snake_and_ladder();// object

        while (player.Position < 100)
        {
            player.option();

            Console.WriteLine(player.Position);
        }

        Console.WriteLine("Num of Dice role" + player.count);

    }
    public void option()
    {
        Random Dice = new Random(); // iniciate a Object
        int random = Dice.Next(1, 7);
        count++;
        Random player = new Random();
        int random1 = player.Next(1, 3);

        previous = Position;

        switch (random1)

        {
            case Ladder:
                Position += random;
                break;

            case Snakes:
                Position -= random;
                if (Position < 0)
                {
                    Position = 0;
                }
                break;

            default:
                break;




        }
        if (Position > 100)
        {
            Position = previous;
        }


    }
}
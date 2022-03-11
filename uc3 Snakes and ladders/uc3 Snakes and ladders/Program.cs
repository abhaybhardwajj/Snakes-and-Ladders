using System;

class Snake_and_ladder

{
    public int Position = 0;
    public const int Snakes = 1;
    public const int Ladder = 2;

    public static void Main(string[] args)
    {
        Console.WriteLine("Snakes and Ladder");
        Snake_and_ladder player = new Snake_and_ladder();// object
        player.option();
        Console.WriteLine(player.Position);

    }
    public void option()
    {
        Random Dice = new Random(); // iniciate a Object
        int random = Dice.Next(1, 7);
        Random player = new Random();
        int random1 = player.Next(1, 3);

        switch (random1)
        {
            case Ladder:
                Position += random;
                break;
                case Snakes:
                Position -= random;
                break;
                default:
                break;

            

                
        }

    }
         


    }

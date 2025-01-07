public class Program
{
    public static int PlayerScore = 0;
    public static int Rivalscore = 0;
    public static int roundnumber = 0;

    public static void Main(string[] args)
    {
        Rules();
        Game();
    }
    public static void Rules()
    {
        Console.WriteLine("Dice game");
        Console.WriteLine("In this game you and a computer rival will play 10 rounds ");
        Console.WriteLine("where you will each roll a 6-sided dice, and the player ");
        Console.WriteLine("with the highest dice value will win the round.The Player");
        Console.WriteLine("Who wins the most rounds the game.Good luck!");
        Console.WriteLine("press any key to start...");
        Console.ReadKey();
    }

    public static void Game()
    {
        for(int i=0; i<10;i++){
        Random Dice = new Random();
        int num = Dice.Next(1, 7);
        roundnumber = roundnumber + 1;
        Console.WriteLine();
        Console.WriteLine("Round "+roundnumber);
        Console.WriteLine("Rival rolled a " + num);
        Console.WriteLine("press any key to roll the dice...");
        Console.ReadKey();
        Random RivalDice = new Random();
        int num1 = RivalDice.Next(1, 7);
        Console.WriteLine("you rolled a " + num1);

        if (num < num1)
        {
            PlayerScore = PlayerScore + 1;
            Console.WriteLine("you won this round");
            Console.WriteLine("The score is now-You: " + PlayerScore + " rival: " + Rivalscore);
            Console.WriteLine("press any key to contuine...");
        }
        if (num > num1)
        {
            Rivalscore = Rivalscore + 1;
            Console.WriteLine("Rival won this round");
            Console.WriteLine("The score in now-You " + PlayerScore + " Rival :" + Rivalscore);
            Console.WriteLine("press any key to contuine...");
        }
        if (num == num1)
        {
            Console.WriteLine("The round is a draw");
            Console.WriteLine("The score is now-You:" + PlayerScore + "rival:" + Rivalscore);
            Console.WriteLine("press any key to contuine...");
        }

        }
        Console.ReadKey();
        End();
        
    }
    public static void End()
    {
        Console.WriteLine();
        Console.WriteLine("Game over");
        Console.WriteLine("The score is now-You:" + PlayerScore + "rival:" + Rivalscore);
        if(PlayerScore>Rivalscore)
        {
            Console.WriteLine("You Won!");
            
        }
        if(PlayerScore<Rivalscore)
        {
            Console.WriteLine("You Lost!");
        }
        if(PlayerScore==Rivalscore)
        {
            Console.WriteLine("The game is a draw");
        }
        Console.WriteLine("Press any key to exit ");
        Console.ReadKey();

    }

}
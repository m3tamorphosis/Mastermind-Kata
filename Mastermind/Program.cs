using Mastermind;

internal class Program
{
    private static void Main(string[] args)
    {
        Game game = new Game();
        var code = game.GenerateCode();
        foreach(var x in game.colours)
        {
            Console.WriteLine("{0}. {1}", x.Key, x.Value);
        }
        bool win = false;
        for(int i = 0; i< 10; i++)
        {
            Console.WriteLine("Input guess");
            string input = Console.ReadLine();
            int[] result = game.Check(input, code);
            Console.WriteLine("{0} well placed\n{1} misplaced", result[0], result[1]);
            if (result[0].Equals(6))
            {
                Console.WriteLine("You got it correct, the answer was");
                win = true;
                foreach (var x in code)
                {
                    Console.WriteLine(x);
                }
                break;
            }
        }
        if(win== false)
        {
            Console.WriteLine("You did not guess the correct colour sequence within 10 tries :(");
            foreach (var x in code)
            {
                Console.WriteLine(x);
            }
        }








        Console.ReadLine();
    }
}
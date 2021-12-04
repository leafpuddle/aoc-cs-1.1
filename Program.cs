using System;

class Program
{
    static void Main(string[] args)
    {
        string input = System.IO.File.ReadAllText("./input.txt");
        string[] inputs = input.Split(
            new string[] { Environment.NewLine },
            StringSplitOptions.None
        );

        int result = 0;

        for(int i = 0; i < inputs.Length; i++)
        {
            if( i == 0 ) continue;

            int.TryParse(inputs[i], out int a);
            int.TryParse(inputs[i - 1], out int b);

            if( a > b ) result++;
        }

        Console.WriteLine("Result: " + result);
        Console.ReadKey();
    }
}

using System;

class Program
{
    static bool AreParenthesesBalanced(string input)
    {
        int countOpen = 0;
        int countClosed = 0;
        int validated = 0;
        

        if (input != null)
        {
            foreach (char character in input)
            {
                if (character == '(')
                {
                    countOpen++;
                }
                else if (character == ')')
                {
                    countClosed++;
                }
            }
            if(countOpen == countClosed)
            {
                validated++;
            }
            countOpen = 0;
            countClosed = 0;



            foreach (char character in input)
            {
                if (character == '[')
                {
                    countOpen++;
                }
                else if (character == ']')
                {
                    countClosed++;
                }
            }
            if (countOpen == countClosed)
            {
                validated++;
            }
            countOpen = 0;
            countClosed = 0;



            foreach (char character in input)
            {
                if (character == '{')
                {
                    countOpen++;
                }
                else if (character == '}')
                {
                    countClosed++;
                }
            }
            if (countOpen == countClosed)
            {
                validated++;
                countOpen = 0;
                countClosed = 0;
            }
            countOpen = 0;
            countClosed = 0;

        }

        return validated == 3;
    }




    static void Main(string[] args)
    {
        Console.Write("Digite a sequência de parênteses: ");
        string input = Console.ReadLine();

        bool areBalanced = AreParenthesesBalanced(input);
        Console.WriteLine($"A sequência de parênteses '{input}' está balanceada: {areBalanced}");
    }
}


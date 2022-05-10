using System;

namespace InputCollectionAndValidation
{
    public class inAndOut
    {
        public string notNull(string input)
        {
            bool invalid = true;
            while (invalid)
            {
                if (input is null || input == "")
                {
                    Console.WriteLine("Your input was empty, try again");
                    input = Console.ReadLine();
                }
                else invalid = false; 
            }
            return input;
        }

        public string isString(string input)
        {
            input = notNull(input);
            return input;
        }

        public int isInt(string input)
        {
            bool valid = false;
            int output = 0;
            while (!valid)
            {
                input = notNull(input);
                valid = int.TryParse(input, out output);
                if (!valid)
                {
                    Console.WriteLine("Your input was not a whole number, try again");
                    input = Console.ReadLine();
                }
            }
            return output;
        }

        public double isDouble(string input)
        {
            bool valid = false;
            double output = 0;
            while (!valid)
            {
                valid = double.TryParse(input, out output);
                input = notNull(input);
                if (!valid)
                {
                    Console.WriteLine("Your input was not a number, try again");
                    input = Console.ReadLine();
                }
            }
            return output;
        }

        public char isChar(string input)
        {
            bool valid = false;
            char output = '_';
            while (!valid)
            {
                valid = char.TryParse(input, out output);
                input = notNull(input);
                if (!valid)
                {
                    Console.WriteLine("Your input was not a single character, try again");
                    input = Console.ReadLine();
                }
            }
            return output;
        }
    }
}

namespace function_Hex_10B_26_27
{
    internal class Program
    {
        static void validStatments(bool a, bool b, bool c) //subroutine to tell the user which criteria they have met
        {
            Console.WriteLine($"The code starts with a #: {a}");
            Console.WriteLine($"The length of the code is valid: {b}");
            Console.WriteLine($"All charecters in the hexcode are valid: {c}");
        }
        static bool ValidChars (string code, char [] hexCodes)
        {
            bool valid = true;
            for(int i = 1; i < code.Length; i++)
            {
                bool LetterCheck = false;
                for (int j=0;j< hexCodes.Length; j++)
                {
                    if (code[i] == hexCodes[j])
                    {
                        LetterCheck = true;
                    }
                }
                if (LetterCheck == false)
                {
                    valid = false;
                }
            }
            return valid;
        }
        static bool LengthChecker(string code)
        {
            //bool test = false;
            //if(code.Length == 7)
            //{
            //    test = true;
            //}
            //return test;
            if (code.Length == 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool HashChecker(string code)
        {
            if (code[0] == '#')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int valueFinder(char hex, char[] hexadecimal) //Mark E,Mark N
        {
            int position = 0;
            for (int i = 0; i < hexadecimal.Length; i++)//Mark O
            {
                if (hex == hexadecimal[i])
                {
                    position = i;
                }
            }
            return position;
        }
        static int[] RGB(string hex, char[] hexadecimal)
        {
            int[] RGBValues = new int[3];
            Console.WriteLine($"You entered {hex} as your colour code");
            RGBValues[0] = (valueFinder(hex[1], hexadecimal) * 16) + valueFinder(hex[2], hexadecimal);
            RGBValues[1] = (valueFinder(hex[3], hexadecimal) * 16) + valueFinder(hex[4], hexadecimal);
            RGBValues[2] = (valueFinder(hex[5], hexadecimal) * 16) + valueFinder(hex[6], hexadecimal);
            return RGBValues;
        }
        static void Main(string[] args)
        {
            char[] hexadecimal = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            Console.WriteLine("Please enter a hex code for a colour\nThe code must start with a #\nThe number code after the # must be 6 numbers in length");
            string Hexcode = Console.ReadLine().ToUpper();
            bool hash = HashChecker(Hexcode), length = LengthChecker(Hexcode), chars = ValidChars(Hexcode, hexadecimal);
            while (!hash || !length || !chars)
            {
                validStatments(hash, length, chars);
                Console.WriteLine("Invalid hex code\nPlease enter a hex code for a colour\nThe code must start with a #\nThe number code after the # must be 6 numbers in length");
                Hexcode = Console.ReadLine().ToUpper();
                hash = HashChecker(Hexcode); 
                length = LengthChecker(Hexcode);
                chars = ValidChars(Hexcode, hexadecimal);
            }
            int[] Values =  RGB(Hexcode, hexadecimal);
            Console.WriteLine($"The hexcode you entered is equal to the values of Red - {Values[0]}, Grren - {Values[1]}, Blue - {Values[2]}");

        }
    }
}

namespace function_Hex_10B_26_27
{
    internal class Program
    {
        char[] hexCodes = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E','F' };
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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

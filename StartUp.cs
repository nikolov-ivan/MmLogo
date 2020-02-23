namespace MmLogo
{
    using System;
    using System.Text;
    public class StartUp
    {
        public static void Main()
        {

            while (true)
            {
                string input = Console.ReadLine();
                if (!IsValidInput(input))
                {
                    Console.WriteLine("Please input a odd number between 2 and 10 000");
                    continue;
                }
                int width = int.Parse(input);
                var logo = new MmLogoDrawer();
                var resultLogo = logo.Draw(width);
                Console.WriteLine(resultLogo);
                break;
            }

        }
        public static bool IsValidInput(string input)
        {
            int number;
            bool isNumber = int.TryParse(input, out number);

            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            if (!isNumber)
            {
                return false;
            }
            if (number < 3 || number > 9999)
            {
                return false;
            }
            if (number % 2 == 0)
            {
                return false;
            }
            return true;
        }
    }
}

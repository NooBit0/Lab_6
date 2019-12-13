using System;

namespace Laba7
{
    public static class InputExtensions
    {
        public static int InputVariable()
        {
            int tempInt;
            while (!int.TryParse(Console.ReadLine(), out tempInt) || tempInt < 0)
            {
            }

            return tempInt;
        }

        public static int InputIntVariable(int rightBorder)
        {
            int tempInt;
            while (!int.TryParse(Console.ReadLine(), out tempInt) || tempInt < 1 || tempInt > rightBorder)
            {
            }

            return tempInt;
        }

        public static string InputStringVariable()
        {
            string tempString;

            try
            {
                tempString = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(tempString))
                {
                    tempString = "noName";
                    throw new Exception("Exception: invalid input!");
                }
            }
            catch (Exception ex)
            {
                tempString = null;
                Console.WriteLine(ex.Message);
            }

            return tempString;
        }
    }
}

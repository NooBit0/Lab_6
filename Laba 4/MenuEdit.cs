using System;

namespace Laba7
{
    internal static class MenuEdit
    {
        private const int RightBorder = 6;

        public static int SelectItemToEdit(Collection contents)
        {
            Console.WriteLine("\nSelect index to edit:");
            Console.WriteLine(contents);

            return InputExtensions.InputIntVariable(contents.Items.Length) - 1;
        }

        public static int SelectFildsToEdit()
        {
            ShowEditList();
            return InputExtensions.InputIntVariable(RightBorder);
        }

        public static void ShowEditList()
        {
            Console.WriteLine("\nEdit menu:");
            Console.WriteLine("1. Edit name culture");
            Console.WriteLine("2. Edit name fertilizer");
            Console.WriteLine("3. Edit application rate");
            Console.WriteLine("4. Edit date entry (0-12)");
            Console.WriteLine("5. Edit content in Volume");
            Console.WriteLine("6. Back");
            Console.Write("Endter:");
        }
    }
}

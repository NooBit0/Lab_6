using System;

namespace Laba7
{
    internal static class EditItem
    {
        private const int RightBorder = 12;

        public static void EditFilds(this Collection collection, Entryfield choice)
        {
            int index = MenuEdit.SelectItemToEdit(collection);
            switch (choice)
            {
                case Entryfield.CultureName:
                    Console.WriteLine("Input name culture");
                    collection.Items[index].CultureName = InputExtensions.InputStringVariable();
                    break;
                case Entryfield.FertilizerName:
                    Console.WriteLine("Input name fertilizer");
                    collection.Items[index].FertilizerName = InputExtensions.InputStringVariable();
                    break;
                case Entryfield.ApplicationRate:
                    Console.WriteLine("Input application rate");
                    collection.Items[index].ApplicationRate = InputExtensions.InputVariable();
                    break;
                case Entryfield.EntryDate:
                    Console.WriteLine("Input date entry (0-12)");
                    collection.Items[index].EntryDate = InputExtensions.InputIntVariable(RightBorder);
                    break;
                case Entryfield.ContentInVolume:
                    Console.WriteLine("Input content in Volume");
                    collection.Items[index].ContentInVolume = InputExtensions.InputVariable();
                    break;
                case Entryfield.Back:
                    break;
            }
        }
    }
}

using System;

namespace Laba7
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Collection:");
            var collection = new Collection(FileExtensions.GetFromFile());
            Console.WriteLine(collection);

            Console.WriteLine("\nSearch in collection on the field application rate: ");
            foreach (var item in collection.Get(InputExtensions.InputVariable()))
            {
                Console.WriteLine(item);
            }

            collection.Sort();

            Console.WriteLine("\nInput namber to input");
            int index = InputExtensions.InputIntVariable(collection.Items.Length) - 1;
            collection.Add(CreateItem.CreateNewItem(), index);
            Console.WriteLine(collection);

            Console.WriteLine("\nInput namber to remove item");
            collection.Remove(InputExtensions.InputIntVariable(collection.Items.Length) - 1);
            Console.WriteLine(collection);

            collection.EditFilds((Entryfield)MenuEdit.SelectFildsToEdit());
            Console.WriteLine(collection);

            string filePath = @"..\..\..\FileExtensions\collection.csv";
            FileExtensions.RecordToFile(collection.Items, filePath);
        }
    }
}

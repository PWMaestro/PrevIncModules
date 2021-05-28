using System;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 24. Table." + Environment.NewLine);
            var table = new Table<TableRow>();
            table.AddColumnConfig("Name", c => c.Name);
            table.AddColumnConfig("Surname", c => c.Surname);
            table.AddColumnConfig("Age", c => c.Age);
            table.AddRow(new TableRow { Name = "Andrey", Surname = "Kakashin", Age = "19" });
            table.AddRow(new TableRow { Name = "Liza", Surname = "Kakashin", Age = "19" });
            Console.WriteLine(table);

            Console.WriteLine("Task 25. Products." + Environment.NewLine);
            var rackBread1 = new Rack<Bread>();
            var rackBread2 = new Rack<Bread>();
            var rackBread3 = new Rack<Bread>();
            var rackMilk = new Rack<Milk>();
            var rackPasta = new Rack<Pasta>();
            var rackPoridge = new Rack<Porridge>();

            for (int i = 0; i < 30; i++)
            {
                rackBread1.AddProduct(new Bread());
            }
            for (int i = 0; i < 40; i++)
            {
                rackBread2.AddProduct(new Bread());
            }
            for (int i = 0; i < 40; i++)
            {
                rackBread3.AddProduct(new Bread());
            }
            for (int i = 0; i < 40; i++)
            {
                rackMilk.AddProduct(new Milk());
            }
            for (int i = 0; i < 45; i++)
            {
                rackMilk.AddProduct(new Milk());
            }
            for (int i = 0; i < 70; i++)
            {
                rackPasta.AddProduct(new Pasta());
            }
            for (int i = 0; i < 60; i++)
            {
                rackPoridge.AddProduct(new Porridge());
            }

            Console.WriteLine("Bread: " + Rack<Bread>.numberOfProducts);
            Console.WriteLine("Milk: " + Rack<Milk>.numberOfProducts);
            Console.WriteLine("Pasta: " + Rack<Pasta>.numberOfProducts);
            Console.WriteLine("Porridge: " + Rack<Porridge>.numberOfProducts);
            Console.WriteLine();

            Console.WriteLine("Task 25. IRepository." + Environment.NewLine);
            var libruary = new Repository<Book>();
            libruary.Create(new Book(0, "Simple C#", 1023));
            libruary.Create(new Book(2, "What an interesting book!", 15));
            libruary.Create(new Book(3, "Nothing interesting", 10));

            var bookList = libruary.GetItemsList();
            foreach (var item in bookList)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();

            libruary.Delete(3);
            foreach (var item in bookList)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}

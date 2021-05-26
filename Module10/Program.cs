using System;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new Table<TableRow>();
            table.AddColumnConfig("Name", c => c.Name);
            table.AddColumnConfig("Surname", c => c.Surname);
            table.AddColumnConfig("Age", c => c.Age);
            table.AddRow(new TableRow { Name = "Andrey", Surname = "Kakashin", Age = "19"});
            table.AddRow(new TableRow { Name = "Liza", Surname = "Kakashin", Age = "19"});
            Console.WriteLine(table);
        }
    }
}

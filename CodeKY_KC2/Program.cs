using System.Text.Json;

namespace CodeKY_KC2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How many records do you want to add? ");
			var numberOfRecords = int.Parse(Console.ReadLine());

			var recordList = new List<Child>();
			for (int i = 0; i < numberOfRecords; i++)
			{
				// In this loop, populate the object's properties using Console.ReadLine()
				var child = new Child();

				Console.WriteLine("Enter the child's name: ");
				child.childName = Console.ReadLine();

				Console.WriteLine("Enter the Parent's name: ");
				child.parentName = Console.ReadLine();

				recordList.Add(child);
			}

			// Print out the list of records using Console.WriteLine()
			foreach (var record in recordList) {
				Console.WriteLine(record);
			}
		}
	}
}
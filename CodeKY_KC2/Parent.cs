using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CodeKY_KC2
{
	public class Parent
	{
		public string parentName { get; set; }
		public override string ToString() => JsonSerializer.Serialize(this, new JsonSerializerOptions { IncludeFields = true });
		public virtual void AddName()
		{
			string userInput;
			do
			{
				Console.WriteLine("Enter the parent's name: ");
				userInput = Console.ReadLine();
				userInput = userInput.Trim();
			} while (string.IsNullOrEmpty(userInput));
			parentName = userInput;
		}
	}
}

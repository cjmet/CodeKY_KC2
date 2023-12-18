using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CodeKY_KC2
{
	public class Child : Parent
	{
		public string childName { get; set; }
		public override string ToString() => JsonSerializer.Serialize(this, new JsonSerializerOptions { IncludeFields = true });
		public override void AddName()
		{
			Console.WriteLine("Enter the child's name: ");
			childName = Console.ReadLine();
			base.AddName();
		}
	}
}
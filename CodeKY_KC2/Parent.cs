using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CodeKY_KC2
{
	public class Parent
	{
		public string parentName { get; set; }
		public override string ToString() => JsonSerializer.Serialize(this, new JsonSerializerOptions { IncludeFields = true });
	}
}

#nullable enable
using System.Collections.Generic;

namespace AutoBogus.Performance.Model
{
	public class Parent
	{
		public virtual Other? Other { get; set; } = default!;

		public virtual ICollection<Child> Children { get; set; } = default!;
	}
}
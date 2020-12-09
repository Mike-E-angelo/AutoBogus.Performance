using System.Collections.Generic;

namespace AutoBogus.Performance.Model
{
	public class Child
	{
		public virtual Parent Parent { get; set; } = default!;

		public virtual ICollection<Other> Items { get; set; } = default!;
	}
}
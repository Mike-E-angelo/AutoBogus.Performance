using System.Collections.Generic;

namespace AutoBogus.Performance.Model
{
	public class Other
	{
		public virtual Child Child { get; set; } = default!;

		public virtual ICollection<Item> Items { get; set; } = default!;
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBus
{
	public class Order : IEvent
	{
		public string Name { get; set; }
	}
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace EventBus
{
	public class MemoryMq
	{
		public static ConcurrentDictionary<string, IEvent> eventQueueDict { get; set; }
	}
}

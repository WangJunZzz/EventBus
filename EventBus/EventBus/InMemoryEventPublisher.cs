using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
	public class InMemoryEventPublisher : IEventPublisher
	{

		public Task Publish<TEvent>(TEvent e) where TEvent : IEvent
		{

			if (e == null) return Task.CompletedTask;
			if (MemoryMq.eventQueueDict == null)
			{
				MemoryMq.eventQueueDict = new ConcurrentDictionary<string, IEvent>();
			}
			MemoryMq.eventQueueDict.GetOrAdd(Guid.NewGuid().ToString(), e);
			return Task.CompletedTask;
		}
	}
}

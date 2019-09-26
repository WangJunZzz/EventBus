using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
	public class InMemoryEventSubscriber : IEventSubscriber
	{


		public Task Subscribe<TEvent, EH>() where TEvent : IEvent
			 where EH : class, IEventHandler, new()
		{
			EH state = new EH();
			Task.Run(() =>
			{
				while (true)
				{
					if (MemoryMq.eventQueueDict != null)
					{
						foreach (var item in MemoryMq.eventQueueDict)
						{
							state.Handle(item.Value as IEvent);
							IEvent o;
							MemoryMq.eventQueueDict.TryRemove(item.Key, out o);
						}
					}
				}
			});
			return Task.CompletedTask;
		}
	}
}

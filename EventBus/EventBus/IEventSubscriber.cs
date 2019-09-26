using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
	public interface IEventSubscriber
	{
		Task Subscribe<TEvent, EH>() where TEvent : IEvent where EH : class, IEventHandler, new();
	}
}

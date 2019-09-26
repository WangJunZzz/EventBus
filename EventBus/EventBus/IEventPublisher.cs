using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
	public interface IEventPublisher
	{
		Task Publish<TEvent>(TEvent e) where TEvent : IEvent;
	}
}

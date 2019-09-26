using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
	public class EventHandler : IEventHandler
	{
		public Task Handle(IEvent e)
		{
			switch (e)
			{
				case Order value:
					Console.WriteLine(value.Name);
					break;
			}

			return Task.CompletedTask;
		}
	}
}

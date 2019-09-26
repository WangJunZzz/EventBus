using System;

namespace EventBus
{
	class Program
	{
		static void Main(string[] args)
		{
			var pub = new InMemoryEventPublisher();
			var sub = new InMemoryEventSubscriber();
			sub.Subscribe<Order, EventHandler>();
			var order = new Order();
			order.Name = "wangjunzzz";
			pub.Publish(order);
			Console.WriteLine("Hello World!");
			Console.ReadKey();
		}
	}
}

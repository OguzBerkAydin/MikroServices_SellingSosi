using EventBus.Base.Abstraction;
using EventBus.Test.Events.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Test.Events.EventHandlers
{
	public class OrderCreatedIntegrationEventHandler : IIntegrationEventHandler<OrderCreatedIntegrationEvent>
	{
		public Task Handle(OrderCreatedIntegrationEvent @event)
		{
			return Task.CompletedTask;
		}
	}
}

using MediaStore.Infrastructure.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaStore.Infrastructure.Messages
{
	public class TypeBasedMessageRoot : IMessageRoot
	{
		private readonly ConcurrentDictionary<Type, HashSet<object>> _eventToHandlersMap;

		public TypeBasedMessageRoot()
		{
			_eventToHandlersMap = new ConcurrentDictionary<Type, HashSet<object>>();
		}

		public void Subscribe<T>(IMessageHandler<T> handler)
		{
			var evntType = typeof(T);

			Subscribe(handler, evntType);
		}

		public void Subscribe<T>(IAsyncMessageHandler<T> handler)
		{
			var evntType = typeof(T);

			Subscribe(handler, evntType);
		}

		public void Unsubscribe<T>(IMessageHandler<T> handler)
		{
			var evntType = typeof(T);

			Unsubscribe(handler, evntType);
		}

		public void Unsubscribe<T>(IAsyncMessageHandler<T> handler)
		{
			var evntType = typeof(T);

			Unsubscribe(handler, evntType);
		}

		public void Raise<T>(T evnt)
		{
			var evntType = typeof(T);

			if (!_eventToHandlersMap.ContainsKey(evntType))
			{
				return;
			}

			var handlers = _eventToHandlersMap[evntType].ToList();

			foreach (var handler in handlers)
			{
				if (handler is IAsyncMessageHandler<T>)
				{
					(handler as IAsyncMessageHandler<T>).HandleAsync(evnt);

					continue;
				}

				(handler as IMessageHandler<T>)?.Handle(evnt);
			}
		}

		public async Task RaiseAsync<T>(T evnt)
		{
			var evntType = typeof(T);

			if (!_eventToHandlersMap.ContainsKey(evntType))
			{
				return;
			}

			var handlers = _eventToHandlersMap[evntType].ToList();

			foreach (var handler in handlers)
			{
				if (handler is IAsyncMessageHandler<T>)
				{
					await (handler as IAsyncMessageHandler<T>).HandleAsync(evnt);

					continue;
				}

				(handler as IMessageHandler<T>)?.Handle(evnt);
			}
		}

		private void Unsubscribe(object handler, Type evntType)
		{
			if (!_eventToHandlersMap.ContainsKey(evntType))
			{
				return;
			}

			_eventToHandlersMap[evntType].RemoveWhere(t => t == handler);
		}

		private void Subscribe(object handler, Type eventType)
		{
			if (!_eventToHandlersMap.ContainsKey(eventType))
			{
				_eventToHandlersMap.AddOrUpdate(eventType, new HashSet<object>(), (key, value) => value);
			}

			if (!_eventToHandlersMap[eventType].Contains(handler))
			{
				_eventToHandlersMap[eventType].Add(handler);
			}
		}
	}
}

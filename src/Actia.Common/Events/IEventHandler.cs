using System;
using System.Collections.Generic;
using System.Text;

namespace Actia.Common.Events
{
    public interface IEventHandler<in T> where T : IEvent
    {
        Task HandleAsync(T @event);
    }
}

using ArquiteturaDDD.Domain.Core.Events;
using System.Threading.Tasks;

namespace ArquiteturaDDD.Domain.Core.EventBus
{
    public interface IMediatorHandler
    {
       // Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
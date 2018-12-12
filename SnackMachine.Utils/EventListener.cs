using NHibernate.Event;
using SnackMachines.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnackMachine.Utils
{
    internal class EventListener :
        IPostInsertEventListener,
        IPostDeleteEventListener,
        IPostUpdateEventListener,
        IPostCollectionUpdateEventListener
    {
        public void OnPostUpdate(PostUpdateEvent ev)
        {
            DispatchEvents(ev.Entity as Entity);
        }

        public void OnPostDelete(PostDeleteEvent ev)
        {
            DispatchEvents(ev.Entity as Entity);
        }

        public void OnPostInsert(PostInsertEvent ev)
        {
            DispatchEvents(ev.Entity as Entity);
        }

        public void OnPostUpdateCollection(PostCollectionUpdateEvent ev)
        {
            DispatchEvents(ev.AffectedOwnerOrNull as Entity);
        }

        private void DispatchEvents(Entity entity)
        {
            if (entity == null)
                return;

            foreach (IDomainEvent domainEvent in entity.DomainEvents)
            {
                DomainEvents.Dispatch(domainEvent);
            }

            entity.ClearEvents();
        }

        public Task OnPostInsertAsync(PostInsertEvent @event, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task OnPostDeleteAsync(PostDeleteEvent @event, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task OnPostUpdateAsync(PostUpdateEvent @event, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task OnPostUpdateCollectionAsync(PostCollectionUpdateEvent @event, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

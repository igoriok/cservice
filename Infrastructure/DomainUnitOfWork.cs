using System;
using System.Data.Objects;
using Domain.Models;

namespace Infrastructure
{
    public class DomainUnitOfWork : ObjectContext, IDomainUnitOfWork
    {
        public const string ConnectionString = "CService";
        public const string ContainerName = "DataModelContainer";

        public DomainUnitOfWork()
            : base(ConnectionString, ContainerName)
        {
            ContextOptions.ProxyCreationEnabled = true;
            ContextOptions.LazyLoadingEnabled = true;
        }

        public IObjectSet<Client> Clients
        {
            get { return CreateObjectSet<Client>(); }
        }

        public void Commit()
        {
            SaveChanges();
        }

        public void Rollback()
        {
            Rollback();
        }
    }
}

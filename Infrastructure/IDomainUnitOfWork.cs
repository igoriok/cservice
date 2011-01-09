using System;

using Domain;
using System.Data.Objects;
using Domain.Models;

namespace Infrastructure
{
    public interface IDomainUnitOfWork : IUnitOfWork
    {
        IObjectSet<Client> Clients { get; }
    }
}

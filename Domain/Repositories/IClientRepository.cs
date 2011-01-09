using System;

using Domain.Models;

namespace Domain.Repositories
{
    public interface IClientRepository : IRepository<Client>
    {
        Client GetById(int id);
        User GetClientUser(Client client);
    }
}

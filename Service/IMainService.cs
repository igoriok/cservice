using System;
using System.ServiceModel;
using Domain.Models;

namespace Service
{
    [ServiceContract]
    public class IMainService
    {
        [OperationContract]
        void AddClient(Client client);

        [OperationContract]
        void UpdateClient(Client client);

        [OperationContract]
        void SetUserForClient(Client client, User user);
    }
}

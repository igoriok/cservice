using System;
using Domain.Models;

namespace Domain.Repositories
{
    public interface IReportRepository
    {
        Report GetById(int id);
    }
}

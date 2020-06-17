using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePizza.Data.Repository.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        void Save();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopManager.Common.Entities;

namespace WorkshopManager.CoreClient.Abstractions.WS
{
    public interface IWSEmployeesManager
    {
        IEnumerable<WSEmployee> GetAll();
        WSEmployee Get(int id);
        void Add(WSEmployee employee);
        void Update(WSEmployee employee);
        void Delete(int id);
    }
}

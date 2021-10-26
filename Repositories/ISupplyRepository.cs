using buildxact_supplies.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace buildxact_supplies.Repositories
{
    public interface ISupplyRepository
    {
        Task<IEnumerable<Supply>> GetFromFile(string filePath);
        Task<IEnumerable<Supply>> GetAll();
    }
}

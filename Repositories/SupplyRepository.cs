using buildxact_supplies.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace buildxact_supplies.Repositories
{
    public class SupplyRepository : ISupplyRepository
    {
        public Task<IEnumerable<Supply>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Supply>> GetFromFile(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}

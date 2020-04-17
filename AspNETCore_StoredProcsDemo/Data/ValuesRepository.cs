using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNETCore_StoredProcsDemo.Models;

namespace AspNETCore_StoredProcsDemo.Data
{
    public class ValuesRepository
    {
        public Task<List<Value>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Value> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Insert (Value value)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByID(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

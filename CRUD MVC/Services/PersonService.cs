using CRUD_MVC.Contracts;
using CRUD_MVC.Models.Enties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CRUD_MVC.Services
{
    public class PersonService : IPersonService
    {
        public async Task<List<PersonEntity>> GetPersons()
        {
            throw new NotImplementedException();
        }
    }
}
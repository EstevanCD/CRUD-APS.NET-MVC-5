using CRUD_MVC.Models.Enties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC.Contracts
{
    public interface IPersonService
    {
        Task<List<PersonEntity>> GetPersons();
    }
}

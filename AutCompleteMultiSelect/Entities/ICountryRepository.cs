using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutCompleteMultiSelect.Models;

namespace AutCompleteMultiSelect.Entities
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAll();
        IEnumerable<CountryModel> GetCountryModelList(string searchTerm);

        void Dispose();
    }
}

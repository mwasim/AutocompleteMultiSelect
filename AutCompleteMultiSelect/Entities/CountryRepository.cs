using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutCompleteMultiSelect.Models;

namespace AutCompleteMultiSelect.Entities
{
    public class CountryRepository : IDisposable, ICountryRepository
    {
        private DBEntities _db = new DBEntities();

        public IEnumerable<Country> GetAll()
        {
            return _db.Countries.OrderBy(x => x.Name).ToList();
        }

        public IEnumerable<CountryModel> GetCountryModelList(string searchTerm)
        {
            var items = _db.Countries.Where(x => x.Name.StartsWith(searchTerm)).OrderBy(x => x.Name).Select(x => new CountryModel
            {
                value = x.Id,
                text = x.Name
            }).ToList();

            return items;
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_db != null)
                {
                    _db.Dispose();
                    _db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

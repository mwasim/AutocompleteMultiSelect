using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using AutCompleteMultiSelect.Entities;
using AutCompleteMultiSelect.Models;

namespace AutCompleteMultiSelect.Controllers
{
    public class CountriesController : ApiController
    {
        private ICountryRepository _repository;

        public CountriesController(ICountryRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Country> Get()
        {
            return _repository.GetAll();
        }

        public IEnumerable<CountryModel> Get(string search)
        {
            return _repository.GetCountryModelList(search);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_repository != null)
                {
                    _repository.Dispose();
                    _repository = null;
                }
            }

            base.Dispose(disposing);
        }
    }
}

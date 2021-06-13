using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class SehirManager : ISehirService
    {
        private ISehirDal _sehirDal;

        public SehirManager(ISehirDal sehirDal)
        {
            _sehirDal = sehirDal;
        }

        public IDataResult<Sehir> GetById(int id)
        {
            return new SuccessDataResult<Sehir>(_sehirDal.Get(p => p.Id == id));
        }


        public IDataResult<List<Sehir>> GetList()
        {
            return new SuccessDataResult<List<Sehir>>(_sehirDal.GetList().ToList());
        }
    }
}

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
    public class IlceManager : IIlceService
    {
        private IIlceDal _ilceDal;

        public IlceManager(IIlceDal ilceDal)
        {
            _ilceDal = ilceDal;
        }

        public IDataResult<Ilce> GetById(int id)
        {
            return new SuccessDataResult<Ilce>(_ilceDal.Get(p => p.Id == id));
        }

        public IDataResult<Ilce> GetBySehirId(int sehirId)
        {
            return new SuccessDataResult<Ilce>(_ilceDal.Get(p => p.SehirId == sehirId));
        }

        public IDataResult<List<Ilce>> GetList()
        {
            return new SuccessDataResult<List<Ilce>>(_ilceDal.GetList().ToList());
        }
    }
}

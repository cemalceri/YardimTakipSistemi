using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class VatandasManager : IVatandasService
    {
        private IVatandasDal _vatandasDal;

        public VatandasManager(IVatandasDal vatandasDal)
        {
            _vatandasDal = vatandasDal;
        }
        public IResult Add(Vatandas vatandas)
        {
            _vatandasDal.Add(vatandas);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(int id )
        {
            var vatandas = GetById(id).Data;
            _vatandasDal.Delete(vatandas);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Vatandas> GetById(int id)
        {
            return new SuccessDataResult<Vatandas>(_vatandasDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Vatandas>> GetList()
        {
            return new SuccessDataResult<List<Vatandas>>(_vatandasDal.GetList().ToList());
        }

        public IResult TransactionalOperation(Vatandas vatandas)
        {
            _vatandasDal.Update(vatandas);
            _vatandasDal.Add(vatandas);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Update(Vatandas vatandas)
        {
            _vatandasDal.Update(vatandas);
            return new SuccessResult(Messages.Updated);
        }

    }
}

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
    public class YardimManager : IYardimService
    {
        private IYardimDal _yardimDal;

        public YardimManager(IYardimDal yardimDal)
        {
            _yardimDal = yardimDal;
        }
        public IResult Add(Yardim yardim)
        {
            _yardimDal.Add(yardim);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(int id)
        {
            var yardim = GetById(id).Data;
            _yardimDal.Delete(yardim);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Yardim> GetById(int id)
        {
            return new SuccessDataResult<Yardim>(_yardimDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Yardim>> GetList()
        {
            return new SuccessDataResult<List<Yardim>>(_yardimDal.GetList().ToList());
        }

        public IResult TransactionalOperation(Yardim yardim)
        {
            _yardimDal.Update(yardim);
            _yardimDal.Add(yardim);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Update(Yardim yardim)
        {
            _yardimDal.Update(yardim);
            return new SuccessResult(Messages.Updated);
        }

    }
}

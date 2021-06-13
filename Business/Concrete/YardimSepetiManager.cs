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
    public class YardimSepetiManager : IYardimSepetiService
    {
        private IYardimSepetiDal _yardimSepetiDal;

        public YardimSepetiManager(IYardimSepetiDal yardimSepetiDal)
        {
            _yardimSepetiDal = yardimSepetiDal;
        }
        public IResult Add(YardimSepeti yardimSepeti)
        {
            _yardimSepetiDal.Add(yardimSepeti);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(int id)
        {
            var yardimSepeti = GetById(id).Data;
            _yardimSepetiDal.Delete(yardimSepeti);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<YardimSepeti> GetById(int id)
        {
            return new SuccessDataResult<YardimSepeti>(_yardimSepetiDal.Get(p => p.Id == id));
        }

        public IDataResult<List<YardimSepeti>> GetList()
        {
            return new SuccessDataResult<List<YardimSepeti>>(_yardimSepetiDal.GetList().ToList());
        }

        public IResult TransactionalOperation(YardimSepeti yardimSepeti)
        {
            _yardimSepetiDal.Update(yardimSepeti);
            _yardimSepetiDal.Add(yardimSepeti);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Update(YardimSepeti yardimSepeti)
        {
            _yardimSepetiDal.Update(yardimSepeti);
            return new SuccessResult(Messages.Updated);
        }

    }
}

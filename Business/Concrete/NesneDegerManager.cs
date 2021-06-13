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
    public class NesneDegerManager : INesneDegerService
    {
        INesneDegerDal _nesnedegerDal;

        public NesneDegerManager(INesneDegerDal nesnedegerDal)
        {
            _nesnedegerDal = nesnedegerDal;
        }

        public IResult Add(NesneDeger nesneDeger)
        {
            _nesnedegerDal.Add(nesneDeger);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(int id)
        {
            var nesneDeger = GetById(id).Data;
            _nesnedegerDal.Delete(nesneDeger);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<NesneDeger> GetById(int id)
        {
            return new SuccessDataResult<NesneDeger>(_nesnedegerDal.Get(p => p.Id == id));
        }

        public IDataResult<NesneDeger> GetByNesneTipId(int nesneTipId)
        {
            return new SuccessDataResult<NesneDeger>(_nesnedegerDal.Get(p => p.NesneTipId == nesneTipId));
        }

        public IDataResult<List<NesneDeger>> GetList()
        {
            return new SuccessDataResult<List<NesneDeger>>(_nesnedegerDal.GetList().ToList());
        }

        public IResult TransactionalOperation(NesneDeger nesneDeger)
        {
            _nesnedegerDal.Update(nesneDeger);
            _nesnedegerDal.Add(nesneDeger);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Update(NesneDeger nesneDeger)
        {
            _nesnedegerDal.Update(nesneDeger);
            return new SuccessResult(Messages.Updated);
        }
    }
}

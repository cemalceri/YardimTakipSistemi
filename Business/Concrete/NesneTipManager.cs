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
    public class NesneTipManager : INesneTipService
    {
        INesneTipDal _nesneTipDal;

        public NesneTipManager(INesneTipDal nesneTipDal)
        {
            _nesneTipDal = nesneTipDal;
        }

        public IResult Add(NesneTip nesneTip)
        {
            _nesneTipDal.Add(nesneTip);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(int id)
        {
            var nesneTip = GetById(id).Data;
            _nesneTipDal.Delete(nesneTip);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<NesneTip> GetById(int id)
        {
            return new SuccessDataResult<NesneTip>(_nesneTipDal.Get(p => p.Id == id));
        }


        public IDataResult<List<NesneTip>> GetList()
        {
            return new SuccessDataResult<List<NesneTip>>(_nesneTipDal.GetList().ToList());
        }

        public IResult Update(NesneTip NesneTip)
        {
            _nesneTipDal.Update(NesneTip);
            return new SuccessResult(Messages.Updated);
        }
    }
}

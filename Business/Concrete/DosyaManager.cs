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
    public class DosyaManager : IDosyaService
    {
        private IDosyaDal _dosyaDal;

        public DosyaManager(IDosyaDal dosyaDal)
        {
            _dosyaDal = dosyaDal;
        }
        public IResult Add(Dosya dosya)
        {
            _dosyaDal.Add(dosya);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(int id)
        {
            var dosya = GetById(id).Data;
            _dosyaDal.Delete(dosya);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Dosya> GetById(int id)
        {
            return new SuccessDataResult<Dosya>(_dosyaDal.Get(p => p.Id == id));
        }

        public IDataResult<Dosya> GetByUniqId(string uniqId)
        {
            return new SuccessDataResult<Dosya>(_dosyaDal.Get(p => p.UniqId == uniqId));
        }

        public IDataResult<List<Dosya>> GetList()
        {
            return new SuccessDataResult<List<Dosya>>(_dosyaDal.GetList().ToList());
        }

        public IResult TransactionalOperation(Dosya dosya)
        {
            _dosyaDal.Update(dosya);
            _dosyaDal.Add(dosya);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Update(Dosya dosya)
        {
            _dosyaDal.Update(dosya);
            return new SuccessResult(Messages.Updated);
        }

    }
}

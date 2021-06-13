using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public interface IYardimSepetiService
    {
        IDataResult<YardimSepeti> GetById(int id);
        IDataResult<List<YardimSepeti>> GetList();
        IResult Add(YardimSepeti yardimSepeti);
        IResult Delete(int id);
        IResult Update(YardimSepeti yardimSepeti);

        IResult TransactionalOperation(YardimSepeti yardimSepeti);
    }
}

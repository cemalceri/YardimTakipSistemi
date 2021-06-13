using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IYardimService
    {
        IDataResult<Yardim> GetById(int id);
        IDataResult<List<Yardim>> GetList();
        IResult Add(Yardim yardim);
        IResult Delete(int id);
        IResult Update(Yardim yardim);

        IResult TransactionalOperation(Yardim yardim);
    }
}

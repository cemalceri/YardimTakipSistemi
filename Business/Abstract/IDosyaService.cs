using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDosyaService
    {
        IDataResult<Dosya> GetById(int id);
        IDataResult<Dosya> GetByUniqId(string uniqId);
        IDataResult<List<Dosya>> GetList();
        IResult Add(Dosya dosya);
        IResult Delete(int id);
        IResult Update(Dosya dosya);

        IResult TransactionalOperation(Dosya dosya);
    }
}

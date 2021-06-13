using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IVatandasService
    {
        IDataResult<Vatandas> GetById(int id);
        IDataResult<List<Vatandas>> GetList();
        IResult Add(Vatandas vatandas);
        IResult Delete(int id);
        IResult Update(Vatandas vatandas);

        IResult TransactionalOperation(Vatandas vatandas);
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface INesneDegerService
    {
        IDataResult<NesneDeger> GetById(int id);
        IDataResult<NesneDeger> GetByNesneTipId(int nesneTipId);
        IDataResult<List<NesneDeger>> GetList();
        IResult Add(NesneDeger nesneDeger);
        IResult Delete(int id);
        IResult Update(NesneDeger nesneDeger);

        IResult TransactionalOperation(NesneDeger nesneDeger);
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface INesneTipService
    {
        IDataResult<NesneTip> GetById(int id);
        IDataResult<List<NesneTip>> GetList();
        IResult Add(NesneTip nesneTip);
        IResult Delete(int id);
        IResult Update(NesneTip nesneTip);
    }
}

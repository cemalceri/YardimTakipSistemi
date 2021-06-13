using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISehirService
    {
        IDataResult<Sehir> GetById(int id);
        IDataResult<List<Sehir>> GetList();
    }
}

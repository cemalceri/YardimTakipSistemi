using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IIlceService
    {
        IDataResult<Ilce> GetById(int id);
        IDataResult<Ilce> GetBySehirId(int sehirId);
        IDataResult<List<Ilce>> GetList();
    }
}

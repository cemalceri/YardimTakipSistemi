using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        IResult Add(User user);
        IResult Delete(int id);
        IResult Update(User user);
        User GetByMail(string email);
        IDataResult<User> GetById(int id);
        IDataResult<List<User>> GetList();
        
    }
}

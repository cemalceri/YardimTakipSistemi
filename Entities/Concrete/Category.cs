using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? EkleyenId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? EklemeTarihi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

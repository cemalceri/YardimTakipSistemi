using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public interface IEntity
    {
        int? EkleyenId { get; set; }
        DateTime? EklemeTarihi { get; set; }
    }
}

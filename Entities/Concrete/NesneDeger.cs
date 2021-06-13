using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class NesneDeger: IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Deger { get; set; }
        public int NesneTipId { get; set; }
        public string Bilgi { get; set; }
        public int SiraNo { get; set; }
        public int? EkleyenId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? EklemeTarihi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Yardim: IEntity
    {
        public int Id { get; set; }

        public string SıraNo { get; set; }
        public int VatandasId { get; set; }
        public int YardimSepetiId { get; set; }
        public int? Miktari { get; set; }
        public DateTime? VerildigiTarihi { get; set; }
        public string VerenKisi { get; set; }
        public string Aciklama { get; set; }
        public int? EkleyenId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? EklemeTarihi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

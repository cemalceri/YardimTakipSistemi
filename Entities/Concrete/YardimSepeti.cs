using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class YardimSepeti : IEntity
    {
        public int Id { get; set; }
        public int YardimTurId { get; set; }
        public int YardimCesitId { get; set; }
        public int Miktari { get; set; }
        public int? KalanMiktari { get; set; }
        public int? DagitilanKisiSayisi { get; set; }
        public string Aciklama { get; set; }
        public int? EkleyenId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? EklemeTarihi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

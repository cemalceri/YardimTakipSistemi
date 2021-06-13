using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Vatandas: IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public int SehirId { get; set; }
        public int IlceId { get; set; }
        public string Adres { get; set; }
        public string Referans { get; set; }
        public bool? EvKiraMi { get; set; }
        public bool? EvliMi { get; set; }
        public int? CocukSayisi { get; set; }
        public int? AylikGeliri { get; set; }
        public string Aciklama { get; set; }
        public int? EkleyenId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? EklemeTarihi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

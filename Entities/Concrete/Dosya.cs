using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Dosya :IEntity
    {
        public int Id { get; set; }
        public string UniqId { get; set; }
        public string Name { get; set; }
        public string ContentType  { get; set; }
        public long? Size { get; set; }
        public byte[] SizeSize { get; set; }
        public int? EkleyenId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? EklemeTarihi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

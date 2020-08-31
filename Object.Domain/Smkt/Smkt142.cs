using System;
using Volo.Abp.Domain.Entities;

namespace Object.Domain.Smkt
{
    public partial class Smkt142 : Entity
    {
        public string Jyh { get; set; }
        public string Bzdm { get; set; }
        public decimal Ysje { get; set; }
        public decimal Wzlje { get; set; }
        public DateTime? Jysj { get; set; }
        public string CompId { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { Jyh, Bzdm };
        }
    }
}
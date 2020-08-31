using System;
using Volo.Abp.Domain.Entities;

namespace Object.Domain.Smkt
{
    public class Smkt141 : Entity
    {
        public string Jyh { get; set; }
        public string Jyflag { get; set; }
        public int Sequ { get; set; }
        public DateTime Jysj { get; set; }
        public string Spdm { get; set; }
        public decimal Xsdj { get; set; }
        public decimal Xssl { get; set; }
        public decimal Ysje { get; set; }
        public decimal? Zkje { get; set; }
        public decimal? Yhje { get; set; }
        public decimal Ssje { get; set; }
        public string Flag { get; set; }
        public string Xsph { get; set; }
        public decimal? Jfbl { get; set; }
        public decimal? Zlyh { get; set; }
        public decimal? Hyyh { get; set; }
        public string Cxbz { get; set; }
        public string Yyydm { get; set; }
        public decimal? Abcx { get; set; }
        public decimal? Bsyh { get; set; }
        public decimal? Mzyh { get; set; }
        public decimal? Mmyh { get; set; }
        public string CompId { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { Jyh, Jyflag, Sequ, Spdm };
        }
    }
}
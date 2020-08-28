using System;
using Volo.Abp.Domain.Entities;

namespace Object.Domain.Smkt
{
    public class Info702 : Entity
    {
        public string Bzdm { get; set; }
        public string Bzmc { get; set; }
        public decimal Hl { get; set; }
        public string Bzlx { get; set; }
        public string Zlbz { get; set; }
        public string Dlzt { get; set; }
        public string Hotkey { get; set; }
        public string Bshbz { get; set; }
        public string Sqhbz { get; set; }
        public string Qtsybz { get; set; }
        public decimal Fkzxdw { get; set; }
        public decimal Fkzddw { get; set; }
        public string BzmcE { get; set; }
        public string Firstman { get; set; }
        public DateTime Firstdate { get; set; }
        public string Lastman { get; set; }
        public DateTime Lastdate { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { Bzdm };
        }
    }
}
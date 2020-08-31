using System;
using Volo.Abp.Domain.Entities;

namespace Object.Domain.Smkt
{
    public class Smkt140 : Entity
    {
        public string Jyh { get; set; }
        public DateTime Jysj { get; set; }
        public string Skjh { get; set; }
        public string Skydm { get; set; }
        public string Hybh { get; set; }
        public string Flag { get; set; }
        public decimal Zje { get; set; }
        public decimal Ssje { get; set; }
        public decimal? Zkje { get; set; }
        public decimal? Yhje { get; set; }
        public decimal? Xj { get; set; }
        public decimal? Zp { get; set; }
        public decimal? Xyk { get; set; }
        public decimal? Hyk { get; set; }
        public decimal? Yhxyk { get; set; }
        public string Yhxyklx { get; set; }
        public string Yyydm { get; set; }
        public decimal? Zlje { get; set; }
        public decimal? Je1 { get; set; }
        public decimal? Je2 { get; set; }
        public decimal? Je3 { get; set; }
        public decimal? Gnqje { get; set; }
        public DateTime? Clsj { get; set; }
        public decimal? Zlczje { get; set; }
        public string CompId { get; set; }
        public string YhxykNo { get; set; }
        public decimal? Zlyh { get; set; }
        public decimal? Hyyh { get; set; }
        public decimal? Fkfs1 { get; set; }
        public decimal? Fkfs2 { get; set; }
        public decimal? Fkfs3 { get; set; }
        public decimal? Fkfs4 { get; set; }
        public decimal? Fkfs5 { get; set; }
        public decimal? Fkfs6 { get; set; }
        public decimal? Fkfs7 { get; set; }
        public decimal? Fkfs8 { get; set; }
        public decimal? Lmkye { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { Jyh, Flag };
        }
    }
}
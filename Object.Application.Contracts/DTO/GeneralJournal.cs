using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Object.Application.Contracts.DTO
{
    public class GeneralJournal
    {
        public Jyhz jyhz { get; set; }

        public List<Jysp> jymx { get; set; }

        public List<Jyfs> fkmx { get; set; }
    }

    public class Jyhz
    {
        public string Jyh { get; set; }

        [Required]
        public DateTime Jysj { get; set; }

        [Required]
        public string Skjh { get; set; }

        [Required]
        public string Skydm { get; set; }

        [Required]
        public string Flag { get; set; }

        [Required]
        public decimal Zje { get; set; }

        [Required]
        public decimal Ssje { get; set; }

        [Required]
        public string CompId { get; set; }
    }

    public class Jysp
    {
        public string Jyh { get; set; }

        [Required]
        public string Jyflag { get; set; }

        [Required]
        public int Sequ { get; set; }

        [Required]
        public DateTime Jysj { get; set; }

        [Required]
        public string Spdm { get; set; }

        [Required]
        public decimal Xsdj { get; set; }

        [Required]
        public decimal Xssl { get; set; }

        [Required]
        public decimal Ysje { get; set; }

        [Required]
        public decimal Ssje { get; set; }

        [Required]
        public string Flag { get; set; }
    }

    public class Jyfs
    {
        public string Jyh { get; set; }

        [Required]
        public string Bzdm { get; set; }

        [Required]
        public decimal Ysje { get; set; }

        [Required]
        public decimal Wzlje { get; set; }

        [Required]
        public DateTime? Jysj { get; set; }
    }
}
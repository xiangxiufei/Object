using System;
using Volo.Abp.Domain.Entities;

namespace Object.Domain.Smkt
{
    public class Info223 : Entity
    {
        /// <summary>
        /// 门店代码
        /// </summary>
        public string CompId { get; set; }

        /// <summary>
        /// 商品代码
        /// </summary>
        public string Spdm { get; set; }

        /// <summary>
        /// 自带条码
        /// </summary>
        public string Zdtm { get; set; }

        /// <summary>
        /// 店内条码
        /// </summary>
        public string Sptm { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Bz { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string Firstman { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Firstdate { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string Lastman { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime Lastdate { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { CompId, Spdm, Sptm };
        }
    }
}
using System;
using Volo.Abp.Domain.Entities;

namespace Object.Domain.Smkt
{
    public class Info217 : Entity
    {
        /// <summary>
        /// 门店代码
        /// </summary>
        public string CompId { get; set; }

        /// <summary>
        /// 捆绑代码
        /// </summary>
        public string Kbdm { get; set; }

        /// <summary>
        /// 商品代码
        /// </summary>
        public string Spdm { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        public decimal Sj { get; set; }

        /// <summary>
        /// 会员售价
        /// </summary>
        public decimal Hysj { get; set; }

        /// <summary>
        /// 促销售价
        /// </summary>
        public decimal Cxsj { get; set; }

        /// <summary>
        /// 促销会员售价
        /// </summary>
        public decimal Cxhysj { get; set; }

        /// <summary>
        /// 捆绑售价
        /// </summary>
        public decimal Kbsl { get; set; }

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
            return new object[] { Kbdm, Spdm };
        }
    }
}
using System;
using Volo.Abp.Domain.Entities;

namespace Object.Domain.Smkt
{
    public class Info201 : Entity
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
        /// 含税进价
        /// </summary>
        public decimal Jj { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        public decimal Sj { get; set; }

        /// <summary>
        /// 会员售价
        /// </summary>
        public decimal Hysj { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        public decimal Zk { get; set; }

        /// <summary>
        /// 加价率
        /// </summary>
        public decimal Jjl { get; set; }

        /// <summary>
        /// 供货方折扣
        /// </summary>
        public decimal Ghfzk { get; set; }

        /// <summary>
        /// 配送价一
        /// </summary>
        public decimal Psj1 { get; set; }

        /// <summary>
        /// 配送价二
        /// </summary>
        public decimal Psj2 { get; set; }

        /// <summary>
        /// 配送价三
        /// </summary>
        public decimal Psj3 { get; set; }

        /// <summary>
        /// 促销含税进价
        /// </summary>
        public decimal Cxjj { get; set; }

        /// <summary>
        /// 促销售价
        /// </summary>
        public decimal Cxsj { get; set; }

        /// <summary>
        /// 促销会员售价
        /// </summary>
        public decimal Cxhysj { get; set; }

        /// <summary>
        /// 促销折扣
        /// </summary>
        public decimal Cxzk { get; set; }

        /// <summary>
        /// 促销进价起始时间
        /// </summary>
        public DateTime? Cxjjsj { get; set; }

        /// <summary>
        /// 促销进价终止时间
        /// </summary>
        public DateTime? Jjzzsj { get; set; }

        /// <summary>
        /// 促销售价起始时间
        /// </summary>
        public DateTime? Qssj { get; set; }

        /// <summary>
        /// 促销售价终止时间
        /// </summary>
        public DateTime? Zzsj { get; set; }

        /// <summary>
        /// Flag
        /// </summary>
        public string Flag { get; set; }

        /// <summary>
        /// 商品状态
        /// </summary>
        public string Spzt { get; set; }

        /// <summary>
        /// 传输原因
        /// </summary>
        public string TransReason { get; set; }

        /// <summary>
        /// 传输状态
        /// </summary>
        public string TransState { get; set; }

        /// <summary>
        /// 传输时间
        /// </summary>
        public DateTime? TransDate { get; set; }

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

        /// <summary>
        /// 积分比例
        /// </summary>
        public decimal Jfbl { get; set; }

        /// <summary>
        /// 历史促销进价起始时间
        /// </summary>
        public DateTime? Lsjjqs { get; set; }

        /// <summary>
        /// 历史促销进价终止时间
        /// </summary>
        public DateTime? Lsjjzz { get; set; }

        /// <summary>
        /// 历史促销售价起始时间
        /// </summary>
        public DateTime? Lsqssj { get; set; }

        /// <summary>
        /// 历史促销售价终止时间
        /// </summary>
        public DateTime? Lszzsj { get; set; }

        /// <summary>
        /// 历史促销含税进价
        /// </summary>
        public decimal Lscxjj { get; set; }

        /// <summary>
        /// 历史促销售价
        /// </summary>
        public decimal Lscxsj { get; set; }

        /// <summary>
        /// 历史促销会员售价
        /// </summary>
        public decimal Lscxhysj { get; set; }

        /// <summary>
        /// 历史促销折扣
        /// </summary>
        public decimal Lscxzk { get; set; }

        /// <summary>
        /// 历史促销扣率
        /// </summary>
        public decimal Lscxkl { get; set; }

        /// <summary>
        /// 整箱价
        /// </summary>
        public decimal Zxj { get; set; }

        /// <summary>
        /// 促销整箱价
        /// </summary>
        public decimal Cxzxj { get; set; }

        /// <summary>
        /// 历史促销整箱价
        /// </summary>
        public decimal Lscxzxj { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { CompId, Spdm };
        }
    }
}
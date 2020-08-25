using System;
using Volo.Abp.Domain.Entities;

namespace Object.Domain.Smkt
{
    public class Info216 : Entity
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
        /// 捆绑名称
        /// </summary>
        public string Kbmc { get; set; }

        /// <summary>
        /// 捆绑条码
        /// </summary>
        public string Kbtm { get; set; }

        /// <summary>
        /// 商品状态 0新登 1使用 3起用 5淘汰
        /// </summary>
        public string Spzt { get; set; }

        /// <summary>
        /// 起用时间
        /// </summary>
        public DateTime? Qysj { get; set; }

        /// <summary>
        /// 淘汰时间
        /// </summary>
        public DateTime? Ttsj { get; set; }

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
            return new object[] { Kbtm };
        }
    }
}
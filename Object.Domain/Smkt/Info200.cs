using System;
using Volo.Abp.Domain.Entities;

namespace Object.Domain.Smkt
{
    public class Info200 : Entity
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
        /// 商品名称
        /// </summary>
        public string Spmc { get; set; }

        /// <summary>
        /// 助记码
        /// </summary>
        public string Zjm { get; set; }

        /// <summary>
        /// 店内条码
        /// </summary>
        public string Sptm { get; set; }

        /// <summary>
        /// 自带条码
        /// </summary>
        public string Zdtm { get; set; }

        /// <summary>
        /// 品牌代码
        /// </summary>
        public string Ppdm { get; set; }

        /// <summary>
        /// 商标
        /// </summary>
        public string Sb { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        public string Cd { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        public string Ggxh { get; set; }

        /// <summary>
        /// 大类代码
        /// </summary>
        public string Dldm { get; set; }

        /// <summary>
        /// 中类代码
        /// </summary>
        public string Zldm { get; set; }

        /// <summary>
        /// 小类代码
        /// </summary>
        public string Xldm { get; set; }

        /// <summary>
        /// 部门代码
        /// </summary>
        public string Bmdm { get; set; }

        /// <summary>
        /// 小组代码
        /// </summary>
        public string Xzdm { get; set; }

        /// <summary>
        /// 包装率
        /// </summary>
        public decimal Bzl { get; set; }

        /// <summary>
        /// 整单位
        /// </summary>
        public string Dw1 { get; set; }

        /// <summary>
        /// 零单位
        /// </summary>
        public string Dw2 { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        public decimal Sl { get; set; }

        /// <summary>
        /// 保质期
        /// </summary>
        public short? Bzq { get; set; }

        /// <summary>
        /// 供货方代码
        /// </summary>
        public string Ghfdm { get; set; }

        /// <summary>
        /// 供货方序号
        /// </summary>
        public string Xh { get; set; }

        /// <summary>
        /// 包装率标志(弃用)
        /// </summary>
        public string Bzlbz { get; set; }

        /// <summary>
        /// 部门销售标志 1部门销售  0否
        /// </summary>
        public string Xslb { get; set; }

        /// <summary>
        /// 电子秤商品标志 1电子秤商品 0普通商品
        /// </summary>
        public string Spxz { get; set; }

        /// <summary>
        /// 进货方式 0配送商品 1直送商品 2自购商品
        /// </summary>
        public string Jhfs { get; set; }

        /// <summary>
        /// 联营标志 1联营售价管理  0否
        /// </summary>
        public string Flag1 { get; set; }

        /// <summary>
        /// 生鲜标志（0NULL 2加工商品 3配料商品 4分割商品 5拆成商品）
        /// </summary>
        public string Flag2 { get; set; }

        /// <summary>
        /// 下级公司修改单价  0不能 1本单位 2能
        /// </summary>
        public string Flag { get; set; }

        /// <summary>
        /// 商品状态 (0资料登录 1正常使用 3临时终止 5永久终止)
        /// </summary>
        public string Spzt { get; set; }

        /// <summary>
        /// 商品状态1
        /// </summary>
        public string Spzt1 { get; set; }

        /// <summary>
        /// 起用时间
        /// </summary>
        public DateTime? Qysj { get; set; }

        /// <summary>
        /// 首次进货时间
        /// </summary>
        public DateTime? Jhsj { get; set; }

        /// <summary>
        /// 终止/淘汰时间
        /// </summary>
        public DateTime? Ttsj { get; set; }

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

        /// <summary>
        /// 第三方货号
        /// </summary>
        public string CSpdm { get; set; }

        /// <summary>
        /// 商品ABC
        /// </summary>
        public string SpAbc { get; set; }

        /// <summary>
        /// SpAbc1
        /// </summary>
        public string SpAbc1 { get; set; }

        /// <summary>
        /// ChangeAbc
        /// </summary>
        public string ChangeAbc { get; set; }

        /// <summary>
        /// 订货销售
        /// </summary>
        public decimal? Dhxs { get; set; }

        /// <summary>
        /// 最小订货量
        /// </summary>
        public decimal MinDhsl { get; set; }

        /// <summary>
        /// 库存上限天数
        /// </summary>
        public int KcsxTs { get; set; }

        /// <summary>
        /// 库存下限天数
        /// </summary>
        public int KcxxTs { get; set; }

        /// <summary>
        /// 安全库存天数
        /// </summary>
        public int AqkcTs { get; set; }

        /// <summary>
        /// 排面库存数量
        /// </summary>
        public decimal PmkcSl { get; set; }

        /// <summary>
        /// 整订标志
        /// </summary>
        public string ZbFlag { get; set; }

        /// <summary>
        /// 赠品条件
        /// </summary>
        public int Zptj { get; set; }

        /// <summary>
        /// 赠品数量
        /// </summary>
        public int Zpsl { get; set; }

        /// <summary>
        /// 虚库存
        /// </summary>
        public decimal? Xkc { get; set; }

        /// <summary>
        /// 消耗期长
        /// </summary>
        public int? Xhqc { get; set; }

        /// <summary>
        /// 存储方式
        /// </summary>
        public string Ccfs { get; set; }

        /// <summary>
        /// 存储说明
        /// </summary>
        public string Ccsm { get; set; }

        /// <summary>
        /// 是否进口商品
        /// </summary>
        public string IsJksp { get; set; }

        /// <summary>
        /// 货主
        /// </summary>
        public string SpHz { get; set; }

        /// <summary>
        /// 是否农商品
        /// </summary>
        public string IsNcp { get; set; }

        /// <summary>
        /// 税收分类
        /// </summary>
        public string CwFlbh { get; set; }

        /// <summary>
        /// 是否拆包
        /// </summary>
        public string FlagCb { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { CompId, Spdm };
        }
    }
}
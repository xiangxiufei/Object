using System;
using Volo.Abp.Domain.Entities;

namespace Object.Domain.Smkt
{
    public class Info050 : Entity
    {
        /// <summary>
        /// 门店代码
        /// </summary>
        public string CompId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        public string CompName { get; set; }

        /// <summary>
        /// 上级店代码
        /// </summary>
        public string UpComp { get; set; }

        /// <summary>
        /// 部门代码
        /// </summary>
        public string Bmdm { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public string Yzbm { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Dz { get; set; }

        /// <summary>
        /// 电话1
        /// </summary>
        public string Dh1 { get; set; }

        /// <summary>
        /// 电话2
        /// </summary>
        public string Dh2 { get; set; }

        /// <summary>
        /// 传真
        /// </summary>
        public string Cz { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Lxr { get; set; }

        /// <summary>
        /// 电话3
        /// </summary>
        public string Dh3 { get; set; }

        /// <summary>
        /// BP机号
        /// </summary>
        public string Bp { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 店类型  0公司 1连锁店 2配送中心 3竞争对手
        /// </summary>
        public string Lx { get; set; }

        /// <summary>
        /// 门店类型 0连锁店 1加盟店 2配送中心 3库房
        /// </summary>
        public string CompType { get; set; }

        /// <summary>
        /// 执行价格
        /// </summary>
        public string Zxjg { get; set; }

        /// <summary>
        /// 配送折扣
        /// </summary>
        public decimal Pszk { get; set; }

        /// <summary>
        /// 登录状态  0资料登录 1正式登录 2终止
        /// </summary>
        public string Dlzt { get; set; }

        /// <summary>
        /// 组织类型 z总部 a门店
        /// </summary>
        public string Filemark { get; set; }

        /// <summary>
        /// ftp服务器
        /// </summary>
        public string FtpServer { get; set; }

        /// <summary>
        /// ftp用户名
        /// </summary>
        public string FtpUser { get; set; }

        /// <summary>
        /// ftp密码
        /// </summary>
        public string FtpPassword { get; set; }

        /// <summary>
        /// ftp连接超时设置
        /// </summary>
        public int? FtpTimeOut { get; set; }

        /// <summary>
        /// ftp接收该单位文件路径
        /// </summary>
        public string FtpRevfilePath { get; set; }

        /// <summary>
        /// ftp发送该单位文件路径
        /// </summary>
        public string FtpSendfilePath { get; set; }

        /// <summary>
        /// 是否显示进价 0是 1否
        /// </summary>
        public string Sjdj { get; set; }

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
        /// 店面面积
        /// </summary>
        public decimal? Mj { get; set; }

        /// <summary>
        /// Pos机台数
        /// </summary>
        public int? Pos { get; set; }

        /// <summary>
        /// 第三方代码
        /// </summary>
        public string CwCompId { get; set; }

        /// <summary>
        /// 第三方名称
        /// </summary>
        public string CwCompName { get; set; }

        /// <summary>
        /// 货主
        /// </summary>
        public string CompHz { get; set; }

        /// <summary>
        /// 配送仓库
        /// </summary>
        public string Warehouseid { get; set; }

        /// <summary>
        /// 体系代码
        /// </summary>
        public string Code { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { CompId };
        }
    }
}
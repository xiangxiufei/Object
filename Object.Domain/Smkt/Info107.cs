using System;
using Volo.Abp.Domain.Entities;

namespace Object.Domain.Smkt
{
    public class Info107 : Entity
    {
        /// <summary>
        /// 人员代码
        /// </summary>
        public string Rydm { get; set; }

        /// <summary>
        /// 人员名称
        /// </summary>
        public string Rymc { get; set; }

        /// <summary>
        /// 小组代码
        /// </summary>
        public string Xzdm { get; set; }

        /// <summary>
        ///  登录状态(0新登录 1可用 3准备禁用 4禁用)
        /// </summary>
        public string Dlzt { get; set; }

        /// <summary>
        ///  人员级别 (A一般用户 E收银员 F收银员主管 H部门经理 O总经理 Y系统管理员)
        /// </summary>
        public string Ryjb { get; set; }

        /// <summary>
        /// 人员口令(前台)
        /// </summary>
        public string Kl { get; set; }

        /// <summary>
        ///  人员权限 
        /// </summary>
        public string Qx { get; set; }

        /// <summary>
        /// 创建人员
        /// </summary>
        public string Firstman { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Firstdate { get; set; }

        /// <summary>
        /// 最后修改人员
        /// </summary>
        public string Lastman { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime Lastdate { get; set; }

        /// <summary>
        /// 人员职位
        /// </summary>
        public string Ryzw { get; set; }

        /// <summary>
        /// 人员口令(app)
        /// </summary>
        public string ExtKl { get; set; }

        /// <summary>
        /// 门店代码
        /// </summary>
        public string CompId { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { Rydm };
        }
    }
}
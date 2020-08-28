using Microsoft.EntityFrameworkCore;
using Object.Domain.Shared;
using Object.Domain.Smkt;
using Volo.Abp;

namespace Object.EntityFrameworkCore
{
    public static class ObjectDbContextModelCreatingExtensions
    {
        public static void Configure(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            #region Info050

            builder.Entity<Info050>(entity =>
            {
                entity.HasKey(e => e.CompId)
                    .HasName("info050_0");

                entity.ToTable("info050", ObjectConsts.DbSchema);

                entity.Property(e => e.CompId)
                    .HasColumnName("comp_id")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("门店代码");

                entity.Property(e => e.Bmdm)
                    .HasColumnName("bmdm")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("部门代码");

                entity.Property(e => e.Bp)
                    .HasColumnName("bp")
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasComment("BP机号");

                entity.Property(e => e.Bz)
                    .HasColumnName("bz")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("备注");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("体系代码");

                entity.Property(e => e.CompHz)
                    .HasColumnName("comp_hz")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("货主");

                entity.Property(e => e.CompName)
                    .HasColumnName("comp_name")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("门店名称");

                entity.Property(e => e.CompType)
                    .IsRequired()
                    .HasColumnName("comp_type")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("门店类型");

                entity.Property(e => e.CwCompId)
                    .HasColumnName("cw_comp_id")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("第三方代码");

                entity.Property(e => e.CwCompName)
                    .HasColumnName("cw_comp_name")
                    .HasMaxLength(140)
                    .IsUnicode(false)
                    .HasComment("第三方名称");

                entity.Property(e => e.Cz)
                    .HasColumnName("cz")
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasComment("传真");

                entity.Property(e => e.Dh1)
                    .HasColumnName("dh1")
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasComment("电话1");

                entity.Property(e => e.Dh2)
                    .HasColumnName("dh2")
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasComment("电话2");

                entity.Property(e => e.Dh3)
                    .HasColumnName("dh3")
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasComment("电话3");

                entity.Property(e => e.Dlzt)
                    .HasColumnName("dlzt")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("登录状态");

                entity.Property(e => e.Dz)
                    .HasColumnName("dz")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasComment("邮箱");

                entity.Property(e => e.Filemark)
                    .HasColumnName("filemark")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("组织类型");

                entity.Property(e => e.Firstdate)
                    .HasColumnName("firstdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建人");

                entity.Property(e => e.Firstman)
                    .IsRequired()
                    .HasColumnName("firstman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('9999')")
                    .HasComment("创建时间");

                entity.Property(e => e.FtpPassword)
                    .HasColumnName("ftp_password")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ftp密码");

                entity.Property(e => e.FtpRevfilePath)
                    .HasColumnName("ftp_revfile_path")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("ftp接收该单位文件路径");

                entity.Property(e => e.FtpSendfilePath)
                    .HasColumnName("ftp_sendfile_path")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("ftp发送该单位文件路径");

                entity.Property(e => e.FtpServer)
                    .HasColumnName("ftp_server")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("ftp服务器");

                entity.Property(e => e.FtpTimeOut)
                      .HasColumnName("ftp_time_out")
                      .HasComment("ftp连接超时设置");

                entity.Property(e => e.FtpUser)
                    .HasColumnName("ftp_user")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ftp用户名");

                entity.Property(e => e.Lastdate)
                    .HasColumnName("lastdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改时间");

                entity.Property(e => e.Lastman)
                    .IsRequired()
                    .HasColumnName("lastman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('9999')")
                    .HasComment("修改人");

                entity.Property(e => e.Lx)
                    .IsRequired()
                    .HasColumnName("lx")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("店类型");

                entity.Property(e => e.Lxr)
                    .HasColumnName("lxr")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("联系人");

                entity.Property(e => e.Mj)
                    .HasColumnName("mj")
                    .HasColumnType("numeric(12, 2)")
                    .HasComment("店面面积");

                entity.Property(e => e.Pos)
                    .HasColumnName("pos")
                    .HasComment("Pos机台数");

                entity.Property(e => e.Pszk)
                    .HasColumnName("pszk")
                    .HasColumnType("numeric(5, 2)")
                    .HasComment("配送折扣");

                entity.Property(e => e.Sjdj)
                    .IsRequired()
                    .HasColumnName("sjdj")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("是否显示进价");

                entity.Property(e => e.UpComp)
                    .IsRequired()
                    .HasColumnName("up_comp")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('999999')")
                    .HasComment("上级店代码");

                entity.Property(e => e.Warehouseid)
                    .HasColumnName("warehouseid")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("配送仓库");

                entity.Property(e => e.Yzbm)
                    .HasColumnName("yzbm")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("邮政编码");

                entity.Property(e => e.Zxjg)
                    .IsRequired()
                    .HasColumnName("zxjg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')")
                    .HasComment("执行价格");
            });

            #endregion Info050

            #region Info107

            builder.Entity<Info107>(entity =>
            {
                entity.HasKey(e => e.Rydm)
                    .HasName("info107_0");

                entity.ToTable("info107", ObjectConsts.DbSchema);

                entity.Property(e => e.Rydm)
                    .HasColumnName("rydm")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("人员代码");

                entity.Property(e => e.CompId)
                    .HasColumnName("comp_id")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("门店代码");

                entity.Property(e => e.Dlzt)
                    .IsRequired()
                    .HasColumnName("dlzt")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("登录状态");

                entity.Property(e => e.ExtKl)
                    .HasColumnName("ext_kl")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasComment("人员口令(app)");

                entity.Property(e => e.Firstdate)
                    .HasColumnName("firstdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.Firstman)
                    .IsRequired()
                    .HasColumnName("firstman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('9999')")
                    .HasComment("创建人员");

                entity.Property(e => e.Kl)
                    .HasColumnName("kl")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasComment("人员口令(前台)");

                entity.Property(e => e.Lastdate)
                    .HasColumnName("lastdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改时间");

                entity.Property(e => e.Lastman)
                    .IsRequired()
                    .HasColumnName("lastman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('9999')")
                    .HasComment("修改人员");

                entity.Property(e => e.Qx)
                    .HasColumnName("qx")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000000000000000000000000000000000000000000000000000000000000')")
                    .HasComment("人员权限");

                entity.Property(e => e.Ryjb)
                    .IsRequired()
                    .HasColumnName("ryjb")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("人员级别");

                entity.Property(e => e.Rymc)
                    .IsRequired()
                    .HasColumnName("rymc")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasComment("人员名称");

                entity.Property(e => e.Ryzw)
                    .IsRequired()
                    .HasColumnName("ryzw")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("人员职位");

                entity.Property(e => e.Xzdm)
                    .IsRequired()
                    .HasColumnName("xzdm")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasComment("小组代码");
            });

            #endregion Info107

            #region Info200

            builder.Entity<Info200>(entity =>
            {
                entity.HasKey(e => new { e.CompId, e.Spdm })
                    .HasName("info200_0");

                entity.ToTable("info200", ObjectConsts.DbSchema);

                entity.Property(e => e.CompId)
                    .HasColumnName("comp_id")
                    .HasMaxLength(8)
                    .HasComment("门店代码");

                entity.Property(e => e.Spdm)
                    .HasColumnName("spdm")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasComment("商品代码");

                entity.Property(e => e.AqkcTs)
                    .HasColumnName("aqkc_ts")
                    .HasDefaultValueSql("((3))")
                    .HasComment("安全库存天数");

                entity.Property(e => e.Bmdm)
                    .IsRequired()
                    .HasColumnName("bmdm")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("部门代码");

                entity.Property(e => e.Bz)
                    .HasColumnName("bz")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasComment("备注");

                entity.Property(e => e.Bzl)
                    .HasColumnName("bzl")
                    .HasColumnType("numeric(8, 2)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("包装率");

                entity.Property(e => e.Bzlbz)
                    .IsRequired()
                    .HasColumnName("bzlbz")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("包装率标志");

                entity.Property(e => e.Bzq)
                    .HasColumnName("bzq")
                    .HasComment("保质期");

                entity.Property(e => e.CSpdm)
                    .HasColumnName("c_spdm")
                    .HasMaxLength(20)
                    .HasComment("第三方货号");

                entity.Property(e => e.Ccfs)
                    .HasColumnName("ccfs")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("存储方式");

                entity.Property(e => e.Ccsm)
                    .HasColumnName("ccsm")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("存储说明");

                entity.Property(e => e.Cd)
                    .HasColumnName("cd")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("产地");

                entity.Property(e => e.ChangeAbc)
                    .HasColumnName("change_abc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CwFlbh)
                    .HasColumnName("cw_flbh")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("税收分类");

                entity.Property(e => e.Dhxs)
                    .HasColumnName("dhxs")
                    .HasColumnType("numeric(5, 2)")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("订货销售");

                entity.Property(e => e.Dldm)
                    .IsRequired()
                    .HasColumnName("dldm")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("大类代码");

                entity.Property(e => e.Dw1)
                    .HasColumnName("dw1")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("整单位");

                entity.Property(e => e.Dw2)
                    .IsRequired()
                    .HasColumnName("dw2")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("零单位");

                entity.Property(e => e.Firstdate)
                    .HasColumnName("firstdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.Firstman)
                    .IsRequired()
                    .HasColumnName("firstman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("创建人");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("整订标志");

                entity.Property(e => e.Flag1)
                    .IsRequired()
                    .HasColumnName("flag1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("联营标志");

                entity.Property(e => e.Flag2)
                    .IsRequired()
                    .HasColumnName("flag2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("生鲜标志");

                entity.Property(e => e.FlagCb)
                    .HasColumnName("flag_cb")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("是否拆包");

                entity.Property(e => e.Ggxh)
                    .HasColumnName("ggxh")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("供货方代码");

                entity.Property(e => e.Ghfdm)
                    .IsRequired()
                    .HasColumnName("ghfdm")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("供货方序号");

                entity.Property(e => e.IsJksp)
                    .IsRequired()
                    .HasColumnName("is_jksp")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("是否进口商品");

                entity.Property(e => e.IsNcp)
                    .HasColumnName("is_ncp")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("是否农商品");

                entity.Property(e => e.Jhfs)
                    .IsRequired()
                    .HasColumnName("jhfs")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')")
                    .HasComment("进货方式");

                entity.Property(e => e.Jhsj)
                    .HasColumnName("jhsj")
                    .HasColumnType("smalldatetime")
                    .HasComment("首次进货时间");

                entity.Property(e => e.KcsxTs)
                    .HasColumnName("kcsx_ts")
                    .HasDefaultValueSql("((90))");

                entity.Property(e => e.KcxxTs)
                    .HasColumnName("kcxx_ts")
                    .HasDefaultValueSql("((1))")
                    .HasComment("库存下限天数");

                entity.Property(e => e.Lastdate)
                    .HasColumnName("lastdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改时间");

                entity.Property(e => e.Lastman)
                    .IsRequired()
                    .HasColumnName("lastman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("修改人");

                entity.Property(e => e.MinDhsl)
                    .HasColumnName("min_dhsl")
                    .HasColumnType("numeric(12, 3)")
                    .HasDefaultValueSql("((0.000))")
                    .HasComment("最小订货量");

                entity.Property(e => e.PmkcSl)
                    .HasColumnName("pmkc_sl")
                    .HasColumnType("numeric(12, 3)")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("排面库存数量");

                entity.Property(e => e.Ppdm)
                    .HasColumnName("ppdm")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasComment("品牌代码");

                entity.Property(e => e.Qysj)
                    .HasColumnName("qysj")
                    .HasColumnType("smalldatetime")
                    .HasComment("起用时间");

                entity.Property(e => e.Sb)
                    .HasColumnName("sb")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("商标");

                entity.Property(e => e.Sl)
                    .HasColumnName("sl")
                    .HasColumnType("numeric(5, 2)")
                    .HasComment("税率");

                entity.Property(e => e.SpAbc)
                    .HasColumnName("sp_abc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("商品ABC");

                entity.Property(e => e.SpAbc1)
                    .HasColumnName("sp_abc1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpHz)
                    .HasColumnName("sp_hz")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("货主");

                entity.Property(e => e.Spmc)
                    .IsRequired()
                    .HasColumnName("spmc")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasComment("商品名称");

                entity.Property(e => e.Sptm)
                    .IsRequired()
                    .HasColumnName("sptm")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("店内条码");

                entity.Property(e => e.Spxz)
                    .IsRequired()
                    .HasColumnName("spxz")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("电子秤商品标志");

                entity.Property(e => e.Spzt)
                    .IsRequired()
                    .HasColumnName("spzt")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("商品状态");

                entity.Property(e => e.Spzt1)
                    .IsRequired()
                    .HasColumnName("spzt1")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Ttsj)
                    .HasColumnName("ttsj")
                    .HasColumnType("smalldatetime")
                    .HasComment("终止/淘汰时间");

                entity.Property(e => e.Xh)
                    .HasColumnName("xh")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasComment("供货方序号");

                entity.Property(e => e.Xhqc)
                    .HasColumnName("xhqc")
                    .HasDefaultValueSql("((0))")
                    .HasComment("消耗期长");

                entity.Property(e => e.Xkc)
                    .HasColumnName("xkc")
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("虚库存");

                entity.Property(e => e.Xldm)
                    .IsRequired()
                    .HasColumnName("xldm")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("小类代码");

                entity.Property(e => e.Xslb)
                    .IsRequired()
                    .HasColumnName("xslb")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("部门销售标志");

                entity.Property(e => e.Xzdm)
                    .IsRequired()
                    .HasColumnName("xzdm")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasComment("小组代码");

                entity.Property(e => e.ZbFlag)
                    .IsRequired()
                    .HasColumnName("zb_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("整订标志");

                entity.Property(e => e.Zdtm)
                    .HasColumnName("zdtm")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("自带条码");

                entity.Property(e => e.Zjm)
                    .HasColumnName("zjm")
                    .HasMaxLength(20)
                    .HasComment("助记码");

                entity.Property(e => e.Zldm)
                    .IsRequired()
                    .HasColumnName("zldm")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasComment("中类代码");

                entity.Property(e => e.Zpsl)
                    .HasColumnName("zpsl")
                    .HasComment("赠品数量");

                entity.Property(e => e.Zptj)
                    .HasColumnName("zptj")
                    .HasComment("赠品条件");
            });

            #endregion Info200

            #region info201

            builder.Entity<Info201>(entity =>
            {
                entity.HasKey(e => new { e.CompId, e.Spdm })
                    .HasName("info201_0");

                entity.ToTable("info201", ObjectConsts.DbSchema);

                entity.Property(e => e.CompId)
                    .HasColumnName("comp_id")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("门店代码");

                entity.Property(e => e.Spdm)
                    .HasColumnName("spdm")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasComment("商品代码");

                entity.Property(e => e.Cxhysj)
                    .HasColumnName("cxhysj")
                    .HasColumnType("numeric(9, 2)")
                    .HasComment("促销会员售价");

                entity.Property(e => e.Cxjj)
                    .HasColumnName("cxjj")
                    .HasColumnType("numeric(11, 4)")
                    .HasComment("促销含税进价");

                entity.Property(e => e.Cxjjsj)
                    .HasColumnName("cxjjsj")
                    .HasColumnType("smalldatetime")
                    .HasComment("促销进价起始时间");

                entity.Property(e => e.Cxsj)
                    .HasColumnName("cxsj")
                    .HasColumnType("numeric(9, 2)")
                    .HasComment("促销售价");

                entity.Property(e => e.Cxzk)
                    .HasColumnName("cxzk")
                    .HasColumnType("numeric(5, 2)")
                    .HasComment("促销折扣");

                entity.Property(e => e.Cxzxj)
                    .HasColumnName("cxzxj")
                    .HasColumnType("numeric(9, 4)")
                    .HasComment("促销整箱价");

                entity.Property(e => e.Firstdate)
                    .HasColumnName("firstdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.Firstman)
                    .IsRequired()
                    .HasColumnName("firstman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("创建人");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ghfzk)
                    .HasColumnName("ghfzk")
                    .HasColumnType("numeric(5, 2)")
                    .HasComment("供货方折扣");

                entity.Property(e => e.Hysj)
                    .HasColumnName("hysj")
                    .HasColumnType("numeric(9, 2)")
                    .HasComment("会员售价");

                entity.Property(e => e.Jfbl)
                    .HasColumnName("jfbl")
                    .HasColumnType("numeric(5, 2)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("积分比例");

                entity.Property(e => e.Jj)
                    .HasColumnName("jj")
                    .HasColumnType("numeric(11, 4)")
                    .HasComment("含税进价");

                entity.Property(e => e.Jjl)
                    .HasColumnName("jjl")
                    .HasColumnType("numeric(5, 2)")
                    .HasComment("加价率");

                entity.Property(e => e.Jjzzsj)
                    .HasColumnName("jjzzsj")
                    .HasColumnType("smalldatetime")
                    .HasComment("促销进价终止时间");

                entity.Property(e => e.Lastdate)
                    .HasColumnName("lastdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改时间");

                entity.Property(e => e.Lastman)
                    .IsRequired()
                    .HasColumnName("lastman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("修改人");

                entity.Property(e => e.Lscxhysj)
                    .HasColumnName("lscxhysj")
                    .HasColumnType("numeric(9, 2)")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("历史促销会员售价");

                entity.Property(e => e.Lscxjj)
                    .HasColumnName("lscxjj")
                    .HasColumnType("numeric(18, 7)")
                    .HasComment("历史促销含税进价");

                entity.Property(e => e.Lscxkl)
                    .HasColumnName("lscxkl")
                    .HasColumnType("numeric(7, 4)")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("历史促销扣率");

                entity.Property(e => e.Lscxsj)
                    .HasColumnName("lscxsj")
                    .HasColumnType("numeric(9, 2)")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("历史促销售价");

                entity.Property(e => e.Lscxzk)
                    .HasColumnName("lscxzk")
                    .HasColumnType("numeric(5, 2)")
                    .HasDefaultValueSql("((0.00))")
                    .HasComment("历史促销折扣");

                entity.Property(e => e.Lscxzxj)
                    .HasColumnName("lscxzxj")
                    .HasColumnType("numeric(9, 4)")
                    .HasComment("历史促销整箱价");

                entity.Property(e => e.Lsjjqs)
                    .HasColumnName("lsjjqs")
                    .HasColumnType("smalldatetime")
                    .HasComment("历史促销进价起始时间");

                entity.Property(e => e.Lsjjzz)
                    .HasColumnName("lsjjzz")
                    .HasColumnType("smalldatetime")
                    .HasComment("历史促销进价终止时间");

                entity.Property(e => e.Lsqssj)
                    .HasColumnName("lsqssj")
                    .HasColumnType("smalldatetime")
                    .HasComment("历史促销售价起始时间");

                entity.Property(e => e.Lszzsj)
                    .HasColumnName("lszzsj")
                    .HasColumnType("smalldatetime")
                    .HasComment("历史促销售价终止时间");

                entity.Property(e => e.Psj1)
                    .HasColumnName("psj1")
                    .HasColumnType("numeric(9, 2)")
                    .HasComment("配送价一");

                entity.Property(e => e.Psj2)
                    .HasColumnName("psj2")
                    .HasColumnType("numeric(9, 2)")
                    .HasComment("配送价二");

                entity.Property(e => e.Psj3)
                    .HasColumnName("psj3")
                    .HasColumnType("numeric(9, 2)")
                    .HasComment("配送价三");

                entity.Property(e => e.Qssj)
                    .HasColumnName("qssj")
                    .HasColumnType("smalldatetime")
                    .HasComment("促销售价起始时间");

                entity.Property(e => e.Sj)
                    .HasColumnName("sj")
                    .HasColumnType("numeric(9, 2)")
                    .HasComment("售价");

                entity.Property(e => e.Spzt)
                    .IsRequired()
                    .HasColumnName("spzt")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('00')")
                    .HasComment("商品状态");

                entity.Property(e => e.TransDate)
                    .HasColumnName("trans_date")
                    .HasColumnType("smalldatetime")
                    .HasComment("传输时间");

                entity.Property(e => e.TransReason)
                    .IsRequired()
                    .HasColumnName("trans_reason")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("传输原因");

                entity.Property(e => e.TransState)
                    .IsRequired()
                    .HasColumnName("trans_state")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("传输状态");

                entity.Property(e => e.Zk)
                    .HasColumnName("zk")
                    .HasColumnType("numeric(5, 2)")
                    .HasComment("折扣");

                entity.Property(e => e.Zxj)
                    .HasColumnName("zxj")
                    .HasColumnType("numeric(11, 4)")
                    .HasComment("整箱价");

                entity.Property(e => e.Zzsj)
                    .HasColumnName("zzsj")
                    .HasColumnType("smalldatetime")
                    .HasComment("促销售价终止时间");
            });

            #endregion info201

            #region Info216

            builder.Entity<Info216>(entity =>
            {
                entity.HasKey(e => e.Kbdm)
                    .HasName("info216_0");

                entity.ToTable("info216", ObjectConsts.DbSchema);

                entity.Property(e => e.Kbdm)
                    .HasColumnName("kbdm")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasComment("捆绑代码");

                entity.Property(e => e.CompId)
                    .IsRequired()
                    .HasColumnName("comp_id")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("门店代码");

                entity.Property(e => e.Firstdate)
                    .HasColumnName("firstdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.Firstman)
                    .IsRequired()
                    .HasColumnName("firstman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("创建人");

                entity.Property(e => e.Kbmc)
                    .IsRequired()
                    .HasColumnName("kbmc")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("捆绑名称");

                entity.Property(e => e.Kbtm)
                    .IsRequired()
                    .HasColumnName("kbtm")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("捆绑条码");

                entity.Property(e => e.Lastdate)
                    .HasColumnName("lastdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("修改时间");

                entity.Property(e => e.Lastman)
                    .IsRequired()
                    .HasColumnName("lastman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("修改人");

                entity.Property(e => e.Qysj)
                    .HasColumnName("qysj")
                    .HasColumnType("smalldatetime")
                    .HasComment("起用时间");

                entity.Property(e => e.Spzt)
                    .IsRequired()
                    .HasColumnName("spzt")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')")
                    .HasComment("商品状态");

                entity.Property(e => e.Ttsj)
                    .HasColumnName("ttsj")
                    .HasColumnType("smalldatetime")
                    .HasComment("淘汰时间");
            });

            #endregion Info216

            #region Info217

            builder.Entity<Info217>(entity =>
            {
                entity.HasKey(e => new { e.Kbdm, e.Spdm })
                    .HasName("info217_0");

                entity.ToTable("info217", ObjectConsts.DbSchema);

                entity.Property(e => e.Kbdm)
                    .HasColumnName("kbdm")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasComment("捆绑代码");

                entity.Property(e => e.Spdm)
                    .HasColumnName("spdm")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasComment("商品代码");

                entity.Property(e => e.CompId)
                    .IsRequired()
                    .HasColumnName("comp_id")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("门店代码");

                entity.Property(e => e.Cxhysj)
                    .HasColumnName("cxhysj")
                    .HasColumnType("numeric(9, 2)")
                    .HasComment("促销会员售价");

                entity.Property(e => e.Cxsj)
                    .HasColumnName("cxsj")
                    .HasColumnType("numeric(9, 2)")
                    .HasComment("促销售价");

                entity.Property(e => e.Firstdate)
                    .HasColumnName("firstdate")
                    .HasColumnType("smalldatetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Firstman)
                    .IsRequired()
                    .HasColumnName("firstman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("创建人");

                entity.Property(e => e.Hysj)
                    .HasColumnName("hysj")
                    .HasColumnType("numeric(13, 6)")
                    .HasComment("会员售价");

                entity.Property(e => e.Kbsl)
                    .HasColumnName("kbsl")
                    .HasColumnType("numeric(9, 2)")
                    .HasComment("捆绑售价");

                entity.Property(e => e.Lastdate)
                    .HasColumnName("lastdate")
                    .HasColumnType("smalldatetime")
                    .HasComment("修改时间");

                entity.Property(e => e.Lastman)
                    .IsRequired()
                    .HasColumnName("lastman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("修改人");

                entity.Property(e => e.Sj)
                    .HasColumnName("sj")
                    .HasColumnType("numeric(13, 6)")
                    .HasComment("售价");
            });

            #endregion Info217

            #region Info223

            builder.Entity<Info223>(entity =>
            {
                entity.HasKey(e => new { e.CompId, e.Spdm, e.Sptm })
                    .HasName("info223_0")
                    .IsClustered(false);

                entity.ToTable("info223", ObjectConsts.DbSchema);

                entity.Property(e => e.CompId)
                    .HasColumnName("comp_id")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("门店代码");

                entity.Property(e => e.Spdm)
                    .HasColumnName("spdm")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasComment("商品代码");

                entity.Property(e => e.Sptm)
                    .HasColumnName("sptm")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("店内条码");

                entity.Property(e => e.Bz)
                    .HasColumnName("bz")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasComment("备注");

                entity.Property(e => e.Firstdate)
                    .HasColumnName("firstdate")
                    .HasColumnType("smalldatetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Firstman)
                    .IsRequired()
                    .HasColumnName("firstman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("创建人");

                entity.Property(e => e.Lastdate)
                    .HasColumnName("lastdate")
                    .HasColumnType("smalldatetime")
                    .HasComment("修改时间");

                entity.Property(e => e.Lastman)
                    .IsRequired()
                    .HasColumnName("lastman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("修改人");

                entity.Property(e => e.Zdtm)
                    .HasColumnName("zdtm")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("自带条码");
            });

            #endregion Info223

            #region Info702

            builder.Entity<Info702>(entity =>
            {
                entity.HasKey(e => e.Bzdm)
                    .HasName("info702_0");

                entity.ToTable("info702", ObjectConsts.DbSchema);

                entity.Property(e => e.Bzdm)
                    .HasColumnName("bzdm")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Bshbz)
                    .IsRequired()
                    .HasColumnName("bshbz")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Bzlx)
                    .IsRequired()
                    .HasColumnName("bzlx")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Bzmc)
                    .IsRequired()
                    .HasColumnName("bzmc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BzmcE)
                    .HasColumnName("bzmc_e")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dlzt)
                    .IsRequired()
                    .HasColumnName("dlzt")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Firstdate)
                    .HasColumnName("firstdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Firstman)
                    .IsRequired()
                    .HasColumnName("firstman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('9999')");

                entity.Property(e => e.Fkzddw)
                    .HasColumnName("fkzddw")
                    .HasColumnType("numeric(9, 2)")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.Fkzxdw)
                    .HasColumnName("fkzxdw")
                    .HasColumnType("numeric(9, 2)")
                    .HasDefaultValueSql("((0.01))");

                entity.Property(e => e.Hl)
                    .HasColumnName("hl")
                    .HasColumnType("numeric(18, 7)");

                entity.Property(e => e.Hotkey)
                    .IsRequired()
                    .HasColumnName("hotkey")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('00')");

                entity.Property(e => e.Lastdate)
                    .HasColumnName("lastdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastman)
                    .IsRequired()
                    .HasColumnName("lastman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('9999')");

                entity.Property(e => e.Qtsybz)
                    .IsRequired()
                    .HasColumnName("qtsybz")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Sqhbz)
                    .IsRequired()
                    .HasColumnName("sqhbz")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Zlbz)
                    .IsRequired()
                    .HasColumnName("zlbz")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");
            });

            #endregion Info702
        }
    }
}
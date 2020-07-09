<template>
    <div>
        <el-breadcrumb separator-class="el-icon-arrow-right">
            <el-breadcrumb-item :to="{ path: '/home' }">
                首页
            </el-breadcrumb-item>
            <el-breadcrumb-item>权限管理</el-breadcrumb-item>
            <el-breadcrumb-item>角色列表</el-breadcrumb-item>
        </el-breadcrumb>

        <el-card>
            <el-row :gutter="10">
                <el-col :span="6">
                    <el-button type="primary">添加角色</el-button>
                </el-col>
            </el-row>

            <el-table :data="roleList" border stripe>
                <el-table-column type="expand"></el-table-column>
                <el-table-column type="index" label="#"></el-table-column>
                <el-table-column
                    label="角色名称"
                    prop="roleName"
                ></el-table-column>
                <el-table-column
                    label="角色描述"
                    prop="roleDec"
                ></el-table-column>
                <el-table-column label="操作" width="300px">
                    <template slot-scope="scope">
                        <el-button
                            size="mini"
                            type="primary"
                            icon="el-icon-edit"
                        >
                            编辑
                        </el-button>
                        <el-button
                            size="mini"
                            type="danger"
                            icon="el-icon-delete"
                        >
                            删除
                        </el-button>
                        <el-button
                            size="mini"
                            type="warning"
                            icon="el-icon-setting"
                        >
                            分配权限
                        </el-button>
                    </template>
                </el-table-column>
            </el-table>
        </el-card>
    </div>
</template>

<script>
export default {
    data() {
        return {
            roleList: [],
        };
    },
    created() {
        this.getRoleList();
    },
    methods: {
        async getRoleList() {
            const { data: res } = await this.$http.get("role");

            if (res.status === 200) {
                this.roleList = res.data;
            } else {
                this.$message.error(res.msg);
            }
        },
    },
};
</script>

<style lang="less" scoped></style>

<template>
    <div>
        <el-breadcrumb separator-class="el-icon-arrow-right">
            <el-breadcrumb-item :to="{ path: '/home' }">
                首页
            </el-breadcrumb-item>
            <el-breadcrumb-item>权限管理</el-breadcrumb-item>
            <el-breadcrumb-item>权限列表</el-breadcrumb-item>
        </el-breadcrumb>

        <el-card>
            <el-table :data="rightList" border stripe>
                <el-table-column type="index" label="#"></el-table-column>
                <el-table-column
                    label="权限名称"
                    prop="authName"
                ></el-table-column>
                <el-table-column label="路径" prop="path"></el-table-column>
                <el-table-column label="权限等级" prop="level">
                    <template slot-scope="scope">
                        <el-tag v-if="scope.row.level === '0'">一级</el-tag>
                        <el-tag v-if="scope.row.level === '1'" type="success">
                            二级
                        </el-tag>
                        <el-tag v-if="scope.row.level === '2'" type="warning">
                            三级
                        </el-tag>
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
            rightList: [],
        };
    },
    created() {
        this.getRightList();
    },
    methods: {
        async getRightList() {
            const { data: res } = await this.$http.get("menu/list");

            if (res.status === 200) {
                this.rightList = res.data;
            } else {
                this.$message.error(res.msg);
            }
        },
    },
};
</script>

<style lang="less" scoped></style>

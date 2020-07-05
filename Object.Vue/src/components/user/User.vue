<template>
    <div>
        <el-breadcrumb separator-class="el-icon-arrow-right">
            <el-breadcrumb-item :to="{ path: '/home' }">
                首页
            </el-breadcrumb-item>
            <el-breadcrumb-item>用户管理</el-breadcrumb-item>
            <el-breadcrumb-item>用户列表</el-breadcrumb-item>
        </el-breadcrumb>

        <el-card class="box-card">
            <el-row :gutter="20">
                <el-col :span="7">
                    <el-input
                        placeholder="请输入内容"
                        v-model="queryInfo.query"
                        clearable
                        @clear="getUserList"
                    >
                        <el-button
                            slot="append"
                            icon="el-icon-search"
                            @click="getUserList"
                        ></el-button>
                    </el-input>
                </el-col>
                <el-col :span="4">
                    <el-button type="primary" @click="addDialogVisible = true">
                        添加用户
                    </el-button>
                </el-col>
            </el-row>
            <el-table :data="userList" border stripe>
                <el-table-column type="index" label="#"></el-table-column>
                <el-table-column label="账号" prop="userName"></el-table-column>
                <el-table-column label="性别" prop="sex"></el-table-column>
                <el-table-column label="年龄" prop="age"></el-table-column>
                <el-table-column label="电话" prop="mobile"></el-table-column>
                <el-table-column label="邮箱" prop="email"></el-table-column>
                <el-table-column label="状态">
                    <template slot-scope="scope">
                        <el-switch
                            v-model="scope.row.status"
                            @change="userStatusChanged(scope.row)"
                        ></el-switch>
                    </template>
                </el-table-column>
                <el-table-column label="操作" width="180px">
                    <template>
                        <el-button
                            type="primary"
                            icon="el-icon-edit"
                            size="mini"
                        ></el-button>
                        <el-button
                            type="danger"
                            icon="el-icon-delete"
                            size="mini"
                        ></el-button>
                        <el-tooltip
                            effect="dark"
                            content="分配角色"
                            placement="top"
                            :enterable="false"
                        >
                            <el-button
                                type="warning"
                                icon="el-icon-setting"
                                size="mini"
                            ></el-button>
                        </el-tooltip>
                    </template>
                </el-table-column>
            </el-table>

            <el-pagination
                @size-change="handleSizeChange"
                @current-change="handleCurrentChange"
                :current-page="queryInfo.pageNum"
                :page-sizes="[1, 2, 5, 10]"
                :page-size="queryInfo.pageSize"
                layout="total, sizes, prev, pager, next, jumper"
                :total="total"
            ></el-pagination>

            <el-dialog
                title="添加用户"
                :visible.sync="addDialogVisible"
                width="50%"
            >
                <el-form
                    :model="addForm"
                    :rules="addFormRules"
                    ref="addFormRef"
                    label-width="70px"
                >
                    <el-form-item label="账号" prop="userName">
                        <el-input v-model="addForm.userName"></el-input>
                    </el-form-item>
                </el-form>

                <span slot="footer" class="dialog-footer">
                    <el-button @click="addDialogVisible = false">
                        取 消
                    </el-button>
                    <el-button type="primary" @click="addDialogVisible = false">
                        确 定
                    </el-button>
                </span>
            </el-dialog>
        </el-card>
    </div>
</template>

<script>
export default {
    data() {
        return {
            queryInfo: {
                query: "",
                pageNum: 1,
                pageSize: 2,
            },
            userList: [],
            total: 0,
            addDialogVisible: false,
            addForm: {
                userName: "",
            },
            addFormRules: {
                userName: [
                    { required: true, message: "请输入账号", trigger: "blur" },
                    {
                        min: 4,
                        max: 18,
                        message: "账号的长度在 4 ~ 18 个字符之间",
                        trigger: "blur",
                    },
                ],
            },
        };
    },
    created() {
        this.getUserList();
    },
    methods: {
        async getUserList() {
            const { data: res } = await this.$http.get("user", {
                params: {
                    query: this.queryInfo.query,
                    pageNum: this.queryInfo.pageNum,
                    pageSize: this.queryInfo.pageSize,
                },
            });

            if (res.status === 200) {
                this.userList = res.data.list;
                this.total = res.data.total;
            } else {
                this.$message.error(res.msg);
            }
        },
        handleSizeChange(newSize) {
            this.queryInfo.pageSize = newSize;
            this.getUserList();
        },
        handleCurrentChange(newPage) {
            this.queryInfo.pageNum = newPage;
            this.getUserList();
        },
        async userStatusChanged(user) {
            const { data: res } = await this.$http.put(
                `user/${user.id}/status/${user.status}`
            );

            if (res.status === 200) {
                this.$message.success(res.msg);
            } else {
                user.status = !user.status;
                this.$message.error(res.msg);
            }
        },
    },
};
</script>

<style lang="less" scoped></style>

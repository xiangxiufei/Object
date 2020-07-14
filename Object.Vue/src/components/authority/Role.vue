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
                    <el-button type="primary" @click="addDialogVisible = true">
                        添加角色
                    </el-button>
                </el-col>
            </el-row>

            <el-table :data="roleList" border stripe>
                <el-table-column type="expand">
                    <template slot-scope="scope">
                        <el-row
                            :class="[
                                'bdbottom',
                                i1 === 0 ? 'bdtop' : '',
                                'vcenter',
                            ]"
                            v-for="(item1, i1) in scope.row.children"
                            :key="item1.id"
                        >
                            <el-col :span="5">
                                <el-tag
                                    closable
                                    @close="deleteRoleMenu(scope.row, item1.id)"
                                >
                                    {{ item1.authName }}
                                </el-tag>
                                <i class="el-icon-caret-right"></i>
                            </el-col>
                            <el-col :span="19">
                                <el-row
                                    :class="[
                                        i2 === 0 ? '' : 'bdtop',
                                        'vcenter',
                                    ]"
                                    v-for="(item2, i2) in item1.children"
                                    :key="item2.id"
                                >
                                    <el-col :span="6">
                                        <el-tag
                                            type="success"
                                            closable
                                            @close="
                                                deleteRoleMenu(
                                                    scope.row,
                                                    item2.id
                                                )
                                            "
                                        >
                                            {{ item2.authName }}
                                        </el-tag>
                                        <i class="el-icon-caret-right"></i>
                                    </el-col>
                                    <el-col :span="18">
                                        <el-tag
                                            type="warning"
                                            v-for="item3 in item2.children"
                                            :key="item3.id"
                                            closable
                                            @close="
                                                deleteRoleMenu(
                                                    scope.row,
                                                    item3.id
                                                )
                                            "
                                        >
                                            {{ item3.authName }}
                                        </el-tag>
                                    </el-col>
                                </el-row>
                            </el-col>
                        </el-row>
                        <!-- <pre>{{ scope.row }}</pre> -->
                    </template>
                </el-table-column>
                <el-table-column type="index" label="#"></el-table-column>
                <el-table-column
                    label="角色名称"
                    prop="roleName"
                ></el-table-column>
                <el-table-column
                    label="角色描述"
                    prop="roleDesc"
                ></el-table-column>
                <el-table-column label="操作" width="300px">
                    <template slot-scope="scope">
                        <el-button
                            type="primary"
                            icon="el-icon-edit"
                            size="mini"
                            @click="showEditDialog(scope.row.id)"
                        >
                            编辑
                        </el-button>
                        <el-button
                            type="danger"
                            icon="el-icon-delete"
                            size="mini"
                            @click="deleteRole(scope.row.id)"
                        >
                            删除
                        </el-button>
                        <el-button
                            size="mini"
                            type="warning"
                            icon="el-icon-setting"
                            @click="showMenuDialog(scope.row)"
                        >
                            分配权限
                        </el-button>
                    </template>
                </el-table-column>
            </el-table>

            <el-dialog
                title="添加角色"
                :visible.sync="addDialogVisible"
                width="40%"
                @close="addDialogClosed"
            >
                <el-form
                    :model="addForm"
                    :rules="addFormRules"
                    ref="addFormRef"
                    label-width="80px"
                >
                    <el-form-item label="角色名称" prop="roleName">
                        <el-input v-model="addForm.roleName"></el-input>
                    </el-form-item>
                    <el-form-item label="角色描述" prop="roleDesc">
                        <el-input v-model="addForm.roleDesc"></el-input>
                    </el-form-item>
                </el-form>

                <span slot="footer" class="dialog-footer">
                    <el-button @click="addDialogVisible = false">
                        取 消
                    </el-button>
                    <el-button type="primary" @click="addRole">
                        确 定
                    </el-button>
                </span>
            </el-dialog>

            <el-dialog
                title="修改用户"
                :visible.sync="editDialogVisible"
                width="40%"
                @close="editDialogClosed"
            >
                <el-form
                    :model="editForm"
                    :rules="editFormRules"
                    ref="editFormRef"
                    label-width="80px"
                >
                    <el-form-item label="角色名称" prop="roleName">
                        <el-input v-model="editForm.roleName"></el-input>
                    </el-form-item>
                    <el-form-item label="角色描述" prop="roleDesc">
                        <el-input v-model="editForm.roleDesc"></el-input>
                    </el-form-item>
                </el-form>

                <span slot="footer" class="dialog-footer">
                    <el-button @click="editDialogVisible = false">
                        取 消
                    </el-button>
                    <el-button type="primary" @click="editRole">
                        确 定
                    </el-button>
                </span>
            </el-dialog>

            <el-dialog
                title="分配权限"
                :visible.sync="menuDialogVisible"
                width="40%"
                @close="menuDialogClosed"
            >
                <el-tree
                    :data="menuList"
                    :props="treeProps"
                    show-checkbox
                    node-key="id"
                    :default-checked-keys="defKeys"
                    ref="treeRef"
                ></el-tree>

                <span slot="footer" class="dialog-footer">
                    <el-button @click="menuDialogVisible = false">
                        取 消
                    </el-button>
                    <el-button type="primary" @click="allotMenu">
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
            roleList: [],
            addDialogVisible: false,
            addForm: {
                roleName: "",
                roleDesc: "",
            },
            addFormRules: {
                roleName: [
                    {
                        required: true,
                        message: "请输入角色名称",
                        trigger: "blur",
                    },
                ],
                roleDesc: [
                    {
                        required: true,
                        message: "请输入角色描述",
                        trigger: "blur",
                    },
                ],
            },
            editDialogVisible: false,
            editForm: {},
            editFormRules: {
                roleName: [
                    {
                        required: true,
                        message: "请输入角色名称",
                        trigger: "blur",
                    },
                ],
                roleDesc: [
                    {
                        required: true,
                        message: "请输入角色描述",
                        trigger: "blur",
                    },
                ],
            },
            menuDialogVisible: false,
            menuList: [],
            treeProps: {
                label: "authName",
                children: "children",
            },
            defKeys: [],
            roleId: "",
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
        addDialogClosed() {
            this.$refs.addFormRef.resetFields();
        },
        addRole() {
            this.$refs.addFormRef.validate(async (valid) => {
                if (!valid) return;

                const { data: res } = await this.$http.post(
                    "role",
                    this.addForm
                );

                if (res.status === 200) {
                    this.$message.success(res.msg);
                    this.addDialogVisible = false;
                    this.getRoleList();
                } else {
                    this.$message.error(res.msg);
                }
            });
        },
        async showEditDialog(id) {
            const { data: res } = await this.$http.get("role/" + id);

            if (res.status === 200) {
                this.editDialogVisible = true;
                this.editForm = res.data;
            } else {
                this.$message.error(res.msg);
            }
        },
        editDialogClosed() {
            this.$refs.editFormRef.resetFields();
        },
        editRole() {
            this.$refs.editFormRef.validate(async (valid) => {
                if (!valid) return;

                const { data: res } = await this.$http.put(
                    "role/" + this.editForm.id,
                    {
                        roleName: this.editForm.roleName,
                        roleDesc: this.editForm.roleDesc,
                    }
                );

                if (res.status === 200) {
                    this.$message.success(res.msg);
                    this.editDialogVisible = false;
                    this.getRoleList();
                } else {
                    this.$message.error(res.msg);
                }
            });
        },
        async deleteRole(id) {
            const confirmResult = await this.$confirm(
                "此操作将永久删除该角色, 是否继续?",
                "提示",
                {
                    confirmButtonText: "确定",
                    cancelButtonText: "取消",
                    type: "warning",
                }
            ).catch((error) => error);

            if (confirmResult == "confirm") {
                const { data: res } = await this.$http.delete("role/" + id);

                if (res.status === 200) {
                    this.$message.success(res.msg);
                    this.getRoleList();
                } else {
                    this.$message.error(res.msg);
                }
            } else {
                this.$message.info("已取消删除！");
            }
        },
        async deleteRoleMenu(role, menuId) {
            const confirmResult = await this.$confirm(
                "此操作将永久删除该角色权限, 是否继续?",
                "提示",
                {
                    confirmButtonText: "确定",
                    cancelButtonText: "取消",
                    type: "warning",
                }
            ).catch((error) => error);

            if (confirmResult == "confirm") {
                const { data: res } = await this.$http.delete(
                    `role/${role.id} /menu/${menuId}`
                );

                if (res.status === 200) {
                    this.$message.success(res.msg);
                    role.children = res.data.children;
                } else {
                    this.$message.error(res.msg);
                }
            } else {
                this.$message.info("已取消删除！");
            }
        },
        async showMenuDialog(role) {
            this.roleId = role.id;
            const { data: res } = await this.$http.get("menu/tree");

            if (res.status === 200) {
                this.menuList = res.data;
                this.getLeafKeys(role, this.defKeys);
            } else {
                this.$message.error(res.msg);
            }

            this.menuDialogVisible = true;
        },
        menuDialogClosed() {
            this.menuList = [];
            this.defKeys = [];
        },
        getLeafKeys(node, array) {
            if (node.children.length === 0) {
                return array.push(node.id);
            }

            node.children.forEach((item) => {
                this.getLeafKeys(item, array);
            });
        },
        async allotMenu() {
            const keys = [
                ...this.$refs.treeRef.getCheckedKeys(),
                ...this.$refs.treeRef.getHalfCheckedNodes(),
            ];

            const idStr = keys.join(",");

            const { data: res } = await this.$http.post(
                `role/${this.roleId} /menu/${idStr}`
            );

            if (res.status === 200) {
                this.$message.success(res.msg);
                this.getRoleList();
                this.menuDialogVisible = false;
            } else {
                this.$message.error(res.msg);
            }
        },
    },
};
</script>

<style lang="less" scoped>
.el-tag {
    margin: 7px;
}

.bdtop {
    border-top: 1px solid #eee;
}

.bdbottom {
    border-bottom: 1px solid #eee;
}

.vcenter {
    display: flex;
    align-items: center;
}
</style>

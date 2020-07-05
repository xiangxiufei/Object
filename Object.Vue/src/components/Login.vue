<template>
    <div class="login_container">
        <div class="login_box">
            <div class="avatar_box">
                <img src="../assets/logo.png" alt="" />
            </div>
            <el-form
                ref="loginFormRef"
                :model="loginForm"
                :rules="loginFormRules"
                class="login_form"
            >
                <el-form-item prop="username">
                    <el-input
                        v-model="loginForm.username"
                        prefix-icon="el-icon-user-solid"
                    ></el-input>
                </el-form-item>
                <el-form-item prop="password">
                    <el-input
                        v-model="loginForm.password"
                        prefix-icon="el-icon-lock"
                        type="password"
                    ></el-input>
                </el-form-item>
                <el-form-item class="btns">
                    <el-button type="primary" @click="login">登陆</el-button>
                    <el-button type="info" @click="reset">重置</el-button>
                </el-form-item>
            </el-form>
        </div>
    </div>
</template>

<script>
export default {
    data() {
        return {
            loginForm: {
                username: "admin",
                password: "123456",
            },
            loginFormRules: {
                username: [
                    {
                        required: true,
                        message: "请输入登陆账号",
                        trigger: "blur",
                    },
                    {
                        min: 4,
                        max: 12,
                        message: "长度在 4 到 12 个字符",
                        trigger: "blur",
                    },
                ],
                password: [
                    {
                        required: true,
                        message: "请输入登陆密码",
                        trigger: "blur",
                    },
                    {
                        min: 6,
                        max: 16,
                        message: "长度在 6 到 16 个字符",
                        trigger: "blur",
                    },
                ],
            },
        };
    },
    methods: {
        login() {
            this.$refs.loginFormRef.validate(async (valid) => {
                if (valid) {
                    const { data: res } = await this.$http.post(
                        "login",
                        this.loginForm
                    );

                    if (res.status === 200) {
                        this.$message.success(res.msg);
                        sessionStorage.setItem("token", res.data.token);
                        this.$router.push("/home");
                    } else {
                        this.$message.error(res.msg);
                    }
                }
            });
        },
        reset() {
            this.$refs.loginFormRef.resetFields();
        },
    },
};
</script>

<style lang="less" scoped>
.login_container {
    background-color: #2b4b6b;
    height: 100%;
}

.login_box {
    width: 450px;
    height: 300px;
    background-color: #fff;
    border-radius: 3px;
    position: absolute;
    left: 50%;
    top: 50%;
    transform: translate(-50%, -50%);

    .avatar_box {
        width: 130px;
        height: 130px;
        border: 1px solid #eee;
        border-radius: 50%;
        padding: 10px;
        box-shadow: 0 0 10px #ddd;
        position: absolute;
        left: 50%;
        transform: translate(-50%, -50%);
        background-color: #fff;

        img {
            width: 100%;
            height: 100%;
            border-radius: 50%;
            background-color: #eee;
        }
    }
}

.login_form {
    position: absolute;
    bottom: 0;
    width: 100%;
    padding: 0 20px;
    box-sizing: border-box;
}

.btns {
    display: flex;
    justify-content: flex-end;
}
</style>

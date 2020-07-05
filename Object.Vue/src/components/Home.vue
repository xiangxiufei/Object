<template>
    <el-container class="home-container">
        <el-header>
            <div>
                <img src="../assets/fei.jpg" alt="" />
                <span>Abp vNext - Vue Demo</span>
            </div>
            <el-button type="info" @click="logout">退出</el-button>
        </el-header>
        <el-container>
            <el-aside :width="isCollapse ? '64px' : '200px'">
                <div class="toggle-button" @click="toggleCollapse">|||</div>
                <el-menu
                    background-color="#333744"
                    text-color="#fff"
                    active-text-color="#409BFF"
                    unique-opened
                    :collapse="isCollapse"
                    :collapse-transition="false"
                    router
                    :default-active="activePath"
                >
                    <el-submenu
                        :index="item.id + ''"
                        v-for="item in menu"
                        :key="item.id"
                    >
                        <template slot="title">
                            <i :class="icons[item.id]"></i>
                            <span>{{ item.name }}</span>
                        </template>
                        <el-menu-item
                            :index="'/' + subItem.path"
                            v-for="subItem in item.children"
                            :key="subItem.id"
                            @click="saveNavState('/' + subItem.path)"
                        >
                            <i class="el-icon-menu"></i>
                            <span>{{ subItem.name }}</span></el-menu-item
                        >
                    </el-submenu>
                </el-menu>
            </el-aside>
            <el-main>
                <router-view></router-view>
            </el-main>
        </el-container>
    </el-container>
</template>

<script>
export default {
    data() {
        return {
            menu: [],
            icons: {
                101: "el-icon-s-goods",
                102: "el-icon-s-order",
                103: "el-icon-s-tools",
                125: "el-icon-s-custom",
                145: "el-icon-s-data",
            },
            isCollapse: false,
            activePath: "",
        };
    },
    created() {
        this.getMenuList();
        this.activePath = sessionStorage.getItem("activePath");
    },
    methods: {
        logout() {
            sessionStorage.clear();
            this.$router.push("/login");
        },
        async getMenuList() {
            const { data: res } = await this.$http.get("menu");

            if (res.status === 200) {
                this.menu = res.data;
            } else {
                this.$message.error(res.msg);
            }
        },
        toggleCollapse() {
            this.isCollapse = !this.isCollapse;
        },
        saveNavState(activePath) {
            sessionStorage.setItem("activePath", activePath);
            this.activePath = activePath;
        },
    },
};
</script>

<style lang="less" scoped>
.home-container {
    height: 100%;
}

.el-header {
    background-color: #373d41;
    display: flex;
    justify-content: space-between;
    padding-left: 5px;
    align-items: center;
    color: #fff;
    font-size: 20px;
    > div {
        display: flex;
        align-items: center;

        span {
            margin-left: 15px;
        }

        img {
            height: 50px;
            width: 50px;
            border-radius: 50%;
        }
    }
}

.el-aside {
    background-color: #333744;
    .el-menu {
        border-right: none;
    }
}

.el-main {
    background-color: #eaedf1;
}

.iconfont {
    margin-right: 10px;
}

.toggle-button {
    background-color: #4a5064;
    font-size: 10px;
    line-height: 24px;
    color: #fff;
    text-align: center;
    letter-spacing: 0.3em;
}
</style>

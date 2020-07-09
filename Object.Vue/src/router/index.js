import Vue from "vue";
import VueRouter from "vue-router";
import Login from "@/components/Login";
import Home from "@/components/Home";
import Welcome from "@/components/Welcome";
import User from "@/components/user/User";
import Right from "@/components/authority/Right";
import Role from "@/components/authority/Role";

Vue.use(VueRouter);

const routes = [
    { path: "/", redirect: "/login" },
    { path: "/login", component: Login },
    {
        path: "/home",
        component: Home,
        redirect: "/welcome",
        children: [
            { path: "/welcome", component: Welcome },
            { path: "/user", component: User },
            { path: "/role", component: Role },
            { path: "/right", component: Right },
        ],
    },
];

const router = new VueRouter({
    routes,
});

router.beforeEach((to, from, next) => {
    if (to.path === "/login") {
        next();
    } else {
        const token = sessionStorage.getItem("token");
        if (token) {
            next();
        } else {
            next("/login");
        }
    }
});

export default router;

const originalPush = VueRouter.prototype.push;
VueRouter.prototype.push = function push(location) {
    return originalPush.call(this, location).catch((err) => err);
};

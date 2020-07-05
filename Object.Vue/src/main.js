import Vue from "vue";
import App from "./App.vue";
import router from "./router";

import axios from "axios";
axios.defaults.baseURL = "https://localhost:5001/api/";
axios.interceptors.request.use((config) => {
    config.headers.Authorization = sessionStorage.getItem("token");
    return config;
});
Vue.prototype.$http = axios;

import "./plugins/element.js";
import "./assets/css/global.css";

Vue.config.productionTip = false;

new Vue({
    router,
    render: (h) => h(App),
}).$mount("#app");

import Navigo from "navigo";
import HomePage from "./page/home";
import newPageDetail from "./page/detailPost";
import Login from "./page/login";
import Signup from "./page/signup";
import Dashboard from "./page/admin/dashboard";
import Add from "./page/admin/news/add";
import NewsHome from "./page/admin/news";
import Edit from "./page/admin/news/edit";

const router = new Navigo("/", { linksSelector: "a" });
const print = (content) => {
    document.querySelector("#result").innerHTML = content;
};
router.on({
    "/": () => {
        print(HomePage.render());
    },
    "/home": () => {
        print(HomePage.render());
    },
    "/news/:id": (value) => {
        print(newPageDetail.render(value.data.id));
    },
    "/signup": () => {
        print(Signup.render());
    },
    "/signin": () => {
        print(Login.render());
    },
    "/admin/dashboard": () => {
        print(Dashboard.render());
    },
    "/admin/news": () => {
        print(NewsHome.render());
    },
    "/admin/news/add": () => {
        print(Add.render());
    },
    "/admin/news/:id/edit": () => {
        print(Edit.render());
    },
});
router.notFound(() => print("Not found in"));
router.resolve();

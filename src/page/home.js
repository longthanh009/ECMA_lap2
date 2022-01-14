import Banner from "../compoment/banner";
import Header from "../compoment/header";
import Footer from "../compoment/footer";
import newCompoment from "../compoment/news";

const HomePage = {
    render() {
        return /* html */`  
      ${Header.render()}
      ${Banner.render()}
      ${newCompoment.render()}
      ${Footer.render()}
      `;
    },
};
export default HomePage;

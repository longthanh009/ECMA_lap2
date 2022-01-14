import Footer from "../compoment/footer";
import Header from "../compoment/header";
import data from "../data";

const newPageDetail = {
    render(id) {
        const result = data.find((post) => post.id === id);
        return /* html */`
        ${Header.render()}
        <main>
        <div
            class="item border-[1px] border-solid border-[#ccc] pt-[10px] px-5">
            <img src="${result.img}" alt="" class="w-full">
            <div class="item-detail">
                <h3 class="text-[18px] font-medium"><a href=""
                    class="text-orange-600 hover:text-orange-900">${result.title}</a></h3>
                <p class="text-sm py-5 font-semibold">${result.desc}</p>
            </div>
            </div>
        </main>
        ${Footer.render()}
        `;
    },
};
export default newPageDetail;

import data from "../data";

const newCompoment = {
    render() {
        return /* html */`     <main class="mb-5">
        <div class="row newspan">
          <h2 class="text-[20px] font-bold text-indigo-900 py-[20px]">TIN TỨC HỌC
            TẬP</h2>
          <div class="grid w-full grid-cols-3 gap-5">
              ${data.map((post) => /* html */`
                  <div
                    class="item border-[1px] border-solid border-[#ccc] pt-[10px] px-5">
                    <img src="${post.img}" alt="" class="w-full">
                    <div class="item-detail">
                      <h3 class="text-[18px] font-medium"><a href="/news/${post.id}"
                          class="text-orange-600 hover:text-orange-900">${post.title}</a></h3>
                      <p class="text-sm py-5 font-semibold">${post.desc}
                      </p>
                    </div>
                  </div>
                        `).join("")}
          </div>
        </div>
      </main>`;
    },
};
export default newCompoment;

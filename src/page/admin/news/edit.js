import AdminHeader from "../../../compoment/adminHeader";

const Edit = {
    render() {
        return /* html */`
    ${AdminHeader.render()}
    <div class="mt-5 md:mt-0 md:col-span-2">
        <div class=" flex items-center justify-between pb-6 mt-10">
            <div>
                <h2 class="text-gray-600 font-semibold">Chỉnh sủa bài viết</h2>
            </div>
            <div class="lg:ml-40 ml-10 space-x-8">
                    <a href="/admin/news">
                        <button class="bg-indigo-600 px-4 py-2 rounded-md text-white font-semibold tracking-wide cursor-pointer">Back</button>
                    </a>
                </div>
            </div>
        </div>

        <form action="" method="post" class ="mb-12">
            <div class="md:flex items-center mt-12">
                <div class="w-full md:w-1/2 flex flex-col">
                <label class="font-semibold leading-none">ID</label>
                <input type="text"
                    class="leading-none text-gray-900 p-3 focus:outline-none focus:border-blue-700 mt-4 bg-gray-100 border rounded border-gray-200" />
                </div>
                <div class="w-full md:w-1/2 flex flex-col md:ml-6 md:mt-0 mt-4">
                <label class="font-semibold leading-none">Title</label>
                <input type="email"
                    class="leading-none text-gray-900 p-3 focus:outline-none focus:border-blue-700 mt-4 bg-gray-100 border rounded border-gray-200" />
                </div>
            </div>
            <div class="md:flex items-center mt-8">
                <div class="w-full flex flex-col">
                <label class="font-semibold leading-none">Image</label>
                <input type="file"
                    class="leading-none text-gray-900 p-3 focus:outline-none focus:border-blue-700 mt-4 bg-gray-100 border rounded border-gray-200" />
                </div>

            </div>
            <div>
                <div class="w-full flex flex-col mt-8">
                <label class="font-semibold leading-none">Description</label>
                <textarea type="text"
                    class="h-40 text-base leading-none text-gray-900 p-3 focus:oultine-none focus:border-blue-700 mt-4 bg-gray-100 border rounded border-gray-200"></textarea>
                </div>
            </div>
            <div class="flex items-center justify-center w-full">
                <button
                class="mt-9 font-semibold leading-none text-white py-4 px-10 bg-blue-700 rounded hover:bg-blue-600 focus:ring-2 focus:ring-offset-2 focus:ring-blue-700 focus:outline-none">
                Creat
                </button>
            </div>
        </form>
        </div>
        `;
    },
};
export default Edit;

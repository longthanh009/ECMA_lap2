const Header = {
    render() {
        return /* html */` <header>
        <div class="row bg-blue-900">
          <img src="./image/logo.png" alt=""
            class="object-cover w-[20%] mx-auto py-3">
        </div>
        <nav class="flex bg-orange-400 items-center">
          <ul class="flex w-2/3 justify-around items-center h-8">
            <li><a href="/home" class="text-white text-sm underline">Trang chủ</a></li>
            <li><a href="/news" class="text-white text-sm">Blogs</a></li>
            <li><a href="" class="text-white text-sm">Chương trình đào tạo</a></li>
            <li><a href="" class="text-white text-sm">Góc sinh viên</a></li>
            <li><a href="" class="text-white text-sm">Tuyển dụng</a></li>
            <li><a href="/signin" class="text-white text-sm">Đăng nhập </a></li>
          </ul>
          <div class="search-form w-1/2 text-right mr-2">
            <input type="text" name="" id="" class="w-[200px] mr-[10px]">
            <button type="submit"
              class="bg-blue-800 text-white text-sm h-[25px] px-[10px] border-solid border-white border-[2px]">Tìm
              kiếm</button>
          </div>
        </nav>
      </header>`;
    },
};
export default Header;

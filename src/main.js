import '../style.css'
const menuList = ['menu1','menu2','menu3'];
const ule = document.querySelector('#abc');
if (ule) {
  for(let i =0; i < menuList.length;i++) {
    ule.innerHTML +=`<li>${menuList[i]}</li>`;
  }
}
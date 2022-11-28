// for-each döngüsü

const PRODUCTS = ["laptop", "phone", "speaker", "desktop pc", "server", "mouse", "keyboard"]

// PRODUCTS.forEach(product => console.log(product)) // Liste içerisindeki elemanları alt alta yazdır
PRODUCTS.forEach((product, index, array) => array[index] = `${product.toUpperCase()}`) // Liste içerisindeki verileri büyük harfle yazdır

console.log(PRODUCTS)

/*
const userListDOM = document.querySelector("#userList")

for(index=0; index<users.length; index++){
    const liDOM = document.createElement("li")
    liDOM.innerHTML = users[index]
    userListDOM.appendChild(liDOM)
}
 */

const userListDOM = document.querySelector("#userList")

PRODUCTS.forEach(item =>{
    const liDOM = document.createElement("li")
    liDOM.innerHTML = users[index]
    userListDOM.appendChild(liDOM)
})

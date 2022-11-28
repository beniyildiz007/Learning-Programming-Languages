# index.html
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hello World</title>
</head>
<body>
    <h1>Frontend 101 Eğitimi - Hakan Yalçınkaya</h1>

    <h2 id="info"></h2>

    <ul class="list-group" id="userList">

    </ul>



    <script src="for-each.js"></script>

</body>
</html>
```
# for-each.js
```javascript
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

```

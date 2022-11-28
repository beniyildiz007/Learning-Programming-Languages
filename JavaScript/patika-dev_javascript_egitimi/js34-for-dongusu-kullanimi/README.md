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



    <script src="for-dongusu.js"></script>

</body>
</html>
```
# for-dongusu.js
```javascript
// For döngüsü

let users = ["Lorem", "Ipsum", "Dolor"]

// for (let index=0; index<10; index++){
//     console.log(index)
// }

// let index=0
// for(; index<10; index++){
//     console.log(index)
// }

const userListDOM = document.querySelector("#userList")

for(index=0; index<users.length; index++){
    const liDOM = document.createElement("li")
    liDOM.innerHTML = users[index]
    userListDOM.appendChild(liDOM)
}

```

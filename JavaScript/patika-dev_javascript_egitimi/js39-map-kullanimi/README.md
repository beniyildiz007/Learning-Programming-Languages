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




    <script src="map.js"></script>

</body>
</html>
```
# map.js
```javascript
// array map kullanımı

const USERS = ["AYŞE", "MehMet", "TugÇe", "akSeL"]

// userName içinde orjinal isim kalsın,
// shortName içinde ilk harf büyük ve nokta olsun (A.)
// newName içinde ilk harf büyük olsun
// {username: "AYŞE", shortName: "A.", newName: "Ayşe"}

const NEW_USERS = USERS.map(user => user.toLowerCase())
console.log(NEW_USERS)

// const USERS_OBJ = USERS.map( item =>
//     {
//         return{
//             userName: item, shortName: `${item[0]}.`, newName: `${item[0].toUpperCase()}${item.slice(1).toLowerCase()}`
//         }
//     }
// )

// Yukarıdakinin 2. yazım versiyonu:

const USERS_OBJ = USERS.map(item => (
        {
            userName: item, shortName: `${item[0]}.`, newName: `${item[0].toUpperCase()}${item.slice(1).toLowerCase()}`
        }
    )
)

console.log(USERS_OBJ)
```

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



    <script src="filter.js"></script>

</body>
</html>
```
# ornek.js
```javascript
// Array filter kullanımı

const PRODUCTS = ["laptop", "phone", "speaker", "desktop pc", "server", "mouse", "keyboard"]

// 5 harften fazla olanları yazdır

const NEW_PRODUCTS = PRODUCTS.filter(item => item.length > 5)
console.log(NEW_PRODUCTS)


const USERS = [
    {fullName: "Ayşe Sümer", isActive: false},
    {fullName: "Ahmet Urgan", isActive: true},
    {fullName: "Asya Başar", isActive: true},
    {fullName: "Aksel Durmaz", isActive: false}
]

// sadece aktif kullanıcıları yazdır:
// const ACTIVE_USERS = USERS.filter(user => user.isActive===true)
const ACTIVE_USERS = USERS.filter(user => user.isActive) // Aynı işlem kısa yazım
console.log(ACTIVE_USERS)
```

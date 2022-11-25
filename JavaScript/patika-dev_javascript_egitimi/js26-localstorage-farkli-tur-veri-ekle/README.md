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




    <script src="localstorage-farkli-tur-veri.js"></script>

</body>
</html>

```

# localstorage-farkli-tur-veri.js

```javascript

// Local Storage işlemleri:

let user={userName:"berkannihatyildiz", isActive: true}
console.log(user)
localStorage.setItem("userInfo",JSON.stringify(user)) // Önce bütün değerleri string yaptık

let userInfo=localStorage.getItem("userInfo") // Bilgiyi alıyoruz
userInfo=JSON.parse(userInfo) // Şimdi de string olan bütün değerleri parçalıyoruz
console.log(userInfo)

```

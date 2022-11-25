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







    <script src="kosul.js"></script>

</body>
</html>

```

# kosul.js

```javascript

// Koşullarla Çalışmak:

let username=prompt("Kullanıcı Adınızı Giriniz:")

// eğer kullanıcı adı bilgisi varsa ekrana ismini yazdır
// eğer (username.length>0) {console.log(username)} değilse {console.log("Hiçbir bilgi girilmedi")}
// if (username.length>0) {console.log(username)} else {console.log("Hiçbir bilgi girilmedi")}

if(username){ // if tarafı her zaman true ile çalışır
    console.log(`Kullanıcı Bilginiz ${username}`)
} else{
    console.log("Hiçbir bilgi girilmedi!")
}

```

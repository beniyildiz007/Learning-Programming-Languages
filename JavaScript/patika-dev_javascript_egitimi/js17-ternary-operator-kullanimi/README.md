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




    <script src="ternary.js"></script>

</body>
</html>

```

# ternary.js.js

```javascript

// Ternary operator ile short if kullanımı:

// Eğer kullanıcı adın varsa yazdır yoksa 'kullanıcı bilginiz bulunamadı' yazsın

let userName=prompt("Kullanıcı adınızı giriniz:")
let info=document.querySelector("#info")

// ternary kullanımı:
// koşul ? doğruysa : yanlışsa

// userName ? userName : "Kullanıcı Bilginiz Bulunamadı!"

info.innerHTML=`${userName ? userName : "Kullanıcı Bilginiz Bulunamadı! :/"}`

```

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









    <script src="coklu-kosul.js"></script>

</body>
</html>

```

# coklu-kosul.js

```javascript

// Çoklu Koşullar ile Çalışmak:

let userName=prompt("Kullanıcı Adınız: ")
let age=prompt("Yaşınız: ")

if(!userName){
    console.log("Kullanıcı adı girilmedi!")
}else if(!age){
    console.log("Yaş bilgisi girilmedi!")
}else{
    if(age>=18){
        console.log("Ehliyet alabilirsiniz.")
    }else{
        console.log("Biraz büyü evlat!")
    }
}

```

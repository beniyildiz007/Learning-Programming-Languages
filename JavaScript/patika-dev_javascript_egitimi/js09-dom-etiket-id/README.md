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

    <h2 id="title">Merhaba Dünya</h2>
    
    <ul>
        <li>
            <a href="#" id="kodluyoruzLink">Link Bilgisi</a>
        </li>
    </ul>




    <script src="etiket-id-oge.js"></script>
</body>
</html>

```

# etiket-id-oge.js

```javascript

// DOM içinden öge seçimi

let title = document.getElementById("title")
title.innerHTML="Değişen Bilgi" // 'Merhaba Dünya' yazısını değiştirdik
console.log(title.innerHTML)

let link=document.querySelector("#kodluyoruzLink")
link.innerHTML+=" değişti" // linkin yazısına ekleme yaptık
link.style.color="red" // linkin rengini kırmızı yaptık
link.classList.add("btn") // linki btn class'ına ekledik

```

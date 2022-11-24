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

    <ul id="list">
        <li>Lorem.</li>
        <li>Nihil?</li>
        <li>Autem?</li>
    </ul>

    <script src="liste.js"></script>

</body>
</html>

```

# liste.js

```javascript

// Liste içerisindeki son elemana ulaşmak veya listeye eleman eklemek:

// Liste içerisindeki elemanları değiştirmek:
let lastChild=document.querySelector("ul#list>li:last-child")
lastChild.innerHTML="<b>son öge değiştirildi!</b>"

let firstChild=document.querySelector("ul#list>li:first-child")
firstChild.innerHTML="<i>ilk öge değiştirildi!</i>"


// Listeye eleman eklemek:
let ulDOM=document.querySelector("ul#list")
let liDOM=document.createElement("li")

liDOM.innerHTML="<span style='color:red;'>Kendi oluşturduğumuz öge!</span>" // Henüz eklenmedi, sadece oluşturuldu!

// ulDOM.append(liDOM) // en sona ekler
ulDOM.prepend(liDOM) // ilk başa ekler


```

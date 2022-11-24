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
    <h1 id="greeting">Frontend 101 Eğitimi - Hakan Yalçınkaya</h1>

    <script src="prompt.js"></script>

</body>
</html>

```

# prompt.js

```javascript

// Promt ile kullanıcıdan bilgi almak:

let fullName=prompt("Lütfen Adınızı Giriniz: ")

let greeting=document.querySelector("#greeting")

greeting.innerHTML=`${greeting.innerHTML} <span style="color:red;">${fullName}</span>`

```

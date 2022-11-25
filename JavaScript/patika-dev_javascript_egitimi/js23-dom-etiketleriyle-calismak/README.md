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

    <h2 id="info"></h2>




    <script src="dom-etkinlikleri.js"></script>

</body>
</html>

```

# dom-etkinlikleri.js

```javascript

// DOM etkinlikleriyle çalışmak:

let greeting = document.querySelector("#greeting")
greeting.addEventListener("click",domClick)

function domClick(){
    console.log("etkinlik denetlendi")
    this.style.color=="red" ? this.style.color="black" : this.style.color="red"
} // this => buradaki, burası, burasının anlamlarına gelir

```

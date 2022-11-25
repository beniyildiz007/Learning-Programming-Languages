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

    <h3 id="counter">100</h3>
    <button id="inc">Arttır</button>
    <button id="dec">Azalt</button>




    <script src="fonksiyon-egzersiz.js"></script>

</body>
</html>

```

# fonksiyon-egzersiz.js

```javascript

// Functions Bölüm Sonu Egzersizi

let counter = 0
let counterDOM = document.querySelector("#counter")
let incDOM = document.querySelector("#inc")
let decDOM = document.querySelector("#dec")

counterDOM.innerHTML=counter

incDOM.addEventListener("click", clickEvent)
decDOM.addEventListener("click", clickEvent)

function clickEvent(){
    console.log(this.id)
    this.id=="inc" ? counterDOM.innerHTML = counter+=1 : counterDOM.innerHTML = counter-=1

}

```

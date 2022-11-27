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




    <script src="localstorage-egzersiz.js"></script>

</body>
</html>

```
# localstorage-egzersiz.js
```javascript

// Local Storage Bölüm Sonu Egzersizi:


let counter=localStorage.getItem("counter") ? Number(localStorage.getItem("counter")) : 0
// ↑↑ Sayfa yenilendiğinde eğer yerel deoplamada counter bilgisi varsa onu al, yoksa 0 al.

let counterDOM=document.querySelector("#counter")
let incDOM=document.querySelector("#inc")
let decDOM=document.querySelector("#dec")

counterDOM.innerHTML=counter

incDOM.addEventListener("click", clickEvent)
decDOM.addEventListener("click", clickEvent)

function clickEvent(){
    this.id=="inc" ? counter+=1 : counter-=1
    localStorage.setItem("counter",counter)
    counterDOM.innerHTML=counter
}

```

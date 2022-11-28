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

    <ul class="list-group" id="userList">

    </ul>



    <script src="break-countinue.js"></script>

</body>
</html>
```
# break-continue.js
```javascript
// break & continue

const LOREM_LIST = [
    "lorem","ipsum","dolor","amet","consec","adipis","elit"
]

let counter = 0

// for(; counter<10; counter++){
//     console.log(counter)
//     if (counter===5) {break} // counter=5 olunca döngüyü kır
// }

// for (; counter<10; counter++){
//     if(counter===5){continue} // counter=5 olunca atla diğer sayıları yazdır
//     console.log(counter)
// }

const UL_DOM = document.querySelector("#userList")

let index = 0;

// for (; index<LOREM_LIST.length; index++){
//     if(LOREM_LIST[index]=="dolor"){break}
//     let LI_DOM= document.createElement("li")
//     LI_DOM.innerHTML = LOREM_LIST[index]
//     UL_DOM.append(LI_DOM)
// }

for (; index<LOREM_LIST.length; index++){
    if(LOREM_LIST[index]=="dolor"){continue}
    let LI_DOM= document.createElement("li")
    LI_DOM.innerHTML = LOREM_LIST[index]
    UL_DOM.append(LI_DOM)
}


```

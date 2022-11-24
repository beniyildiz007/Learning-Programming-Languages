# index.html

```html

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hello World</title>
    <style>
        .text-primary{
            color: blue;
        }
    </style>
</head>
<body>
    <h1 id="greeting">Frontend 101 Eğitimi - Hakan Yalçınkaya</h1>




    <script src="class.js"></script>

</body>
</html>

```

# class.js

```javascript

// CSS Class eklemek ve çıkarmak:

let greeting=document.querySelector("#greeting")

greeting.classList.add("text-primary") // greeting ögesine text-primary class'ını ekledik
greeting.classList.add("title") // greeting ögesine title class'ını ekledik
greeting.classList.add("first-class","second-class","third-class") // tek satırda birden fazla class ekledik

greeting.classList.remove("title") // greeting ögesinden title class'ını çıkardık
greeting.classList.remove("second-class","third-class") // tek satırda 2 class birden çıkardık

console.log(greeting.classList)

```

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




    <script src="fat-arrow.js"></script>

</body>
</html>

```

# fat-arrow.js

```javascript

// Fat Arrow function kullanımı

function hello(firstName){
    console.log(`Merhaba ${firstName}`)
}

hello("JavaScript") // Output => Merhaba JavaScript

const helloFuncV1=(firstName)=>{console.log(`Merhaba ${firstName}`)}
helloFuncV1("helloFuncV1")

// Eğer tek parametre ve tek dönüş varsa parantezler kullanılmayabilir:
const helloFuncV2=firstName=>console.log(`Merhaba ${firstName}`)
helloFuncV2("helloFuncV2")

const helloFuncV3=(firstName,lastName) => console.log(
    `Merhaba ${firstName} ${lastName}`
) // console.log parantezi

helloFuncV3("helloFuncV3","Last Name info")

const helloFuncV4=(firstName,lastName) => {
    let info = `Merhaba ${firstName} ${lastName}`
    console.log(info)
    return info
}

helloFuncV4("helloFuncV4","Other Info")

```

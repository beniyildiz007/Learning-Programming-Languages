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



    <script src="switch-case.js"></script>

</body>
</html>

```

# switch-case.js

```javascript

// Switch - Case Yapısı:
/*
switch(ifade) {
    case a:
      // kod bloğu
      break;
    case b:
      // kod bloğu
      break;
    default:
      // kod bloğu
}*/

// Switch-case örnek:

let hava="Güneşli";
switch(hava){
    case "Yağmurlu":
        console.log("Şemsiyeni yanına almayı unutma!");
        break;
    case "Güneşli":
        console.log("Hafif giyin!");
        break;
    case "Bulutlu":
        console.log("Dikkatli ol!");
        break;
    case "Karlı":
        console.log("Kalın giyin!");
        break;
    case "Fırtınalı":
        console.log("Bir süre dışarı çıkma!");
        break;
    default:
        console.log("Bilinmeyen hava durumu: ",hava);    
}

let islem=function(a,b,operator){
    switch(operator){
        case "topla":
            return a+b;
        case "cikar":
            return a-b;
        case "carp":
            return a*b;
        case "bol":
            return a/b;
        default:
            return "Tanımlanmamış İşlem";
    }
};
console.log(islem(23,14,"topla")); // Output => 37
console.log(islem(10,3,"mod")); // Output => Tanımlanmamış işlem



```

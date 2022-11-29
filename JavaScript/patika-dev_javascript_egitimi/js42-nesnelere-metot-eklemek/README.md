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




    <script src="nesne-metot.js"></script>

</body>
</html>
```
# nesne-metot.js
```javascript
// Object içinde metot nasıl ekleriz

let user1 = {
    firstName: "Bilgin",
    lastName: "Uzman",
    score: [1,2,3,4],
    isActive: true,
    shortName: function(){
        return `${this.firstName[0].toUpperCase()}. ${this.lastName}`
    }
};

console.log(user1)
```

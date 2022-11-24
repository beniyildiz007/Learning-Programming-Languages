# index.html

```html

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hello World</title>
    <script src="string.js"></script>
</head>
<body>
    <h1>Frontend 101 Eğitimi - Hakan Yalçınkaya</h1>
</body>
</html>

```

```javascript

// String veri türü işlemleri:

let email="berkanyildiz@gmail.com"
let firstName="berkan"
let lastName="YILDIZ"

// string karakter sayısı => length
console.log(email.length)

// İlk karakteri bulmak => [0]:
console.log(firstName[0]) // Output => b
console.log(firstName.charAt(0)) // Output => b

// Büyük / Küçük harf:
firstName=firstName.toUpperCase()
console.log(firstName)

firstName=firstName.toLowerCase()
console.log(firstName)

// String içinde istediğimiz bilgiyi aramak ver yerini bulmak => search:
console.log(email.search("@")) // Output => @
console.log(email[12]) // Output => @

console.log(email.search("olmayan")) // Output => -1

// Belli bir yere kadarını al => slice:
console.log(email.slice(10)) // Output => iz@gmail.com
console.log(email.slice(10,11)) // Output => i
let DOMAIN=email.slice(email.search("@")+1)
console.log(DOMAIN) // Output => gmail.com

console.log(
    DOMAIN.slice(0, DOMAIN.indexOf('.')) // Sadece gmail kısmını aldık
)

// Bilgiyi değiştir => replace:
email=email.replace("gmail.com","kodluyoruz.org")
console.log(email)

// İstediğim bilgi var mı? => includes:
email.includes("awopkdapodks") // false
email.includes("@") // true

// İstediğim bilgiyle başladı mı? => startsWith / bitti mi? => endsWith
console.log(
    email.endsWith("kodluyoruz.org") // True
)
console.log(
    email.endsWith("kodluyoruz.com") // False
)
console.log(
    email.startsWith("berkan") // True
)
console.log(
    email.startsWith("yildiz") // False
)

// İlk harflerini büyük yapmak:
firstName="FIRST"
lastName="LAST"
let fullName=`${firstName[0].toUpperCase()}${firstName.slice(1).toLowerCase()}
${lastName[0].toUpperCase()}${lastName.slice(1).toLowerCase()}
`
console.log(fullName)
// Output:
// "First"
// "Last"

```

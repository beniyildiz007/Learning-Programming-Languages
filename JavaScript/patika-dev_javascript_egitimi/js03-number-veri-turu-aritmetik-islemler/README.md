# index.html
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hello World</title>
    <script src="number-veri-turu.js"></script>
</head>
<body>
    <h1>Frontend 101 Eğitimi - Hakan Yalçınkaya</h1>
</body>
</html>

```
# number-veri-turu.js
```javascript
// number veri türü tanımlamak:
let price=100;
let tax=0.08;
let priceTax=price*tax;
let total=price+priceTax;
console.log(
    "Fiyat: ",price,
    "KDV Oranı: ",tax,
    "KDV Tutarı: ",priceTax,
    "Nihai Fiyat: ",total
);

// String veriyi sayıya dönüştürmek:
let stringNumber="11"
console.log(stringNumber) // Output => "11"
let newNumber=Number(stringNumber) 
console.log(newNumber) // Output => 11
console.log("Number Constructor içine bilgi gönderildi: ",Number("1052"))

// arttırma ve azaltma işlemleri:
let counter=300;
counter=counter+1; //Uzun Yöntem
counter+=1;
counter ++;
console.log(counter);

counter --;
counter-=1;
console.log(counter);

counter*=10;
console.log(counter);

counter/=10;
console.log(counter);

// İşlem önceliği:
console.log(2+3*10) // Çarpma işlem önceliği => 32
console.log((2+3)*10) // => 50

// mod(kalan %) almak:
console.log(17%2) // 17'nin 2'ye bölümünden kalan 1 olduğu için output => 1

// 18 tane ürünü 8'lik kolilere koyarsak kaç ürün dışarıda kalır?
console.log(18%8) // Output => 2

// Üs almak:
console.log(2*2*2*2) // (2 üssü 4) uzun yazmak --- Output => 16
console.log(2**4) // (2 üssü 4) kısa versiyon --- Output => 16

// Aşağı yuvarlama işlemi => Math.floor:
console.log("Aşağı yuvarlama: ",Math.floor(1.9)) // Output => 1

// Yukarı yuvarlama işlemi => Math.ceil:
console.log("Yukarı yuvarlama: ",Math.ceil(1.1)) // Output => 2

// Yakına yuvarlama işlemi => Math.round:
console.log("Yakına yuvarlama: ",Math.round(1.4)) // Output => 1
console.log("Yakına yuvarlama: ",Math.round(1.5)) // Output => 2


```

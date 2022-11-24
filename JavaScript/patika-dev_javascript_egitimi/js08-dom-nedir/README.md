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
<body id="body">
    <h1>Frontend 101 Eğitimi - Hakan Yalçınkaya</h1>
    <script src="dom-nedir.js"></script>
</body>
</html>

```

# dom-nedir.js
```javascript

// pathname
console.log(document.location.pathname) // dosya yolunu verir

console.log(document.head) // Head tagları arasında yer alan kısmı yazar
console.log(document.body) // Body tagları arasında yer alan kısmı yazar

console.log(document.URL) // URL adresini yazar
console.log(document.baseURI) // URI adresini yazar

document.body.style.backgroundColor = "aqua"; // Sitenin arkaplanını aqua yaptık
/*
Buraya bir not düşmek istiyorum, en son yazdığım bu kod çalışmadı.
Önce body sonra style tanımlanamadı falan dedi. Stackoverflow üzerinden araştırında çözümü buldum.
Script dosyalarını HTML sayfasında nereye yazdığınız burada büyük önem taşıyor.
Eğer head tagları arasına yazarsanız javascript dosyası sisteme yüklendiği esnada
henüz body elementi devreye girmemiş olduğu için onu tanımıyor ve doğal olarak style özelliği de veremiyor.
Bu sebeple script dosyalarını her zaman body etiketinin içerisine ve en sonuna yazmak gerekiyor.
*/

```

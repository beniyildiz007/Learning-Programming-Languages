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
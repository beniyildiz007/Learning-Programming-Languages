// ***var ile değişken tanımlamak:
var sitemiz="api.kodluyoruz.org";
console.log(sitemiz);

// let ile değişkeni boş tanımlamak ve sonrasında değer atamak
let sitemiz1;
console.log(sitemiz1);
sitemiz1="https://kodluyoruz.org";
console.log(sitemiz1);

// let ile değişkene bilgi atayarak tanımlamak:
let password="1234";
console.log(password);

// değişken ataması yapmadan önce kullanmaya çalışmak:
// HATALI KULLANIM!!!
console.log(fullName);
let fullName="Berkan Nihat Yıldız";
// DOĞRU KULLANIM
let fullName1="Berkan Nihat Yıldız";
console.log(fullName1);

// let ile tanımlanan değişkenin içindeki bilgiyi değiştirmek:
let lastName="Yıldız";
lastName="lorem Ipsum Dolor";
console.log(fullName);

// let ile birleştirme ve ekleme işlemi:
 let textStart="Paragraf girişi";
 console.log(textStart+" ve devamı");

 textStart+=" ve devamı";
 console.log(textStart);

//  const ile değişken boş tanımlanamaz!!!:
const SERVER_PASSWORD;//HATAA!!!

// const ile değişkenin değeri DEĞİŞTİRİLEMEZ!!!:
const SERVER_PASSWORD1="12345";
SERVER_PASSWORD1="123";//HATA!!!
console.log(SERVER_PASSWORD1);

// const ile yalnızca bir kez değer atanan ve değiştirilemeyecek bilgiler tanımlanır:
const SERVER_PASSWORD2="12345";
console.log(SERVER_PASSWORD2);
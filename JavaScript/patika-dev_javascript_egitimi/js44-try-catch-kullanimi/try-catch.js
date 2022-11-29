// hata yönetimi için try catch kullanımı

let products;

try{
    products.forEach(item => console.log(item));
} catch(hataaa){
    console.log("Kodun içine ettin bak!")
    products = [1,2,3]
    products.forEach(item => console.log(item));
}

console.log("hata ytönetimi düzgün çalışıyor")

let info = "kodluyoruz"
console.log(info)
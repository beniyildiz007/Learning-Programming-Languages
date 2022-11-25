// İlk fonksiyonumuzu tanımlamak:

function helloWorld(){ // fonksiyon tanımlandı
    console.log("Hello World")
}

function hello(){
    console.log("Merhaba")
    helloWorld() // fonksiyon içerisinde bir başka fonksiyon çağırılabilir
}

hello() // Fonksiyonu çalıştırmak için çağırmamız gerekir
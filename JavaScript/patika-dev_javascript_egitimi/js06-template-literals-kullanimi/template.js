// Template Literals Kullanımı:

let username="berkan"
const DOMAIN="kodluyoruz.org"

let email=username+"@"+DOMAIN

// Uzun versiyon:
console.log("Merhaba",username,"sitemize hoşgeldin","email adresin: ",email)
// Output => Merhaba berkan sitemize hoşgeldin email adresin:  berkan@kodluyoruz.org


// Template Literals versiyonu:
let info=`
Merhaba ${username} sitemize hoşgeldin...
mail adresin: ${email}

mail adresinin uzunluğu: ${email.length}
borcunuz: ${(2+3)*10} TL
günün saat bilgisi: ${new Date().getHours()}

kısa isminiz: ${username[0]}.
`
console.log(info)
/* Output

Merhaba berkan sitemize hoşgeldin...
mail adresin: berkan@kodluyoruz.org

mail adresinin uzunluğu: 21
borcunuz: 50 TL
günün saat bilgisi: 14

kısa isminiz: b.

*/
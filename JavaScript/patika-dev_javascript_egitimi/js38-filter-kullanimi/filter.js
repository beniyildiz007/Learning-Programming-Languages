// Array filter kullanımı

const PRODUCTS = ["laptop", "phone", "speaker", "desktop pc", "server", "mouse", "keyboard"]

// 5 harften fazla olanları yazdır

const NEW_PRODUCTS = PRODUCTS.filter(item => item.length > 5)
console.log(NEW_PRODUCTS)


const USERS = [
    {fullName: "Ayşe Sümer", isActive: false},
    {fullName: "Ahmet Urgan", isActive: true},
    {fullName: "Asya Başar", isActive: true},
    {fullName: "Aksel Durmaz", isActive: false}
]

// sadece aktif kullanıcıları yazdır:
// const ACTIVE_USERS = USERS.filter(user => user.isActive===true)
const ACTIVE_USERS = USERS.filter(user => user.isActive) // Aynı işlem kısa yazım
console.log(ACTIVE_USERS)
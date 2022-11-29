// Object ve array destructuring nasıl kullanılır:

// object destructuring:

let settings = {
    userName: "loremIpsum",
    password: "BadPassword",
    isActive: false,
    ip: "127.0.0.1",
    serverName: "kodluyoruz.org"
}

// obje içindeki bilgilerin tek seferde çıkarılması
// let userName = settings.userName
// console.log(userName) // Output => loremIpsum

// renawme && destructuring
let {userName: user, password, isActive, ip:serverIP, serverName} = settings
console.log(user,password,isActive,serverIP,serverName)
console.log(settings)
console.log(user)

// obje içindeki bazı bilgilerin çıkarılması
let {userName:userName2, password:password2, isActive:isActive2, ...newSettings} = settings
// eğer değişken ismi daha önce tanımlanmadıysa:
// let {userName, password, isActive, ...newSettings} = settings

console.log(userName2, password2, isActive2, newSettings)

// objenin destructuring ile kopyalanması


// HATALI!!!!
// let settings2 = settings
// settings2.userName = "Değişen Bilgi"
// console.log("settings", settings)
// console.log("settings2", settings2)


// DOĞRUSU:
let settings2 = {...settings}
settings2.userName = "Değişen Bilgi"
console.log("settings", settings)
console.log("settings2", settings2)

let score = [100,200,300,400]

let [score1, score2, ...otherScore] = score
console.log(score1, score2, otherScore)

// object kopyalama ile aynı...
let copyOfScore = [...score]
console.log(copyOfScore)
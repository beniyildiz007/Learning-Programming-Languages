// array map kullanımı

const USERS = ["AYŞE", "MehMet", "TugÇe", "akSeL"]

// userName içinde orjinal isim kalsın,
// shortName içinde ilk harf büyük ve nokta olsun (A.)
// newName içinde ilk harf büyük olsun
// {username: "AYŞE", shortName: "A.", newName: "Ayşe"}

const NEW_USERS = USERS.map(user => user.toLowerCase())
console.log(NEW_USERS)

// const USERS_OBJ = USERS.map( item =>
//     {
//         return{
//             userName: item, shortName: `${item[0]}.`, newName: `${item[0].toUpperCase()}${item.slice(1).toLowerCase()}`
//         }
//     }
// )

// Yukarıdakinin 2. yazım versiyonu:

const USERS_OBJ = USERS.map(item => (
        {
            userName: item, shortName: `${item[0]}.`, newName: `${item[0].toUpperCase()}${item.slice(1).toLowerCase()}`
        }
    )
)

console.log(USERS_OBJ)
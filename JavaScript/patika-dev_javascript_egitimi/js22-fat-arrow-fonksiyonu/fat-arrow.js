// Fat Arrow function kullanımı

function hello(firstName){
    console.log(`Merhaba ${firstName}`)
}

hello("JavaScript") // Output => Merhaba JavaScript

const helloFuncV1=(firstName)=>{console.log(`Merhaba ${firstName}`)}
helloFuncV1("helloFuncV1")

// Eğer tek parametre ve tek dönüş varsa parantezler kullanılmayabilir:
const helloFuncV2=firstName=>console.log(`Merhaba ${firstName}`)
helloFuncV2("helloFuncV2")

const helloFuncV3=(firstName,lastName) => console.log(
    `Merhaba ${firstName} ${lastName}`
) // console.log parantezi

helloFuncV3("helloFuncV3","Last Name info")

const helloFuncV4=(firstName,lastName) => {
    let info = `Merhaba ${firstName} ${lastName}`
    console.log(info)
    return info
}

helloFuncV4("helloFuncV4","Other Info")
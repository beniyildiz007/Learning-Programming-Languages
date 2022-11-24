// CSS Class eklemek ve çıkarmak:

let greeting=document.querySelector("#greeting")

greeting.classList.add("text-primary") // greeting ögesine text-primary class'ını ekledik
greeting.classList.add("title") // greeting ögesine title class'ını ekledik
greeting.classList.add("first-class","second-class","third-class") // tek satırda birden fazla class ekledik

greeting.classList.remove("title") // greeting ögesinden title class'ını çıkardık
greeting.classList.remove("second-class","third-class") // tek satırda 2 class birden çıkardık

console.log(greeting.classList)
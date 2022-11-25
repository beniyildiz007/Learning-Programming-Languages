// Local Storage işlemleri:

let user={userName:"berkannihatyildiz", isActive: true}
console.log(user)
localStorage.setItem("userInfo",JSON.stringify(user)) // Önce bütün değerleri string yaptık

let userInfo=localStorage.getItem("userInfo") // Bilgiyi alıyoruz
userInfo=JSON.parse(userInfo) // Şimdi de string olan bütün değerleri parçalıyoruz
console.log(userInfo)
# index.html
```html

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hello World</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous">
</head>
<body>

    <div id="alert"></div>

    <h1 id="greeting">Frontend 101 Eğitimi - Hakan Yalçınkaya</h1>

    <h2 id="info"></h2>

    <div class="container mt-5">
        <div class="row">
            <div class="col-sm-8 offset-sm-2">
                <form id="userForm">
                    <div class="mb-3">
                        <label for="username" class="form-label">Kullanıcı Adı</label>
                        <input type="text" class="form-control" name="username" id="username">
                    </div>
                    <div class="mb-3">
                        <label for="username" class="form-label">Not Bilgisi</label>
                        <input type="number" class="form-control" name="score" id="score">
                    </div>
                    <div class="mb-3">
                        <button type="reset" class="btn btn-danger">Sıfırla</button>
                        <button type="submit" class="btn btn-success">Gönder</button>    
                    </div>
                </form>
            </div>
            <div class="col-sm-8 offset-sm-2 mt-4">
                <ul class="list-group" id="userList">

                </ul>
            </div>
        </div>
    </div>




    <script src="formlar-egzersiz.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" crossorigin="anonymous"></script>

</body>
</html>

```
# formlar-egzersiz.js
```javascript

// Formlarla Çalışmak: Bölüm Sonu Egzersizi

/*
1-) Formu seç
2-) Input bilgisini URL içerisine ekle
3-) Form içerisindeki bilgiyi sıfırla
4-) Eğer forma bilgi girilmezse kullanıcıyı uyar!
*/

let userFormDOM=document.querySelector("#userForm")
userFormDOM.addEventListener("submit",formHandler)
const alertDOM=document.querySelector("#alert")

const alertFunction=(title, message, className="warning") =>`
<div class="alert alert-${className} alert-dismissible fade show" role="alert">
    <strong>${title}}</strong> ${message}
    <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
</div>
`

function formHandler(event){
    event.preventDefault()
    const USER_NAME=document.querySelector("#username")
    const SCORE=document.querySelector("#score")

    if (USER_NAME.value && SCORE.value){
        addItem(USER_NAME.value, SCORE.value)
        USER_NAME.value=""
        SCORE.value="" // formu gönderdikten sonra değerleri sıfırladık
    }else{
        alertDOM.innerHTML=alertFunction(
            "Başlık Bilgisi",
            "Eksik bilgi girdiniz!",
            "danger"
        )
    }

}

let userListDOM=document.querySelector("#userList")

const addItem=(userName, score) => {
    let liDOM=document.createElement("li")
    liDOM.innerHTML=`
        ${userName}
        <span class="badge bg-primary rounded-pill">${score}</span>
    `
    liDOM.classList.add(
        "list-group-item","d-flex","justify-content-between","align-items-center"
    )
    userListDOM.append(liDOM)
}

```

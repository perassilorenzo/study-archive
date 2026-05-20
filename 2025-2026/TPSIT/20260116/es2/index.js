let secretNumber;
let number;
const textDiv = document.getElementById("text");

function generate(){
    secretNumber = Math.floor(Math.random() * (200-100+1) + 100);
    console.log(secretNumber);

    const div = document.getElementById("img");
    div.innerHTML = "";
    const img = document.createElement("img");


    if(secretNumber>= 100 || secretNumber < 120){
        img.src = "img/Waxed Flared Denim x Rick Owens Geobaskets x ERD Type Longsleeve.jpg";
    }
    else if(secretNumber >= 120 || secretNumber < 140){
        img.src = "img/unr4vld fur jeans.jpg";
    }
    else if(secretNumber >= 140 || secretNumber < 160){
        img.src = "img/download.jpg"
    }
    else if(secretNumber >= 160 || secretNumber < 160){
        img.src = "img/download (1).jpg"
    }
    else{
        img.src = "img/Chillin in Tokyo.jpg"
    }

    div.appendChild(img);
}

function confirm(){
    number = document.getElementById("number").value;
    confront();
}

function confront(){
    textDiv.innerHTML = "";

    let n = document.getElementById("number");
    let dif = n - secretNumber;

    textDiv.innerHTML = dif;
}
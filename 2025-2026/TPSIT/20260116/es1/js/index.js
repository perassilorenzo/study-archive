function saluta() {
    console.log("Ciao bentornato a scuola");
}

function preleva(){
    let m = document.getElementById("text").value;
    alert(m);
}

function cambiatesto(){
    let titolo = document.getElementById("titolo");
    titolo.textContent = "Nuovo Titolo";
    document.getElementById("titolo").textContent = "Nuovo titolo";
}

function cambiaHeader(){
    let testata = document.getElementById("header");
    testata.innerHTML = "Nuova testata";
    // posso scrivere qualunque cosa come elemento html derettamente dal js
}
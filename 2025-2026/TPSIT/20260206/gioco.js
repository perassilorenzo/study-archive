let parola = document.getElementById("parola");
let count = 7;

function gioca() {

    let letter = document.getElementById("lettera").value.toUpperCase();
    document.getElementById("lettera").value = "";
    let found = false;

    for (let i = 0; i < parolaSegreta.length; i++) {
        if (letter == parolaSegreta.charAt(i)) {
            result[i] = letter;
            found = true;
        }
    }
    if(!found && letter != ""){
        count--;
    }

    document.getElementById("parola").innerHTML = result.join("");
    document.getElementById("count").innerHTML = `Hai ancora ${count} vite`;

    if (count == 0){
        document.getElementById("risultati").innerHTML = `<br><h1>Impiccato!<h1><button onclick="ricarica()">Ricarica la pagina</button>`
        
        document.getElementById("btn-gioca").disabled = true;
        document.getElementById("btn-gioca").style.cursor = "not-allowed";
        document.getElementById("btn-gioca").style.transform = "scale(1)";
        document.getElementById("btn-gioca").style.background = "rgb(216, 216, 14)";

        document.getElementById("lettera").disabled = true;
        document.getElementById("lettera").style.cursor = "not-allowed";
    }
    if (result.join("") == parolaSegreta) {
        document.getElementById("risultati").innerHTML = `<br><h1>Sei salvo!</h1><button onclick="ricarica()">Ricarica la pagina</button>`
        
        document.getElementById("btn-gioca").disabled = true;
        document.getElementById("btn-gioca").style.cursor = "not-allowed";
        document.getElementById("btn-gioca").style.transform = "scale(1)";
        document.getElementById("btn-gioca").style.background = "rgb(216, 216, 14)";


        document.getElementById("lettera").disabled = true;
        document.getElementById("lettera").style.cursor = "not-allowed";
    }
}

document.getElementById("lettera").addEventListener("keydown", function(e) {
    if (e.key === "Enter") {
        gioca();
    }
});

function ricarica() {
    location.reload();

    let random = Math.floor(Math.random()*10-1+1)+1; 
    NuovaParola(random);
}
//formato: "numero-seme-punti-forza"
//PUNTI 1=11, 3=10, 10=4, 9=3, 8=2, tutti gli altri 0
//FORZA 1=10, 3=9, 10=8,
const carte = ["1-B-11-10", "2-B-0-1", "3-B-10-9", "4-B-0-2", "5-B-0-3", "6-B-0-4", "7-B-0-5", "8-B-2-6", "9-B-3-7", "10-B-4-8",
    "1-O-11-10", "2-O-0-1", "3-O-10-9", "4-O-0-2", "5-O-0-3", "6-O-0-4", "7-O-0-5", "8-O-2-6", "9-O-3-7", "10-O-4-8",
    "1-S-11-10", "2-S-0-1", "3-S-10-9", "4-S-0-2", "5-S-0-3", "6-S-0-4", "7-S-0-5", "8-S-2-6", "9-S-3-7", "10-S-4-8",
    "1-C-11-10", "2-C-0-1", "3-C-10-9", "4-C-0-2", "5-C-0-3", "6-C-0-4", "7-C-0-5", "8-C-2-6", "9-C-3-7", "10-C-4-8"];

window.onload = function() {
    //let carta1 = documento.getElementById("cartaPc1")
    cartaPc1.src = "CARTE/CARTE/retro.jpg";
    cartaPc2.src = "CARTE/CARTE/retro.jpg";
    cartaPc3.src = "CARTE/CARTE/retro.jpg";
    cartaUser1.src = "CARTE/CARTE/retro.jpg";
    cartaUser2.src = "CARTE/CARTE/retro.jpg";
    cartaUser3.src = "CARTE/CARTE/retro.jpg";
}
//variabili globali
let mazzo = Array(40); 
let indexMazzo = 0; 
let turno = "user";
let puntiComputer = 0;
let puntiUser = 0;
let cartaGiocataComputer;
let cartaGiocataUtente;
let indiceCartaGiocata;
let indiceCartaGiocataImg;
let carteUscite = Array(40);
let manoUser = Array(3);
let manoPc = Array(3);

function start(){
    resetStatoIniziale();
    mischiaMazzo();
    daiCartePrimaMano();
    determinaBriscola();
}

function resetStatoIniziale(){
    puntiUser = 0;
    puntiComputer = 0;
    playerPoints.textContent = "0";
    cpuPoints.textContent = "0";
    cartaGiocataUtente = null;
    cartaGiocataComputer = null;
    deckCount.textContent = "40"
}

function mischiaMazzo(){
    // nessuna carta è ancora uscita
    for(let i = 0; i<40; i++){
        carteUscite[i] = -1;
    }

    for (let i = 0; i < 40; i++){
        let carta;
        
        do {
            carta = Math.floor(Math.random()*40);
        } while(carteUscite.includes(carta));

        carteUscite[i] = carta;

        mazzo[i] = carte[carta];
    }
}


function getPathFile(carta){
    let parti = carta.split("-");
    return `CARTE/CARTE/${parti[0]}-${parti[1]}.png`
}

function determinaBriscola(){
    let cartaBriscola = mazzo[39];
    // funzione split "1-B-11-10"   [1, B, 11, 10]
    briscola = cartaBriscola.split("-")[1];
    console.log(`La briscola è ${briscola}`);
    briscolaCardImg.src = getPathFile(cartaBriscola);
}

function daiCartePrimaMano(){
    for (let i = 0; i < 3; i++){
        manoUser[i] = mazzo[i*2];
        manoPc[i] = mazzo[i*2 + 1];
        carteUser[i].src = getPathFile(manoUser[i]);
        carteUser[i].style.display = "";
        carteUser[i].classList.remuve("card--disable")  // classe che mi diabilita il click e hover
    }

    indexMazzo = 6; // le prime 6 carte sono state distribuite
    deckCount.textContent = 40 -indexMazzo; 
}

function giocaCarta(indice){
    console.log(`Il turno è ${turno}`);
    if (turno != "user"){
        alert("Non è il tuo turno!");
        return;
    }

    console.log(`La carta giocata è ${manoUser[indice]}`);
    playerPlayedImg.src = getPathFile(manoUser[indice]);
    playerPlayedImg.style.display = "block";
    carteUser[indice].style.display = "none";
    indiceCartaGiocata = indice;
    cartaGiocataUtente = manoUser[indice];
    manoUser[indice] = null;

    // disabilito le altre carte che ha in mano il giocatore
    for (let i = 0; i < 3; i++){
        if (i != indice && manoUser[i] != null){
            carteUser[i].classList.add("card--disabled");
        }
    }
    if (cartaGiocataComputer != null){
        calcolaPunteggio()
        turno = "user";
    }
    else{
        turno = "computer";
        turnPlayer.textContent = turno;
        setTimeout(function() {giocaComputer();}, 1000)
        
    }
}

function giocaComputer(){
    turno = "computer";
    console.log("Il computer sta giocando...");
    indiceCartaGiocataPc = Math.floor(Math.random() * 3) 
    imgGiocataPc.src = getPathFile(manoPc[indiceCartaGiocataPc])
    cpuPlayerImg.style.display = "block";
    cartaGiocataComputer = manoPc[indiceCartaGiocata];
    console.log("Il PC ha giocato" + manoPc[indiceCartaGiocata]);
    manoPc[indiceCartaGiocataPc] = null;
    
    if(cartaGiocataUtente != null){
        calcolaPunteggio();
    }
    else{
        turno = "user";
        turnPlayer.textContent = true;

        for (let i = 0; i < 3; i++){
            if (manoUser[i] != null){
                carteUser[i].classList.remuve("card--disable");

            }
        }
    }
}

function giocaCarta(indice){

}

function giocaComputer(){

}

function calcolaPunteggio(){
    if (cartaGiocataComputer == null || cartaGiocataUtente == null){
        return;
    }

    console.log(`Calcola punteggio tra ${cartaGiocataComputer} e ${cartaGiocataUtente}`);
    let puntiUtente = parseInt(cartaGiocataUtente.slip("-")[2]);
    let puntiComputer = parseInt(cartaGiocataComputer.slip("-")[2]);
    let semeUtente = parseInt(cartaGiocataUtente.slip("-")[1]);
    let semeComputer = parseInt(cartaGiocataComputer.slip("-")[1]);
    let forzaUtente = parseInt(cartaGiocataUtente.slip("-")[1]);
    let forzaComputer = parseInt(cartaGiocataComputer.slip("-")[1]);

    let puntiTotali = puntiUtente + puntiComputer;
    let vincitore;

    if (semeComputer == semeUtente){
        vincitore = forzaUtente > forzaComputer ? "utente" : "computer";
    }
    else if(semeUtente == briscola && semeComputer != briscola) vincitore = "utente";
    else if(semeComputer == briscola && semeUtente != briscola) vincitore = "computer";
    else if (semeComputer != briscola && semeUtente != briscola) vincitore = turno == "user" ? "computer" : "user";
    else vincitore = forzaUtente > forzaComputer ? "utente" : "computer";

    aggiornaEmostraPunteggi(vincitore, puntiTotali);
}

function aggiornaEmostraPunteggi(vincitore, puntiTotali){
    if (vincitore == "utente"){
        statusText.textContent = `Prendi tu! Hai guadagnato ${puntiTotali}`;
        puntiComputer += puntiTotali;
        playerPoints.textContent = puntiUser;
    }
    else {
        statusText.textContent = `Prendo il pc! Ha guadagnato ${puntiTotali}`;
        puntiComputer += puntiTotali;
        cpuPoints.textContent = puntiComputer;
    }
    setTimeout(function(){
        pescaCarta(vincitore)
        cartaGiocataComputer = null;
        cartaGiocataUtente = null;
        playerPlayedImg.style.display = "none";
    }, 2000)
}

function pescaCarta(vincitore){
    turno = vincitore === "utente" ? "user" : "computer";
    turnPlayer.textContent = turno === "user" ? "tu" : "computer";

    if (indexMazzo >= 40){
        briscolaCardImg.src = null;
        let carteRimaste;
        for (let i = 0; i < 3; i++){
            if (manoUser[i] != null) carteRimaste++;
        }
        if (carteRimaste == 0)
            if (puntiUser > puntiComputer)
                alert(`Hai vinto! Punteggio finale ${puntiUser} vs ${puntiComputer}`);
            else if (puntiComputer > puntiUser)
                alert(`Hai perso! Punteggio ${puntiComputer} vs ${puntiUser}`);
            else alert(`Pareggio! Punti ${puntiComputer}`);

            return
    }

    if (vincitore == "utente"){
        manoUser[indiceCartaGiocata] = mazzo[indexMazzo];
        manoPc[indiceCartaGiocata] = mazzo[indexMazzo+1];
    }
    else{
        manoUser[indiceCartaGiocata] = mazzo[indexMazzo+1];
        manoPc[indiceCartaGiocata] = mazzo[indexMazzo];
    }

    indexMazzo += 2;

    cartaUser[indiceCartaGiocata].src = getPathFile(manoUser[indiceCartaGiocata]);

    deckCount.textContent = 40 - indexMazzo;
    
    if (turno === "computer"){
        setTimeout(function(){giocaComputer()}, 1000);
    }
}
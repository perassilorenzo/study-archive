"use strict";

const { createElement } = require("react");

let punteggio = document.getElementById("spnPunteggio");
let varPunteggio = 0;
let timer = document.getElementById("spnTimer");
let startButton = document.getElementById("btnStart");
let stopButton = document.getElementById("btnStop");
let timerArray = [];

// -----------------------------------------------------------------------
// ESERCIZIO 1 – avviaGioco()
// -----------------------------------------------------------------------
function avviaGioco() {
    punteggio.textContent = "0";
    timer.textContent = "30";

    startButton.disabled = true;
    stopButton.disabled = false;

    let element = setInterval(aggiornaTimer() ,1000);
    timerArray.push(element);

    element = setInterval(() => {
        creaStella();
    }, 900);
    timerArray.push(element);

    element = setInterval(() => {
        let bomba = createElement("div");
        bomba.textContent = "💣";
        document.getElementById("campo").appendChild(bomba);
    }, 1500)
    timerArray.push(element);

}

// -----------------------------------------------------------------------
// ESERCIZIO 2 – creaStella()
// -----------------------------------------------------------------------
function creaStella() {
    let stella = createElement("div");
    stella.textContent = "🌠";
    stella.style.x = Math.floor(Math.random() * 600);
    stella.classList = ""
    document.getElementById("campo").appendChild(stella);

    stella.onclick = clickStella();

}

// -----------------------------------------------------------------------
// ESERCIZIO 3 – avviaMovimento(stella)
// -----------------------------------------------------------------------
function avviaMovimento(stella) {
    let i = 400;

    do{
        setInterval(() => {
            stella.style.y = i--;
        }, 1000);
    } while (i > 0);

    


}

// -----------------------------------------------------------------------
// ESERCIZIO 4 – clickStella()
// -----------------------------------------------------------------------
function clickStella() {
    let stella = this;
    stella.style.display = "none";

    varPunteggio++;
    punteggio.textContent(varPunteggio);

}

// -----------------------------------------------------------------------
// ESERCIZIO 5 – aggiornaTimer()
// -----------------------------------------------------------------------
function aggiornaTimer() {
    for (let i = 30; i >= 0; i--){
        timer.textContent(i);
    } 
}

// -----------------------------------------------------------------------
// ESERCIZIO 6 – creaBomba()
// -----------------------------------------------------------------------
function creaBomba() {
    let bomba = createElement("div");
    bomba.textContent = "💣";
    bomba.classList("bomba");
    document.getElementById("campo").appendChild(bomba);

    bomba.onclick = clickBomba();


}

// -----------------------------------------------------------------------
// ESERCIZIO 7 – clickBomba()
// -----------------------------------------------------------------------
function clickBomba() {
    let bomba = this;
    bomba.style.display = "none";

    varPunteggio--;
    punteggio.textContent(varPunteggio);

}

// -----------------------------------------------------------------------
// ESERCIZIO 8 – fermaGioco()
// -----------------------------------------------------------------------
function fermaGioco() {
    let stelle;
    stelle.querySelectAll(".stella");
    // devo eliminare le stelle

    let bombe;
    bombe.querySelectAll(".bomba");
    // elimino le bombe

    timerArray.forEach(element => {
        clearInterval(element);
    });

    document.getElementById("risultato").innerHTML = `Hai totalizzato ${varPunteggio}`;

    varPunteggio = 0;
    punteggio.textContent(varPunteggio);    
    timer.textContent(30);

    startButton.disabled = false;
    stopButton.disabled = true;
}

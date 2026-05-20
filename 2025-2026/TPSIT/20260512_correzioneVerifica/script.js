"use strict";

let punteggio = 0;
let tempoRimasto = 30;
let intervalloStelle = null;
let intervalloTimer = null;
let intervalloBomba = null;

function avviaGioco(){
    punteggio = 0;
    document.getElementById("spnPunteggio").textContent = punteggio;
    tempoRimasto = 30;
    document.getElementById("spnTimer").textContent = tempoRimasto;

    document.getElementById("btnStart").disabled = true;
    document.getElementById("btnStop").disabled = false;

    intervalloStelle = setInterval(creaStella, 900);
    intervalloTimer = setInterval(aggiornaTimer, 1000);
    intervalloBomba = setInterval(creaBomba, 1500);
}

function creaStella(){
    let stella = document.createElement("div");
    stella.classList.add("stella");
    stella.textContent = "⭐";

    let left = Math.floor(Math.random() * 571);
    stella.style.top = "0px";
    stella.style.left = left + "px";

    stella.onclick = clickStella;
    document.getElementById("campo").appendChild(stella);

    avviaMovimento(stella);

    setTimeout(() => {
        clearInterval(stella.moto);
        stella.remove();
    }, 2000);
}

function avviaMovimento(stella){
    let posizione = 0;
    stella.moto = setInterval(() => {
        posizione += 5;
        stella.style.top = posizione + "px";
        
        if(posizione >= 380){
            clearInterval(stella.moto);
            stella.remove();
        }
    }, 30);
}

function clickStella(){
    punteggio++;
    document.getElementById("spnPunteggio").textContent = punteggio;
    clearInterval(this.moto);
    this.remove();
}

function clickBomba(){
    punteggio--;
    document.getElementById("spnPunteggio").textContent = punteggio;
    clearInterval(this.moto);
    this.remove();
}

function aggiornaTimer(){
    tempoRimasto--;
    document.getElementById("spnTimer").textContent = tempoRimasto;

    if(tempoRimasto <= 0){
        fermaGioco();
    }
}

function fermaGioco(){
    clearInterval(intervalloStelle);
    clearInterval(intervalloTimer);
    clearInterval(intervalloBomba);

    document.querySelectorAll(".stella").forEach(s)(function(s) {
        clearInterval(s.moto);
        s.remove();
    })

    document.querySelectorAll(".bomba").forEach(b)(function(b){
        clearInterval(b.moto);
        b.remove();
    })

    spnPunteggio.textContent = punteggio;
    spnTimer = tempoRimasto;

    document.getElementById("btnStart").disabled = false;
    document.getElementById("btnStop").disabled = true;
}
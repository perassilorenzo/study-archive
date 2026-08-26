"use strict";

let punteggio = 0;
let monete = 0;
let tempoRimasto = 20;
let intervalli = [];

let punteggioUI = document.getElementById("spnPunteggio");
let moneteUI = document.getElementById("spnMonete");
let timerUI = document.getElementById("spnTimer");
let btnStart = document.getElementById("btnStart");
let btnStop = document.getElementById("btnStop");

function avviaPartita() {
    punteggio = 0;
    monete = 0;
    tempoRimasto = 20;

    punteggioUI.textContent = punteggio;
    moneteUI.textContent = monete;
    timerUI.textContent = tempoRimasto;

    document.getElementById("risultato").innerHTML = "";

    btnStart.disabled = true;
    btnStop.disabled = false;

    intervalli = [];
    intervalli.push(setInterval(creaMoneta, 800));
    intervalli.push(setInterval(creaTeschio, 1200));
    intervalli.push(setInterval(aggiornaTimer, 1000));
}

function creaMoneta() {
    let moneta = document.createElement("div");
    moneta.classList.add("rounded-circle", "bg-warning", "moneta");
    moneta.textContent = "$";

    moneta.style.position = "absolute";
    moneta.style.top = "0px";
    moneta.style.left = Math.floor(Math.random() * 560) + "px";
    moneta.style.width = "40px";
    moneta.style.height = "40px";
    moneta.style.display = "flex";
    moneta.style.justifyContent = "center";
    moneta.style.alignItems = "center";
    moneta.style.cursor = "pointer";

    moneta.onclick = clickMoneta;
    document.getElementById("campo").appendChild(moneta);
    avviaMovimento(moneta);

    setTimeout(() => {
        if (moneta.isConnected) moneta.remove();
    }, 3000);
}

function creaTeschio() {
    let teschio = document.createElement("div");
    teschio.classList.add("rounded-circle", "bg-danger", "text-white", "teschio");
    teschio.textContent = "☠";

    teschio.style.position = "absolute";
    teschio.style.top = "0px";
    teschio.style.left = Math.floor(Math.random() * 560) + "px";
    teschio.style.width = "40px";
    teschio.style.height = "40px";
    teschio.style.display = "flex";
    teschio.style.justifyContent = "center";
    teschio.style.alignItems = "center";
    teschio.style.cursor = "pointer";

    teschio.onclick = clickTeschio;
    document.getElementById("campo").appendChild(teschio);
    avviaMovimento(teschio);

    setTimeout(() => {
        if (teschio.isConnected) teschio.remove();
    }, 3000);
}

function avviaMovimento(elemento) {
    let top = 0;
    elemento.moto = setInterval(() => {
        top += 4;
        elemento.style.top = top + "px";
        if (top >= 390) {
            clearInterval(elemento.moto);
            elemento.remove();
        }
    }, 30);
}

function clickMoneta(event) {
    let el = event.target;
    clearInterval(el.moto);
    el.remove();
    punteggio++;
    monete++;
    punteggioUI.textContent = punteggio;
    moneteUI.textContent = monete;
}

function clickTeschio(event) {
    let el = event.target;
    clearInterval(el.moto);
    el.remove();
    punteggio--;
    punteggioUI.textContent = punteggio;
}

function aggiornaTimer() {
    tempoRimasto--;
    timerUI.textContent = tempoRimasto;
    if (tempoRimasto <= 0) fermaPartita();
}

function fermaPartita() {
    intervalli.forEach(id => clearInterval(id));
    intervalli.length = 0;

    document.querySelectorAll(".moneta, .teschio").forEach(el => {
        clearInterval(el.moto);
        el.remove();
    });

    document.getElementById("risultato").innerHTML =
        `<div class="alert alert-success">
            Partita terminata! Hai totalizzato <strong>${punteggio}</strong>
            punti raccogliendo <strong>${monete}</strong> monete.
        </div>`;

    btnStart.disabled = false;
    btnStop.disabled = true;
}
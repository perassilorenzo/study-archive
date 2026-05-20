const NUM_CELLE = 10;
const DELAY_INIZIO = 250;   // ms tra un tic e l'altro
const ACCELERAZIONE = 20;
const DELAY_MINIMO = 20;

// riferimento al dom

const celle = document.querySelectorAll('.cella');
const btnStart = document.querySelector('#btn-start');
const btnReset = document.querySelector('#btn-reset');
const infoVel = document.querySelector('#info-velocita');

let i = 0;  // indice della cella attiva
let direzione = 1;
let delay = DELAY_INIZIO;
let giriAndata = 0;

function resetCelle() {celle.forEach(c => c.classList.remove('attiva'));}
function aggiornaInfo() {infoVel.textContent = `Delay: ${delay} ms | giri: ${giriAndata}`;}
function step() {

function avviaAnimazione() {
    // reset stato iniziale
    i = 0;
    direzione = 1;
    delay = DELAY_INIZIO;
    giriAndata = 0;
    resetCelle();
    aggiornaInfo();

    celle[0].classList.add('rosso');
    intervalID = setInterval(step, delay);
    btnAvvia.disabled = true;
    btnStop.disabled = false;

}


function resetAnimazione() {}
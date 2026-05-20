let cronoInizio, cronoPassato = 0, cronoIntervallo;
let timerIntervallo, timerRimanente = 0;

function avviaCrono() {
    cronoInizio = Date.now() - cronoPassato;
    cronoIntervallo = setInterval(aggiornaCrono, 10);
    gestisciPulsanti('crono', true);
}

function fermaCrono() {
    clearInterval(cronoIntervallo);
    gestisciPulsanti('crono', false);
}

function resetCrono() {
    fermaCrono();
    cronoPassato = 0;
    document.getElementById('cronometro-testo').innerText = '00:00:00.000';
}

function aggiornaCrono() {
    cronoPassato = Date.now() - cronoInizio;
    
    let ms = (cronoPassato % 1000).toString().padStart(3, '0');
    let s  = (Math.floor(cronoPassato / 1000) % 60).toString().padStart(2, '0');
    let m  = (Math.floor(cronoPassato / 60000) % 60).toString().padStart(2, '0');
    let h  = Math.floor(cronoPassato / 3600000).toString().padStart(2, '0');

    document.getElementById('cronometro-testo').innerText = `${h}:${m}:${s}.${ms}`;
}

function avviaTimer() {
    if (timerRimanente <= 0) {
        const h = parseInt(document.getElementById('ore').value) || 0;
        const m = parseInt(document.getElementById('minuti').value) || 0;
        const s = parseInt(document.getElementById('secondi').value) || 0;
        timerRimanente = (h * 3600 + m * 60 + s) * 1000;
    }

    if (timerRimanente <= 0) return;

    timerIntervallo = setInterval(() => {
        timerRimanente -= 1000;
        aggiornaTestoTimer();

        if (timerRimanente <= 0) {
            resetTimer();
            alert("Fine!");
        }
    }, 1000);

    gestisciPulsanti('timer', true);
}

function fermaTimer() {
    clearInterval(timerIntervallo);
    gestisciPulsanti('timer', false);
}

function resetTimer() {
    fermaTimer();
    timerRimanente = 0;
    aggiornaTestoTimer();
}

function aggiornaTestoTimer() {
    let tot = Math.max(0, Math.floor(timerRimanente / 1000));
    
    let h = Math.floor(tot / 3600).toString().padStart(2, '0');
    let m = Math.floor((tot % 3600) / 60).toString().padStart(2, '0');
    let s = (tot % 60).toString().padStart(2, '0');

    document.getElementById('timer-testo').innerText = `${h}:${m}:${s}`;
}

function gestisciPulsanti(tipo, inEsecuzione) {
    document.getElementById(`${tipo}-avvia`).disabled = inEsecuzione;
    document.getElementById(`${tipo}-ferma`).disabled = !inEsecuzione;
    if (tipo === 'crono') document.getElementById('crono-giro').disabled = !inEsecuzione;
}
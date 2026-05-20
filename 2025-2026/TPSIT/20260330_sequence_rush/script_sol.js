"use strict";   // attiva una modalità rigorosa, le varibili ad esempio devono essere dichiarate

const symbols = ['💻', '🌐', '🗄️', '🐛', '🔑', '📦', '🔒', '☁️'];
const CONFIG = { maxLives: 3, numRound: 10 };
const gameState = { sequence: [], round: 0, score: 0, lives: CONFIG.maxLives };

// elementi DOM (il DOM è la verisione modificabile della struttura HTML che verrà letta dal browser e modificata dal JS): sono varibili che contengono un riferimento a un elemento del DOM al posto di scrivere ogni volta document.getElement
const btnGrid = document.getElementById("btn-grid");                // griglia dei bottoni per i simboli
const scoreDisplay = document.getElementById("score");              // div che mostra il punteggio
const roundNum = document.getElementById("round-num");              // numero di round
const livesRow = document.getElementById("lives-row");              // dove troviamo i cuori
const btnStart = document.getElementById("btn-start");              // bottone inizia partita
const seqLenDisplay = document.getElementById("seq-len-display");   // div che mostra la lunghezza della sequenza
const risRound = document.getElementById("risRound");               // div che mostra gli output del gioco

let numClick = 0;
let userSequence = []; // sequenza inserita dall'utente, separata dal DOM
let showTimeouts = []; // per poter cancellare i timer se necessario

// esegue il codice solo quando la pagina è completamente caricata
window.onload = function () {
    aggiornaInterfacciaVite();
    btnGrid.style.pointerEvents = "none";   // se un elemento può ricerve i click oppure no
};

function start() {
    numClick = 0;
    userSequence = [];

    // Cancella eventuali timer in corso
    showTimeouts.forEach(t => clearTimeout(t)); // showTimeouts è un array che contiene tutti i setTimeout avviati. questa è una funzione scritta in maniera ridotta che cancella ogni elemento nell'array
    showTimeouts = [];

    gameState.round++;
    btnStart.disabled = true;
    roundNum.innerHTML = gameState.round;
    risRound.innerHTML = "—";

    // pulisce i quadratini
    for (let i = 0; i < 10; i++) {
        document.getElementById(`sym${i}`).innerHTML = "?";
    }

    setSymbol(gameState.round);
}

function setSymbol(round) {
    seqLenDisplay.innerHTML = round;
    gameState.sequence = [];

    for (let i = 0; i < round; i++) {
        gameState.sequence[i] = symbols[Math.floor(Math.random() * symbols.length)];    // genera un simbolo casuale prendendolo dall'array

        const t = setTimeout(() => {                                                // avvia un timer e salva il suo riferimento in t che quando scade esegue la funzione () =>
            document.getElementById(`sym${i}`).innerHTML = gameState.sequence[i];   // allo scadere trova il quadratino sym{i} e ci scrive il simbolo
        }, 800 * i);                                                                // ritarno in millisecondi, ogni simbolo aspetta 800ms in più del precedente
        showTimeouts.push(t);                                                       // aggiunge il timer all'array
    }

    const hideTimer = setTimeout(() => {                            // avvia il timer e salva il riferimento
        for (let i = 0; i < round; i++) {
            document.getElementById(`sym${i}`).innerHTML = "?";     // riinserisce i '?' in tutti i quadrati 
        }
        btnGrid.style.pointerEvents = "auto";                       // sblocca i tasti
        risRound.innerHTML = "Tocca a te!";
    }, 800 * round + 500);                                          // aspetta che tutti i simboli siano stati mostrati e poi li nasconde
    showTimeouts.push(hideTimer);                                   // salva il timer nell'array
}

function chooseSymbol(pos) {                                                    // funzione che viene richiamata nell'HTML per azzeccare il simbolo
    if (numClick < gameState.round) {
        // Salva la scelta dell'utente nell'array dedicato (non solo nel DOM)
        userSequence[numClick] = symbols[pos];
        document.getElementById(`sym${numClick}`).innerHTML = symbols[pos];
        numClick++;

        if (numClick === gameState.round) {                                     // controlla se l'utente ha finito di inserire tutti i simboli
            btnGrid.style.pointerEvents = "none";
            controllaSequenza();
        }
    }
}

function controllaSequenza() {
    let seqCorretta = true;
    for (let i = 0; i < gameState.round; i++) {
        // Confronto tra array JS, non tra innerHTML — molto più affidabile
        if (gameState.sequence[i] !== userSequence[i]) {
            seqCorretta = false;
            break;
        }
    }

    if (seqCorretta) {
        risRound.innerHTML = "✅ Corretto! Clicca Inizia per il prossimo round.";
        gameState.score += 100;
        scoreDisplay.innerHTML = gameState.score;
        btnStart.innerHTML = `Vai al round successivo`

        if (gameState.round >= CONFIG.numRound) {
            risRound.innerHTML = `🏆 Hai completato tutti i round! Punteggio finale: ${gameState.score}`;
            btnStart.disabled = true;
        } else {
            btnStart.disabled = false;
        }
    } else {
        gameState.lives--;
        aggiornaInterfacciaVite();
        gameState.score = Math.max(0, gameState.score - 50);    // sottrae ma senza scendere sotto lo zero
        scoreDisplay.innerHTML = gameState.score;

        if (gameState.lives <= 0) {
            risRound.innerHTML = `💀 GAME OVER! Punteggio finale: ${gameState.score}. Ricarica la pagina per riprovare.`;
            btnStart.disabled = true;
        } else {
            risRound.innerHTML = `❌ Sbagliato! Ti restano ${gameState.lives} vite. Riprova il round.`;
            gameState.round--; // Ripete lo stesso round
            btnStart.disabled = false;
            btnStart.innerHTML = `Vai al round successiv`
        }
    }
}

function aggiornaInterfacciaVite() {
    livesRow.innerHTML = "";
    for (let i = 0; i < gameState.lives; i++) livesRow.innerHTML += "❤️";
    for (let i = gameState.lives; i < CONFIG.maxLives; i++) livesRow.innerHTML += "🖤";
}
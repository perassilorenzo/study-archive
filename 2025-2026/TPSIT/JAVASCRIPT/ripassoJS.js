document.getElementById("id")
// Restituisce l'elemento con quell'ID specifico
// Restituisce null se non trovato

document.createElement("div")
// Crea un nuovo elemento HTML (non ancora nel DOM)
// Es: const el = document.createElement("button")

document.querySelector(".classe")
// Trova il PRIMO elemento che corrisponde al selettore CSS
// Funziona con classi (".nome"), ID ("#nome"), tag ("div"), ecc.

document.querySelectorAll(".classe")
// Restituisce TUTTI gli elementi corrispondenti (NodeList)
// Va iterata con forEach o convertita in array con Array.from()

elemento.textContent = "testo"
// Imposta o legge il testo puro dell'elemento
// NON interpreta HTML — più sicuro di innerHTML

elemento.innerHTML = `<span>HTML</span>`
// Imposta o legge il contenuto HTML interno
// Attenzione: vulnerabile a XSS se contiene input utente

elemento.appendChild(figlio)
// Aggiunge un elemento figlio come ULTIMO figlio
// Accetta solo nodi DOM (non stringhe)

elemento.append("testo", altroElemento)
// Versione moderna: accetta sia stringhe che nodi DOM
// Può aggiungere più elementi contemporaneamente

elemento.className = "classe"
// Sovrascrive TUTTE le classi dell'elemento con la stringa data

elemento.classList.add("classe")       // Aggiunge una classe
elemento.classList.remove("classe")    // Rimuove una classe
elemento.classList.toggle("classe")    // Aggiunge se assente, rimuove se presente
elemento.classList.contains("classe")  // Restituisce true/false

elemento.style.color = "red"
elemento.style.fontSize = "16px"
elemento.style.display = "none"        // "block", "flex", "grid", ecc.
elemento.style.pointerEvents = "none"  // Disabilita tutti gli eventi mouse

elemento.onclick = funzione
// Assegna un handler al click (sovrascrive il precedente)

elemento.ondblclick = funzione
// Assegna un handler al doppio click

elemento.addEventListener("click", funzione)
// Metodo preferito: supporta più handler sullo stesso evento
// Altri eventi: "input", "change", "keydown", "mouseover", "submit"...

elemento.removeEventListener("click", funzione)
// Rimuove un handler precedentemente aggiunto

elemento.disabled = true
// Disabilita un input, button o select (valore booleano, non stringa!)
// ✅ elemento.disabled = true   ❌ elemento.disabled = "true"

elemento.src = "path/immagine.png"
// Imposta la sorgente di img, script, iframe, ecc.

elemento.value
// Legge o imposta il valore di input, textarea, select

const id = setTimeout(() => { }, 800)
// Esegue la funzione UNA VOLTA dopo N millisecondi
// Restituisce un ID numerico

clearTimeout(id)
// Annulla un setTimeout prima che scatti

const id = setInterval(() => { }, 3000)
// Esegue la funzione RIPETUTAMENTE ogni N millisecondi

clearInterval(id)
// Ferma un setInterval

// Pattern comune per pulire più timer:
const timers = [id1, id2, id3]
timers.forEach(t => clearTimeout(t))

Math.floor(4.9)      // → 4      Arrotonda verso il basso
Math.ceil(4.1)       // → 5      Arrotonda verso l'alto
Math.round(4.5)      // → 5      Arrotonda al più vicino
Math.random()        // → 0.0–0.999...  Numero casuale
Math.max(3, 7, 2)    // → 7      Valore massimo tra gli argomenti
Math.min(3, 7, 2)    // → 2      Valore minimo
Math.abs(-5)         // → 5      Valore assoluto
Math.pow(2, 8)       // → 256    Potenza (oppure: 2 ** 8)
Math.sqrt(16)        // → 4      Radice quadrata

// Numero intero casuale tra min e max inclusi:
Math.floor(Math.random() * (max - min + 1)) + min

Date.now()
// Millisecondi dal 1° gennaio 1970 (timestamp Unix)
// Utile per misurare tempi: const start = Date.now()

const d = new Date()
d.getFullYear()   // Anno (es. 2026)
d.getMonth()      // Mese 0–11 (gennaio = 0!)
d.getDate()       // Giorno del mese 1–31
d.getHours()      // Ore 0–23
d.getMinutes()    // Minuti 0–59
d.getSeconds()    // Secondi 0–59

const arr = [1, 2, 3]

arr.push(4)          // Aggiunge in FONDO → [1,2,3,4]
arr.pop()            // Rimuove l'ultimo → restituisce 4
arr.unshift(0)       // Aggiunge in TESTA → [0,1,2,3]
arr.shift()          // Rimuove il primo → restituisce 0

arr.forEach(el => console.log(el))
// Itera ogni elemento — non restituisce nulla

arr.map(el => el * 2)
// Crea un NUOVO array trasformando ogni elemento → [2,4,6]

arr.filter(el => el > 1)
// Crea un NUOVO array con solo gli elementi che passano il test → [2,3]

arr.find(el => el > 1)
// Restituisce il PRIMO elemento che soddisfa la condizione → 2

arr.findIndex(el => el > 1)
// Come find ma restituisce l'INDICE → 1

arr.some(el => el > 2)
// true se ALMENO UN elemento soddisfa la condizione

arr.every(el => el > 0)
// true se TUTTI gli elementi soddisfano la condizione

arr.includes(2)
// true se il valore è presente nell'array

arr.indexOf(2)
// Indice della prima occorrenza, -1 se non trovato

arr.splice(1, 1)
// Rimuove 1 elemento all'indice 1 (modifica l'array originale)
// splice(indice, quanti, ...elementiDaInserire)

arr.slice(1, 3)
// Crea un NUOVO array da indice 1 a 2 (3 escluso) — non modifica l'originale

arr.sort((a, b) => a - b)
// Ordina in-place (numerico crescente)
// Per stringhe: arr.sort()

arr.reverse()
// Inverte l'array in-place

arr.join(" - ")
// Unisce tutti gli elementi in una stringa → "1 - 2 - 3"

arr.flat()
// Appiattisce array annidati di un livello → [[1,2],[3]] → [1,2,3]

arr.reduce((acc, el) => acc + el, 0)
// Riduce l'array a un singolo valore (es. somma) → 6

const s = "Hello World"

s.length             // → 11
s.toUpperCase()      // → "HELLO WORLD"
s.toLowerCase()      // → "hello world"
s.trim()             // Rimuove spazi iniziali e finali
s.trimStart()        // Solo inizio
s.trimEnd()          // Solo fine

s.includes("World") // → true
s.startsWith("He")  // → true
s.endsWith("ld")    // → true
s.indexOf("o")      // → 4  (prima occorrenza)
s.lastIndexOf("o")  // → 7  (ultima occorrenza)

s.slice(0, 5)        // → "Hello"   (inizio incluso, fine esclusa)
s.substring(0, 5)    // → "Hello"   (simile a slice, no indici negativi)

s.replace("World", "JS")
// → "Hello JS"  (solo prima occorrenza)

s.replaceAll("l", "L")
// → "HeLLo WorLd"  (tutte le occorrenze)

s.split(" ")
// → ["Hello", "World"]  Divide la stringa in array usando il separatore
// s.split("")  → array di singoli caratteri
// s.split(",") → utile per CSV

s.repeat(3)          // → "Hello WorldHello WorldHello World"
s.padStart(10, "0")  // → "00Hello World" (padding a sinistra)
s.padEnd(10, ".")    // → "Hello World." (padding a destra)

s.charAt(1)          // → "e"  carattere all'indice
s[1]                 // → "e"  notazione alternativa

s.charCodeAt(0)      // → 72  codice Unicode del carattere
String.fromCharCode(72) // → "H"

`Ciao ${nome}!`      // Template literal: interpolazione variabile

const obj = { nome: "Mario", età: 30 }

obj.nome             // → "Mario"  accesso con punto
obj["età"]          // → 30       accesso con stringa (utile per chiavi dinamiche)

obj.città = "Roma"  // Aggiunge o aggiorna una proprietà
delete obj.età       // Rimuove una proprietà

Object.keys(obj)     // → ["nome", "città"]    array delle chiavi
Object.values(obj)   // → ["Mario", "Roma"]    array dei valori
Object.entries(obj)  // → [["nome","Mario"],["città","Roma"]]  coppie chiave-valore

Object.assign({}, obj, { extra: true })
// Copia superficiale — crea nuovo oggetto fondendo più sorgenti

const copia = { ...obj }
// Spread: copia superficiale (sintassi moderna preferita)

"nome" in obj        // → true  verifica se la chiave esiste

// Destrutturazione:
const { nome, città } = obj
// Estrae proprietà in variabili locali

// Iterazione:
for (const [chiave, valore] of Object.entries(obj)) {
    console.log(chiave, valore)
}

"use strict"
// Attiva la modalità strict: errori silenziosi diventano eccezioni,
// vieta variabili non dichiarate, rende il codice più sicuro e ottimizzabile
// Va messo come PRIMA istruzione del file o della funzione

typeof variabile     // → "string" | "number" | "boolean" | "object" | "undefined" | "function"
console.log(...)     // Stampa nella console del browser
JSON.stringify(obj)  // Oggetto → stringa JSON
JSON.parse(stringa)  // Stringa JSON → oggetto

document.getElementById("id");
document.createElement("elemento html");
.textContent = "contenuto testuale del tag";
.onclick = Funzione;
.ondblclick = FunzioneDoppioClick;
.appendChild("contenuto da aggiungere");
.className = "classe";
.querySelector("class"); // cerca il primo elemento con quella classe
.innerHTML = codice html;
.push();
.disabled = "true"; .src = "path";
.querySelectorAll();
.style.color = "colore";
.style.fontSize = "px";
.style.display = "display";
.style.pointerEvents = "none";
"use strict";
window.onload = function () {};
window.open("inde.html", width = , height = );
.forEach(t => cleanTimeout(t));
setTimeout(() => {}, 800);
setTimeout(..., 3000);
setInterval(..., 3000);
cleanInterval();
Date.now();
Math.floor();
Math.random();
Math.max(); 
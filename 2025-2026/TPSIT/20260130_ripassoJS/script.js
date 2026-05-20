// undefined
let var;
var parola

// costante
const pi = 3.14;

// tipi di dato
// number
// string
// boolean
// null
// undefined

let = 12;
let = "12";

// operatori
// +
// -
// *
// /
// ==                           confronta solo il valore
// ===                          uguaglianza forte / stretta, si confronta sia il valore che il tipo

console.log(var1 == var2)    // stampa true
console.log(var1 === var2)   // stampa false   

if (var1 == var2){
    // in questo caso va entra qui
}
else{

}

// gestire la logica
// &&   and
// ||   or
// !=   diverso / not

// se sono maggiorenne e se faccio parte della 3ei

let eta;
let classe;

if (eta >= 18 && classe == "3ei"){

}

// esercizio alla lavagna
// tavola di verità

// c1      c2      c1 && c2        c1 || c2        !c1     !c2
// F       F           F               F           T       T    
// F       T           F               T           T       F
// T       F           F               T           F       T
// T       T           T               T           F       F

// strutture di controllo

// if / else
    // switch / case
// while
// for
// do  while

// funzioni utente

function sum(a, b){
    return a + b;
}

let result = sum(a, b);

// forma anonima

let result1 = function(){
    console.log("ciao")
}

// funzione sum in forma anonima

let result2 = function(a, b){
    return a + b;
}

// forma arrow

let saluta = () => {
    alert("ciao")
}

// forma arrow di sum

let sum = (a, b) => {
    return a + b;
}

// scope di una variabile
// = dove la variabile è visibile nel programma

if ( y == 0){
    let x = 4;  // let e const sono visibili solo nel blocco in cui sono definite, quindi la x non è visibile al di fuori di questa if
}

// stringhe

let nome = "parola";
let nome1 = 'parola';
let nome2 = `parola`;   // backtick (alt + 96)

// template di stringhe

let name = "Luca";
let msg = `Ciao ${name}`;   // == "Ciao Luca"

// lughezza di una stringa
name.length     // restituisce il numero di caratteri di una stringa

// singolo carattere in una precisa posizione
name.charAt(i);     // restituisce la posizione del carattere da 0 a 3 in questo caso

// posizione di un char
name.indexOf("L");      // restituisce 0
name.indexOf("z");      // restituisce -1

// parte di una stringa
substring(inizio, fine);

name.substring(0, 3);       // restituisce "Luc"
name.substring(1,2);        // restituisce "u"
name.substring(3, 15)       // restituisce "a"

name.substr(inizio, tot_chars)      // deprecata, non più utilizzato

// split e join
split()         // trasforma stringa in array
join()          // trasforma array in stringa

let frase = "uno, due, tre"
let splittati = frase.split(", ");       // splittati = ["uno", "due", "tre"]

let joinati = splittati.join("")        // joinati = "unoduetre"
joinati = splittati.join("-")           // joinati = "uno-due-tre"

// maiuscolo minoscolo e trim
joinati.toUpperCase()       // restituisce UNO-DUE-TRE  
joinati.toLowerCase()       // restituisce uno-due-tre  

joinati.trim()              // elimina tutti gli spazi prima e dopo una frase, restituisce uno-due-tre

// concatenazione
let a = "Hello";
let b = "World";

alert(a + b);           // restituisce "HelloWorld"
alert(a + " " + b);     // restituisce "Hello World"

let z = "5";
let y = 5;

alert(a + b + z);       // restituisce "HelloWorld5"
alert(a + b + y);       // restituisce "HelloWorld5"

// interpolazione
let b = `Ciao ${a}`



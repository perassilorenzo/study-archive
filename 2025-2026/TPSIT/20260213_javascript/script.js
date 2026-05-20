// metodi fontademntali dei vettori in js
// PUSH: aggiunge un elemento in fondo

let numeri = [1, 2, 3, 4, 5];
let parole = ["j", "s"];
let emoji = ["😊", "😂"];

numeri.push(44);
console.log(numeri);

// POP: per rimuovere un elemento e 
let q = numeri.pop();
console.log(numeri)
console.log(q)

// UNSHIFT: aggiunge all'inizio
parole.unshift("bo");
console.log(parole);

// SHIFT: toglie all'inizio
q = parole.shift();
console.log(q);
console.log(parole);

// INDEXOF: cerca un elemento e restituisce il suo indice
numeri.push(44);
q = numeri.indexOf(44);
console.log(q);

// SPLICE: rimuove un elemento in una specifica posizione
parole.push("bo");
console.log(parole);
parole.splice(1, 1, "...");
console.log(parole);

// SLICE: copia parziale dell'array da inizio a fine esclusa
let parte = numeri.slice(0, 2);
console.log(parte);
console.log(numeri);

// per percorrere un array
for (let i = 0; i < numeri.length; i++){
    console.log("${numeri[i]} ")
}

// for ... of 
for (let numero of numeri){
    console.log(numero);
}


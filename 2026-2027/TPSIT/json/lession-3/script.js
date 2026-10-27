const JSONDatabase = '{"kittens":[{"name":"Mittens","age":1},{"name":Kitty","age":21}'

// la funzione JSON.parse trasforma una stringa JSON in oggetto
const database = JSON.parse(JSONDatabase);

console.log("database", database);
console.log("First kitten", database.kittens[0]);

// la funzione JSON.stringify trasforma un oggetto JS in una stringa JSON
const JSONKittenString = JSON.stringify(database.kitten[0]);
console.log("JSON Kitten", JSONKittenString);



/* ===== esercizio 1 ===== */

const studenti = `[
  { "nome": "Luca", "cognome": "Rossi", "voti": [7, 8, 6] },
  { "nome": "Giulia", "cognome": "Bianchi", "voti": [9, 8, 10] },
  { "nome": "Marco", "cognome": "Ferrari", "voti": [5, 6, 6] },
  { "nome": "Martina", "cognome": "Esposito", "voti": [8, 8, 7] },
  { "nome": "Alessandro", "cognome": "Romano", "voti": [6, 7, 7] },
  { "nome": "Chiara", "cognome": "Colombo", "voti": [9, 9, 8] },
  { "nome": "Andrea", "cognome": "Ricci", "voti": [4, 5, 6] },
  { "nome": "Sara", "cognome": "Marino", "voti": [10, 9, 10] },
  { "nome": "Matteo", "cognome": "Greco", "voti": [7, 6, 7] },
  { "nome": "Francesca", "cognome": "Bruno", "voti": [8, 9, 8] },
  { "nome": "Lorenzo", "cognome": "Gallo", "voti": [6, 6, 5] },
  { "nome": "Alice", "cognome": "Conti", "voti": [7, 8, 9] },
  { "nome": "Giovanni", "cognome": "De Luca", "voti": [5, 5, 6] },
  { "nome": "Sofia", "cognome": "Costa", "voti": [8, 8, 8] },
  { "nome": "Davide", "cognome": "Giordano", "voti": [9, 10, 9] },
  { "nome": "Aurora", "cognome": "Mancini", "voti": [7, 7, 7] },
  { "nome": "Simone", "cognome": "Rizzo", "voti": [6, 5, 6] },
  { "nome": "Ginevra", "cognome": "Lombardi", "voti": [9, 8, 9] },
  { "nome": "Federico", "cognome": "Moretti", "voti": [6, 7, 8] },
  { "nome": "Emma", "cognome": "Barbieri", "voti": [10, 10, 10] },
  { "nome": "Mattia", "cognome": "Fontana", "voti": [5, 6, 5] },
  { "nome": "Giorgia", "cognome": "Santoro", "voti": [8, 7, 8] },
  { "nome": "Gabriele", "cognome": "Mariani", "voti": [7, 8, 7] },
  { "nome": "Beatrice", "cognome": "Rinaldi", "voti": [9, 9, 10] },
  { "nome": "Tommaso", "cognome": "Caruso", "voti": [6, 6, 6] },
  { "nome": "Vittoria", "cognome": "Ferrara", "voti": [8, 9, 8] },
  { "nome": "Riccardo", "cognome": "Galli", "voti": [7, 6, 8] },
  { "nome": "Anna", "cognome": "Martini", "voti": [10, 9, 9] },
  { "nome": "Edoardo", "cognome": "Leone", "voti": [5, 4, 5] },
  { "nome": "Rebecca", "cognome": "Longo", "voti": [8, 8, 7] },
  { "nome": "Leonardo", "cognome": "Gentile", "voti": [7, 7, 6] },
  { "nome": "Alessia", "cognome": "Martinelli", "voti": [9, 10, 9] },
  { "nome": "Cristian", "cognome": "Vitale", "voti": [6, 5, 5] },
  { "nome": "Arianna", "cognome": "Lombardo", "voti": [8, 7, 9] },
  { "nome": "Pietro", "cognome": "Serra", "voti": [7, 8, 8] },
  { "nome": "Elena", "cognome": "Coppola", "voti": [9, 9, 8] },
  { "nome": "Samuele", "cognome": "De Santis", "voti": [6, 6, 7] },
  { "nome": "Camilla", "cognome": "D'Amico", "voti": [10, 10, 9] },
  { "nome": "Filippo", "cognome": "Marchetti", "voti": [5, 6, 6] },
  { "nome": "Ludovica", "cognome": "Parisi", "voti": [8, 8, 9] }
]`

let nuoveStudenteDB = [];
$(document).ready(function () {
    const studentiDB = JSON.parse(studenti);

    for (let i = 0; i < studentiDB.length; i++){
        // questo uso di reduce "riduce" un array in un numero corrispondente alla somma dei suoi elementi
        const avg = studenti[i].voti.reduce(
            // acc: accoumulatore -> serve ad accumulare risultati fra una chiamata e l'altra, in questo caso la somma accumulata
            // item: l'elemento che sto guardando in una determinata iterazione
            (acc, item) => acc + item,
            // il secondo parametro è il valore iniziale dell'accumulatore
            0
        ) / studenti[i].voti.length

        nuoveStudenteDB.append(
            {
                nome: studenti[i].nome,
                cognome: studenti[i].cognome,
                media: avg
            }
        )
    }
    
    // .txt() assegna un testo dentro ad un elemento
    $("#ex-1-result").text(JSON.stringify(nuovoStudentiDB));
});


/* ===== esercizio 2 ===== */

$(document).ready(function () {
    const studentDB = JSON.parse($("#ex-2-result").text());

    const avgAvg = studentiDB.reduce(
        (acc, item) => acc + item.media,
        0
    ) / studentiDB.length;

    const studentiScarti = studentiDB.map(
        (item) => ({
            nome: item.nome,
            cognome: item.cognome,
            scartoMedia: item.mediaVoti - avgAvg
        })
    )

    const mediaScarti = studentiConScarti.reduce(
        (acc, item) => acc + item.scartoMedia,
        0
    ) / studentiDB.length;

    $("#ex-2-result").text(mediaScarti);
});
var nomi = ["Lorenzo", "Marco", "Andrea", "Matteo", "Luca", "Francesco", "Alessandro", "Davide", "Simone", "Gabriele", "Tommaso", "Riccardo", "Federico", "Giovanni", "Nicola", "Emanuele", "Stefano", "Pietro", "Filippo", "Michele"];

var cognomi = ["Rossi", "Bianchi", "Ferrari", "Romano", "Colombo", "Ricci", "Marino", "Greco", "Bruno", "Gallo", "Conti", "De Luca", "Costa", "Fontana", "Esposito", "Moretti", "Barbieri", "Rinaldi", "Caruso", "Ferri"];

var presenze = [true, false, true, true, false, true, false, true, true, false, true, true, false, true, false, true, true, false, true, false];

var main = document.querySelector("main");

// ciclo con l'indice delle celle

// for (let i = 0; i < nomi.length; i++){
//     let div = document.createElement("div");
//     div.classList.add("riga");
//     div.textContent = `${nomi[i]} ${cognomi[i]}`;
//     main.append(div);
// }

// ciclo sugli elementi del vettore
// in questo caso dentro item ho i nomi (STRINGA) delle persone

// for (let item of nomi){
//     let div = document.createElement("div");
//     div.classList.add("riga");
//     div.textContent = item;
//     main.append(div);
// }

for (let i in nomi){
    let div = document.createElement("div");
    let divPresenze = document.createElement("div");
    let btnGiustificazione = document.createElement("button");

    div.textContent = nomi[i]
    divPresenze.textContent = presenze[i];
    btnGiustificazione.textContent = "Giustifica";

    if (!presenze[i])
        btnGiustificazione.addEventListener("click", (e) =>{
            divPresenze.textContent = presenze[i] = true;
            btnGiustificazione.style.cursor = "not-allowed";
            btnGiustificazione.disabled = presenze[i];
            btnGiustificazione.removeEventListener("click")
        })
    else{
        btnGiustificazione.style.cursor = "not-allowed";
        btnGiustificazione.disabled = presenze[i];
    }
    
    main.append(div, divPresenze, btnGiustificazione);

}

let inputSearch = document.getElementById("inputSearch");

// inputSearch.addEventListener("change", (e) => {
//     let ricerca = e.value.toLowerCase();

//     let righe = document.querySelectorAll(".riga");

//     for (let riga of righe) {
//         let nome = riga.querySelector("div").textContent.toLowerCase();

//         if (nome.includes(ricerca)) {
//             riga.style.display = "";
//         } else {
//             riga.style.display = "none";
//         }
//     }
// })


stampa();


function stampa (filter = ""){
    main.innerHTML = "";
    for (let i in nomi){
        if (nomi[i].toLowerCase().includes(filter.toLocaleLowerCase()))
        {
                
            let div = document.createElement("div");
            let divPresenze = document.createElement("div");
            let btnGiustificazione = document.createElement("button");
            
            div.textContent = nomi[i]
            divPresenze.textContent = presenze[i];
            btnGiustificazione.textContent = "Giustifica";

            if (!presenze[i])
                btnGiustificazione.addEventListener("click", (e) =>{
                divPresenze.textContent = presenze[i] = true;
                btnGiustificazione.style.cursor = "not-allowed";
                btnGiustificazione.disabled = presenze[i];
                btnGiustificazione.removeEventListener("click")
            })
            else{
                btnGiustificazione.style.cursor = "not-allowed";
                btnGiustificazione.disabled = presenze[i];
            }
        
            main.append(div, divPresenze, btnGiustificazione);
    
        }
    }

}

inputSearch.addEventListener("change", (e) => {
    stampa(inputSearch.value);
})


// aprire una nuova scheda che mostra informazioni di riepilogo
const riepilogoBtn = document.querySelector("footer > button");
riepilogoBtn.addEventListener("click", (e) => {
    let presenti = 0;
    let assenti = 0;

    for (let i = 0; i < presenze.length; i++){
        if (presenze[i]) presenti++;
        else assenti++;
    }

    const newWindow = window.open("", "_blank")
    newWindow.document.write(
        "<h1>Riepilogo</h1>" +
        "<h2>Presenti:</h2>" + presenti +
        "<h2>Assenti:</h2>" + assenti  
        
    )
})

const redirectBtn = document.querySelector("footer > button:nth-child(2)");
redirectBtn.addEventListener("click", () => {
    // console.log(window.location.href);
    window.location.href = "pagina-2.html?p=goofy"
})

for (let i = 0; i < 3; i++){
    setTimeout(() => {
        console.log(i);
    }, 1000);
}

for (var i = 0; i < 3; i++){
    setTimeout(() => {
        console.log(i);
    }, 1000);
}

for (let i = 0; i < 3; i++){
    const timer = setInterval(() => {
        console.log(i);
    }, 1000);

    setTimeout(() => {
        clearTimeout(timer);   
    }, Math.random() * 10000);
}

const timer2 = setInterval(() => {
    //verificare i valori di presenza e colorarle la cella di rosso se false, verde se true 
}, 3000)
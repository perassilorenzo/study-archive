let grid = document.getElementById("grid");
let table = document.getElementById("table");
let button = document.getElementById("button");

function visualizzaTabella() {
    if (grid.classList.contains("d-none")) {
        grid.className = "container-fluid";
        table.className = "container-fluid d-none";
        button.innerHTML = "VISUALIZZA TABELLA";
    } else {
        grid.className = "container-fluid d-none";
        table.className = "container-fluid";
        button.innerHTML = "VISUALIZZA GRIGLIA";
    }
}

// =========================================== fatto in classe ===========================================

function Ricerca() {
    let testo = document.getElementById("ricerca").value.toLowerCase();
    let righe = document.querySelectorAll("tbody tr");
    
    righe.forEach(tr => {
        let td = tr.firstElementChild;
        let contenuto = td.textContent.toLowerCase();

        if (contenuto.includes(testo)) {
            tr.classList.remove("d-none");
        } else {
            tr.classList.add("d-none");
        }
    }); 
}

// alternativo di fare l' onclick nell' html
// vantaggio: posso assegnare anche più eventi in risposta di un comportamento
document.getElementById("btnId").addEventListener('click', Ricerca);
// il trigger qui è l'inserimento di un testo, non il click, quindi uso l'evento 'input'
document.getElementById("cerca").addEventListener('input', function(){
    const testo = this.value.toLowerCase();
    const righe = document.querySelectorAll("tbody tr");
    
    righe.forEach(tr => {
        const td = tr.firstElementChild;
        const contenuto = td.textContent.toLowerCase();

        if (contenuto.includes(testo)) {
            tr.classList.remove("d-none");
        } else {
            tr.classList.add("d-none");
        }
    }); 
});
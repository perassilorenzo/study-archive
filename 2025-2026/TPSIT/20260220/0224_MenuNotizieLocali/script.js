let citta = ["Milano", "Roma", "Torino", "Napoli", "Bologna", "Firenze"];
let cittaInit = citta.slice();

function mostraMenu()
{
    let html = "";

    for (let i = 0; i < citta.length; i++)
    {
        html += "<li>" + citta[i] + "</li>";
    }

    document.getElementById("listaCitta").innerHTML = html;
    document.getElementById("info").innerHTML =
    "Numero città: " + citta.length;
}

function aggiungiFine()
{
    let nome = document.getElementById("nuovaCitta").value;
    
    if (nome != "")
    {
        citta.push(nome);
        mostraMenu();
    }
}

function aggiungiInizio()
{
    let nome = document.getElementById("nuovaCitta").value;

    if (nome != "")
    {
        citta.unshift(nome);
        mostraMenu();
    }
}


function rimuoviFine()
{
    if (citta.length > 0)
    {
        citta.pop();
        mostraMenu();
    }
}

function rimuoviInizio()
{
    if (citta.length > 0)
    {
        citta.shift();
        mostraMenu();
    }
}

function primeQuattro()
{
    citta = cittaInit.slice(0, 4);
    mostraMenu();
}

function ultimeTre()
{
    citta = cittaInit.slice(-3);
    mostraMenu();
}

function ripristina()
{
    citta = cittaInit.slice();
    mostraMenu();
}

mostraMenu();
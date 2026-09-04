let naviIniziali = [
    { row: 0, col: 0 },
    { row: 1, col: 0 },
    { row: 2, col: 0 },
    {row: 3, col: 0}
];

let navi = [...naviIniziali];

let count = 0;
let divCount = document.getElementById("tries");

let remain = navi.length;
let divRemain = document.getElementById("remain");

let time = 0;
let divTime = document.getElementById("time");

let timerId;

function Grid() {

    navi = [...naviIniziali];
    document.getElementById("grid").innerHTML = "";

    for (let col = 0; col < 8; col++) {
        for (let row = 0; row < 8; row++) {
            document.getElementById("grid").innerHTML += `<div class="cell" onclick="Cell(${row}, ${col}, this)"></div>`;
        }
    }

    document.getElementsByClassName("area")[0].style.display = "flex";
    document.getElementById("btn-start").style.display = "none";
    document.getElementsByClassName("card")[0].style.display = "flex";

    count = 0;
    remain = navi.length;
    time = 0;

    divCount.textContent = `Tentativi: ${count}`;
    divRemain.textContent = `Caselle rimaste: ${remain}`;
    divTime.textContent = `Tempo: ${time}`;

    clearInterval(timerId);

    timerId = setInterval(() => {
        time++;
        divTime.textContent = `Tempo: ${time}`;
    }, 1000);
}



function Cell(row, col, cell) {

    if (cell.classList.contains("clicked")) {
        return;
    }

    cell.classList.add("clicked");
    count++;

    let found = false;
    let foundIndex = -1;

    for (let i = 0; i < navi.length; i++) {
        if (navi[i].row === row && navi[i].col === col) {
            found = true;
            foundIndex = i;

            break;
        }
    }

    if (found) {
        cell.style.backgroundColor = "red";
        remain--;
        navi.splice(foundIndex, 1);
        cell.classList = "damage";
        cell.textContent = "🎯";
    } else {
        cell.style.backgroundColor = "#00e1ff";
        cell.classList = "water";
        cell.textContent = "💦";
    }

    divCount.textContent = `Tentativi: ${count}`;
    divRemain.textContent = `Caselle rimaste: ${remain}`;

    if (remain === 0) {
        cell.classList = "cellDone";
        document.getElementById("final-message").textContent = `Hai trovato tutte le navi in ${count} tentativi e ${time} secondi!`;
        document.getElementById("btn-start").style.display = "block";
        clearInterval(timerId);
        
        divCount.style.display = "none";
        divRemain.style.display = "none";
        divTime.style.display = "none";

    }
}
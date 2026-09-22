const persone = ["👩","👨","🧑","👩‍🦰","👨‍🦱","👩‍🦱","👨‍🦳","👩‍🦳","👱‍♀️","👱‍♂️","🧔","🧑‍🦰","👵","👴","👧","👦"];
let sceltaGiocatore1;
let sceltaGiocatore2;

var gridGiocatore1 = [];
var gridGiocatore2 = [];
let turno = false;

const main = document.querySelector("main");
const cell = document.createElement("div");
const grid = document.createElement("div");
let giocatore = 1;
const divTurno = document.getElementById("turno");
divTurno.textContent = "Turno del 1' giocatore";

CreaGrid();

function CreaGrid(){
    const grid = document.createElement("div");
    grid.className = "grid";
    
    for (let i = 0; i < persone.length; i++){
        const cell = document.createElement("div");
        cell.className = "cell";
        cell.textContent = persone[i];
        cell.id = i;

        grid.appendChild(cell);

        gridGiocatore1.push(true);
        gridGiocatore2.push(true);

        cell.addEventListener("click", (e) =>{
            const scelta = e.currentTarget.textContent;
            
            if (giocatore == 1){
                sceltaGiocatore1 = scelta;
                console.log(sceltaGiocatore1);
                giocatore++;
                divTurno.textContent = "Turno del 2' giocatore";

            }
            else if (giocatore == 2){
                sceltaGiocatore2 = scelta;
                console.log(sceltaGiocatore2);
                giocatore++;
                divTurno.textContent = "Tocca al giocatore 1"
            }
            else{
                cell.style.visibility = "hidden";
                
                if (turno){
                    gridGiocatore1[i] = false;
                }
                else if (!turno){
                    gridGiocatore2[i] = false;
                }
            }
        })
    }

    main.appendChild(grid)
}


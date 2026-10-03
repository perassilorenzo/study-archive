const persone = [
	"👩",
	"👨",
	"👴",
	"👵",
	"👩‍🦰",
	"👨‍🦰",
	"👩‍🦱",
	"👨‍🦱",
	"👩‍🦳",
	"👨‍🦳",
	"👩🏻",
	"👨🏻",
	"👩🏽",
	"👨🏽",
	"👩🏿",
	"👨🏿"
];

//Contiene le celle presenti o nascoste (potevate anche usare una matrice)
var grigliaGiocatore1 = []
var grigliaGiocatore2 = []

//Contiene i personaggi scelti
var giocatore1, giocatore2

var _turno = document.getElementById("turno")
var _btnPassa = document.querySelector("#btnPassa")
let _main = document.querySelector("main")
var stato = 1, turno = 1


creaGriglia();
//1. Creazione dinamica della griglia di scelta per il primo giocatore
cambiaStato(1, "Giocatore 1 seleziona il personaggio")
_btnPassa.addEventListener("click", ()=>{
    let vittoria = false;
    if (turno == 1)
    {
        if (verificaVincita(grigliaGiocatore1, giocatore2)){
            vittoria = true
            alert("Il giocatore 1 ha vinto!");
        }
    }    
    else
    {
        if (verificaVincita(grigliaGiocatore2, giocatore1)){
            vittoria = true;    
            alert("Il giocatore 2 ha vinto");
        }
    }

    if (!vittoria){
        _main.innerHTML = "";
        turno = turno==1?2:1;
        setTimeout(() =>{
            creaGriglia()
        }, 3000);
    }




})

function cambiaStato(num, descr){
    stato = num
    _turno.textContent = descr
}

function creaGriglia(){
    //let cont = 0 
    for(let i in persone){
        let div = document.createElement("div")
        if (stato == 3 && (turno == 1 && grigliaGiocatore1[i] == false || turno == 2 && grigliaGiocatore2[i] == false)){
            div.textContent = "";
        }
        else
            div.textContent = persone[i]

        //div.id = cont++
        _main.append(div)
        if(stato==1){
            grigliaGiocatore1.push(true)
            grigliaGiocatore2.push(true)
        }
        
            
        div.addEventListener("click", ()=>{
            if(stato == 1){
                giocatore1 = persone[i]
                //2. Creazione dinamica della griglia di scelta per il secondo giocatore
                cambiaStato(2, "Giocatore 2 seleziona il personaggio")
            }else if(stato == 2){
                giocatore2 = persone[i]
                cambiaStato(3, "Sta per iniziare il gioco")
            }else{
                div.style.visibility = "hidden"
                if(turno == 1)
                    grigliaGiocatore1[i] = false
                else if(turno == 2)
                    grigliaGiocatore2[i] = false
                //turno = turno==1?2:1 //DAFARE: Ripassare la gestione dei turno con il modulo
                //div.style.display = "none" //Attenzione! La tabella viene modificata dalla cancellazione
            }
        })
    }


}

function verificaVincita(grid, personaggio){
    let i = 0, trovato = 0, temp = null
    while(i < grid.length && trovato < 2){
        if (grid[i]){
            trovato++;
            temp = persone[i];

        }
        i++;
    }

    return trovato == 1 && temp == personaggio

}
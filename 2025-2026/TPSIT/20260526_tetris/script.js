let campo = [];

function creaCampo(){
    for (let i = 0; i < 20; i++){
        for (let j = 0; j < 10; j++){
            campo[i][j] = null;
        }
    }
}

function creaPezzo(tipo){
    let pezzo = [];
    switch (tipo){
        case "I":
            pezzo = [
                [0, 0, 0, 0],
                [1, 1, 1, 1],
                [0, 0, 0, 0],
                [0, 0, 0, 0]
            ];
            break;
        
        case "O":
            pezzo = [
                [0, 0, 0, 0],
                [0, 1, 1, 0],
                [0, 1, 1, 0],
                [0, 0, 0, 0]
            ];
            break;

        case "T":
            pezzo = [
                [0, 0, 0, 0],
                [0, 1, 0, 0],
                [1, 1, 1, 0],
                [0, 0, 0, 0]
            ];
            break;

        case "S":
            pezzo = [
                [0, 0, 0, 0],
                [0, 1, 1, 0],
                [1, 1, 0, 0],
                [0, 0, 0, 0]
            ];
            break;

        case "Z":
            pezzo = [
                [0, 0, 0, 0],
                [1, 1, 0, 0],
                [0, 1, 1, 0],
                [0, 0, 0, 0]
            ];
            break;

        case "J":
            pezzo = [
                [0, 0, 0, 0],
                [1, 0, 0, 0],
                [1, 1, 1, 0],
                [0, 0, 0, 0]
            ];
            break;

        case "L":
            pezzo = [
                [0, 0, 0, 0],
                [0, 0, 1, 0],
                [1, 1, 1, 0],
                [0, 0, 0, 0]
            ];
            break;
    }
    return pezzo;

}

function mossaValida(pezzo, deltaX, deltaY){
    pezzo.x += deltaX;
    pezzo.y += deltaY;

    if (pezzo.x < 0 || pezzo.x + 4 > 10 || pezzo.y < 0 || pezzo.y + 4 > 20){
        pezzo.x -= deltaX;
        pezzo.y -= deltaY;
        return false;
    }
    return true;
}

function ruotaMatrice(matrice){
    let matriceRuotata = [];
    for (let i = 0; i < matrice.length; i++){
        for (let j = 0; j < matrice.length; j++){
            matriceRuotata[j][matrice.length - 1 - i] = matrice[i][j];
        }    
    }
    return matriceRuotata;
}

function ruota(){

}

function bloccaPezzo(){

}

function eliminaRigheComplete(){

}

document.addEventListener("keydown", (e)=>{
    if (e === "ArrowLeft"){
        // sposta a sinistra
    }
    else if (e === "ArrowRight"){
        // sposta a destra
    }
    else if (e === "ArrowDown"){

    }
    else if (e === "ArrowUp" || e === "Space"){

    }
    else if (e === "Enter"){

    }
})
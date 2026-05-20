"option strict" // siamo obbligati a dischiarare le variabili

let index = 1;
let ruota;

function cambiaImg(){
    h3img.textContent = `Immagine n'${index}`;
    setTimeout(eseguiCambiaImg, 3000);
}

function eseguiCambiaImg(){
    imgCarta.src = `img/img/q${index}.gif`;
    index++;

    if (index > 9) index = 1;
}

// setInterval()
// esegue la funzione ripetutamente ogni N millisecondi
// restituisce un indice numerico
function ruotaImg(){
    ruota = setInterval(eseguiCambiaImg, 1500)    
}

// clearInterval()
// ferma un setInterval
// parametro è l'indice numerico ritronato dalla setInterval
function stopRot(){
    clearInterval(ruota);
    ruota = null;
}

function apriFin(){
    // window.open("new.html", "_self")
    window.open("new.html", "", width = 350, height = 200)
}


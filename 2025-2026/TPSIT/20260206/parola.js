NuovaParola(Math.floor(Math.random()*10-1+1)+1);
let result = new Array(parolaSegreta.length);

for (let i = 0; i < parolaSegreta.length; i++){
    if (i == 0 || i == parolaSegreta.length - 1){
        document.getElementById("parola").innerHTML += `${parolaSegreta.charAt(i)}`;
        result[i] = parolaSegreta.charAt(i);
    }
    else if(parolaSegreta.charAt(i) == " "){

    }
    else {
        document.getElementById("parola").innerHTML += ` _ `;
        result[i] = " _ ";
    }
}

function NuovaParola(parola){
    switch (parola) {
        case 1:
            parolaSegreta = "ciao".toUpperCase();
            break;

        case 2:
            parolaSegreta = "sole".toUpperCase();
            break;

        case 3:
            parolaSegreta = "luna".toUpperCase();
            break;

        case 4:
            parolaSegreta = "mare".toUpperCase();
            break;

        case 5:
            parolaSegreta = "vento".toUpperCase();
            break;

        case 6:
            parolaSegreta = "fuoco".toUpperCase();
            break;

        case 7:
            parolaSegreta = "neve".toUpperCase();
            break;

        case 8:
            parolaSegreta = "pianta".toUpperCase();
            break;

        case 9:
            parolaSegreta = "scuola".toUpperCase();
            break;

        case 10:
            parolaSegreta = "gatto".toUpperCase();
            break;
    }
}
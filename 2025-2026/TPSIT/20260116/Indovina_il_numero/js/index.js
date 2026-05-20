let numerosegreto; // variabile che conterrà il sorteggio
let cont; //variabile che terrà conto dei tentativi

function genera(){
    //genera un numero casuale tra 1 e 100
    // Math.random() genera valori casuali tra 0 e 1 escluso quindi tra 0 e 0.999999999999
    //Math.random()*100 -tra 0 e 100
    //(Math.random()*100)+1
    // min=1 e max=100
    // Math.random()*(max-min+1) + min
    //Math.floor tronca il valore di x alla parte intera 99.99 -> 99
    //Math.floor(Math.random()*(max-min+1)) + min 
    numerosegreto = Math.floor(Math.random() * (100-1+1))+1;
    console.log(numerosegreto);    
    cont=5;
    document.getElementById("tentativi").innerHTML=`Tentativi rimasti: ${cont}`;
    document.getElementById("risultato").innerHTML="";   
}

function confronta(){
    if (document.getElementById("txtUtente").value=="")
    {
        document.getElementById("risultato").innerHTML=`Inserire almeno un valore nella textbox`
    }else{
        cont--;
        if(cont >= 0)
        {
            let txtNumero = parseInt(document.getElementById("txtUtente").value);
            if (txtNumero == numerosegreto)
            {
                document.getElementById("risultato").innerHTML=`Hai indovinato`;
            }
            else if (txtNumero > numerosegreto)
            {
                document.getElementById("risultato").innerHTML=`Inserisci un numero più piccolo`;
                document.getElementById("tentativi").innerHTML=`Tentativi rimasti: ${cont}`;
            }
            else
            {
                document.getElementById("risultato").innerHTML=`Inserisci un numero più grande`;
                document.getElementById("tentativi").innerHTML=`Tentativi rimasti: ${cont}`;
            }
        }
        else{
            console.log("Contatore < 0");
            document.getElementById("risultato").textContent=`Hai terminato i tuoi tantativi`;
        }
    }
} 
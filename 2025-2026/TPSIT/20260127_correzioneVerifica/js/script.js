// operatore ternario:
// condizione ? espressoine1 : espressione2

let rispostaSelezionata;

function mostraSezione()
{
    document.getElementById("video").innerHTML = ``;
    document.getElementById("quiz").style.display="block";
}

function selezionaRisposta(numeroRisposta)
{
    r0=document.getElementById("zero");
    r1=document.getElementById("uno");
    r2=document.getElementById("due");

    if(numeroRisposta==0)
    {
        r0.style.background="#e0e0e0";
    }
    else if(numeroRisposta==1)
    {
        r1.style.background="#e0e0e0";
    }
    else
    {
        r2.style.background="#e0e0e0";
    }

    rispostaSelezionata = numeroRisposta;
    document.getElementById("btnVerifica").disabled = false;
}

function VericaRisposta(){
    areaRis=document.getElementById("area-risulato");
    if(rispostaSelezionata == 1)
    {
        numero1=Math.floor(Math.random()*(3-0+1)+0);
        
        if(numero1 == 3)
        {
            numero2=Math.floor(Math.random()*(8-5+1)+5);
        
            if(numero2 == 5)
            {
                areaRis.innerHTML = `COMPLIMENTI! Hai vinto un biglietto per pattinaggio sul ghiaccio`;
            }

        }
        else
        {
            areaRis.innerHTML = `Risposta corretta ma non hai vinto il biglietto`;
        }
    }
    else
    {
        areaRis.innerHTML = `Risposta sbagliata! Riprova!`;
    }
}


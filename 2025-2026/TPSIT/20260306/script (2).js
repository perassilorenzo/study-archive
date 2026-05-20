function leggiScelta(){
    let radios = document.getElementsByName("linguaggio");
    let scelta = "";

    for (let i = 0; i < radios.length; i++)
    {
        if (radios[i].checked)
        {
            scelta = radios[i].value;
        }
    }

    if (scelta == "")
    {
        document.getElementById("risultato").innerHTML = "Non hai selezionato nessuna risposta";
    }
    else
    {
        document.getElementById("risultato").innerHTML = `Hai scelto: ${scelta}`;
    }
}
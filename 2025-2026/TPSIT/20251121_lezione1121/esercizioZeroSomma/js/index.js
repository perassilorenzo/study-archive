function somma(){
    let txt1 = document.getElementById("txt1");
    // alert(txt1)
    let txt2 = document.getElementById("txt2");
    let ris = parseInt(txt1.value) + parseInt(txt2.value);
    alert(`Il risultato è ${ris}`);
}

function sottrazione(){
    let txt1 = document.getElementById("txt1");
    let txt2 = document.getElementById("txt2");
    let ris = parseInt(txt1.value) - parseInt(txt2.value);
    alert(`Il risultato è ${ris}`);
}

function moltiplicazione(){
    let txt1 = document.getElementById("txt1");
    let txt2 = document.getElementById("txt2");
    let ris = parseInt(txt1.value) * parseInt(txt2.value);
    alert(`Il risultato è ${ris}`);
}

function divisione(){
    let txt1 = document.getElementById("txt1");
    let txt2 = document.getElementById("txt2");
    let ris = parseInt(txt1.value) / parseInt(txt2.value);
    alert(`Il risultato è ${ris}`);
}
let dateStart;

function prendiBiglietto(){
    const ticket = document.getElementById("ticket");
    const numero = document.getElementById("numero");
    const data = document.getElementById("data");
    const ora = document.getElementById("ora");
    
    dateStart = new Date();
    // let date = new Date("2020-12-25");  // data stringa
    // new Date(anno, mese, giorno, ore, minuti, secondi, ms)

    // alert(dateStart);
    // alert(date);

    let number = Math.floor(Math.random() * 9000) + 1000;

    numero.textContent = `Ticket n. ${number}`;
    
    // getFullYear();  //2026
    // getMonth(); //5
    // getDay();   //5 giorno settimanale
    // getDate();  // 29 giorno del mese
    // getHours()  //11
    // getMinutes()    //5
    // getSeconds()    //0-59
    // getMilliseonds()    //0-999
    // getTime()  
    
    // dateStart.toLocaleDateString    // 29-05-2026
    // dateStart.toLocaleTimeString    // 11:09

    // let x = new Date(a, b, c)

    let day = dateStart.getDate();
    let month = dateStart.getMonth();
    let year = dateStart.getFullYear();
    
    data.textContent = `Date: ${day}-${month}-${year}`;
    
    let seconds = dateStart.getSeconds();
    let minutes = dateStart.getMinutes();
    let hours = dateStart.getHours();
    
    ora.textContent = `Time: ${hours}:${minutes}:${seconds}`;
    
    ticket.style.opacity = "1";
    ticket.classList.remove("nascosto");
    ticket.classList.add("esce");

    document.getElementById("btnPrendi").disabled = true;
    document.getElementById("btnInserisci").disabled = false;
}

function inserisciBiglietto(){
    ticket.classList.add("entra");
    setTimeout(()=>{
        ticket.classList.add("nascosto");
        ticket.style.opacity = "0";
        ticket.classList.remove("entra");
        ticket.classList.remove("esce");
    }, 2000);

    document.getElementById("btnPrendi").disabled = false;
    document.getElementById("btnInserisci").disabled = true;

    let dateEnd = new Date();

    // differenza in millisecondi
    let diff = dateEnd - dateStart

    let minuti = Math.floor(diff/60000);
    let ore = Math.ceil(minuti/60);

    let costo 

    if (ore <= 1) costo = 2;
    else costo = (ore - 1) * 1.5;

    document.getElementById("risultato").innerHTML = `Tempo trascorso: ${minuti} minuti<br>Totale da pagare: ${costo}€`;

}
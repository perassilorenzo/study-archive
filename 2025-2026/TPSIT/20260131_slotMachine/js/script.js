let count = 0;

function gioca(){
    let n1 = RandomNumber();
    let n2 = RandomNumber();
    let n3 = RandomNumber();

    document.getElementById("n1").innerHTML = `${n1}`;
    document.getElementById("n2").innerHTML = `${n2}`;
    document.getElementById("n3").innerHTML = `${n3}`;
    
    if (n1 == n2 && n1 == n3 && n2 == n3){
        count = 0;
        document.getElementById("messaggio").innerHTML = `Jackpot`;
        document.getElementById("count").innerHTML = ``;
    }
    else if (n1 == n2 || n2 == n3 || n1 == n3){
        count += 1;
        document.getElementById("messaggio").innerHTML = `Ci sei quasi`;
        document.getElementById("count").innerHTML = `Streak di giocate perse: ${count}`;
    }
    else {
        count += 1;
        document.getElementById("messaggio").innerHTML = `Riprova`;
        document.getElementById("count").innerHTML = `Streak di giocate perse: ${count}`;
    }
}

function RandomNumber(){
    return Math.floor(Math.random()*(9-1+1)+1);
}
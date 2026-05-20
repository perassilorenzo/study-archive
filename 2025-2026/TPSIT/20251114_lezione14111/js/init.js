let nome = 'Mario';

alert(nome.length);
console.log(nome.length);

nome = 10;
nome += 5;
console.log(nome);
alert(nome);

let array = [1, 2, 3];
console.log(array[0]);

for (let i = 0; i < array.length; i++)
{
    alert(array[i]);
}

let persona = {nome: 'Luca', eta: 30};
console.log(persona.nome);

// {key: value, key: value}

persona = {nome: 'Lorenzo', eta: 16, capelli: 'marroni', nascita: '18/04/2009', citta: 'Saluzzo'};
alert(Object.values(persona));

// funzioni

function saluta(){
    alert('ciao');
}

function calcoloSomma(){
    let n1 = parseFloat(document.getElementById("input1").value);
    let n2 = parseFloat(document.getElementById("input2").value);
    let somma = n1 + n2;

    alert(somma);
}


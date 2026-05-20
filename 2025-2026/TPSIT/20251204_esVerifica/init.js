function mostraDadi() {
    document.getElementById("sezione-dadi").classList.remove("hidden");
    window.location = "#sezione-dadi";
}

function nascondiDadi() {
    document.getElementById("sezione-dadi").classList.add("hidden");
    window.location = "#giochi";
}

function lanciaDadi() {

    let dadi = [];
    for (let i = 0; i < 5; i++) {
        dadi[i] = Math.floor(Math.random() * 6) + 1;
    }

    // aggiorno immagini
    for (let i = 0; i < 5; i++) {
        document.getElementById("d" + (i + 1)).src = "img/dado" + dadi[i] + ".png";
    }

    // SOMMA
    let somma = dadi.reduce((a, b) => a + b);
    document.getElementById("somma").innerText = "Somma: " + somma;

    // FREQUENZE
    let freq = [0, 0, 0, 0, 0, 0];
    dadi.forEach(n => freq[n - 1]++);

    document.getElementById("frequenze").innerText =
        `Frequenze: 1→${freq[0]}, 2→${freq[1]}, 3→${freq[2]}, 4→${freq[3]}, 5→${freq[4]}, 6→${freq[5]}`;

    // COPPIE & TRIS
    let coppie = 0;
    let tris = 0;

    freq.forEach(f => {
        if (f === 2) coppie++;
        if (f === 3) tris++;
    });

    document.getElementById("coppie").innerText = "Coppie: " + coppie;
    document.getElementById("tris").innerText = "Tris: " + tris;
}

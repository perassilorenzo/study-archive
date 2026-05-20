// movimento dello user

const player = document.querySelector('.player');
const container = document.querySelector('.game');

window.addEventListener('keydown', (e) => {
    let currentLeft = parseInt(player.style.left || 0);
    let step = 10;

    const maxRight = container.clientWidth - player.clientWidth;

    if (e.key === 'ArrowLeft') {
        currentLeft -= step;
    }   
    else if (e.key === 'ArrowRight') {
        currentLeft += step;
    }

    if (currentLeft < 0) currentLeft = 0;
    if (currentLeft > maxRight) currentLeft = maxRight;

    player.style.left = currentLeft + 'px';
});

// movimento della pioggia

const drop = document.querySelectorAll(".drop");

drop.forEach((goccia) => {
    goccia.addEventListener("animationiteration", () => {
        goccia.style.left = Math.random() * (container.clientWidth - goccia.clientHeight) + "px";
        goccia.style.top = "-50px";
    })
})

// movimento del bonus

const bonus = document.querySelector(".bonus");

bonus.addEventListener("animationiteration", () => {
    bonus.style.left = Math.random() * (container.clientWidth - bonus.clientWidth) + "px";
})

// collisioni

let punteggio = 0;

setInterval(() => {

    const p = player.getBoundingClientRect();
    const b = bonus.getBoundingClientRect();

    drop.forEach((goccia) => {
        const g = goccia.getBoundingClientRect(); 
        
        if (Collisions(p, g)) {
            punteggio--;
            alert(`Hai perso! ${punteggio}`);
        }
    }); 

    if (Collisions(p, b)) {
        punteggio++;
        alert(`Hai vinto! ${punteggio}`);
    }

    // document.querySelector(".punteggio").innerHTML = `Punteggio: ${punteggio}`;

    // if (punteggio === 3) punteggio = 0;
}, 100);

function Collisions(object1, object2) {
    return !(   object1.right < object2.left || object1.left > object2.right || object1.bottom < object2.top || object1.top > object2.bottom);
}




// ====================================================== in classe ======================================================

// const player = document.querySelector(".player");
// const bonus = document.querySelector(".bonus");

// let x = 320;

// document.addEventListener("keydown", (e) => {
//     if (e.key === "ArrowRight"){
//         x += 20;
//     }
//     else if (e.key == "ArrowLeft"){
//         x -= 20;
//     }

//     if (x < 0) x = 0;
//     if (x > 640) x = 640;
//     player.style.left = x+"px";
// })

// setInterval(checkCollisions, 100);

// function checkCollisions(){
//     const playerR = player.getBoundingClientRect();
//     const bonusR = bonus.getBoundingClientRect();

//     if (
//         playerR.left < bonusR.right &&
//         playerR.right > bonusR.left &&
//         playerR.top < bonusR.bottom &&
//         playerR.bottom > bonusR.top
//     )
//     {
//         bonus.style.top = "-50px";
//         bonus.style.left = Math.random() * 640 + "px"
//         alert("HAI PRESO UN SOLE")
//     }

//     drop.forEach((goccia) => {
//         const gocciaR = goccia.getBoundingClientRect();

//         if(
//             playerR.left < gocciaR.right &&
//             playerR.right > gocciaR.left &&
//             playerR.top < gocciaR.bottom &&
//             playerR.bottom > gocciaR.top
//         )
//         {
            
//         }
//     }
// }

// // da il rettangolo dove posso confrontarlo con un rettangolo che ho sull'altro oggetto, returna un oggetto completo con proprietà fisiche, altezza e larghezza
// // getBoundingClientRect() 
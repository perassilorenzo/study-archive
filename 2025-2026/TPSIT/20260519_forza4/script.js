const player = document.getElementById("player")
let x = 0;
let isAnimating = false;
let isRedTurn = true;
let grid = [
    [0,0,0,0,0,0],
    [0,0,0,0,0,0],
    [0,0,0,0,0,0],
    [0,0,0,0,0,0],
    [0,0,0,0,0,0],
    [0,0,0,0,0,0],
];

window.addEventListener('keydown', (e) => {
    if (e.key == "ArrowRight"){
        if (isAnimating) return;
        x += 216;
    }

    else if (e.key == "ArrowLeft"){
        if (isAnimating) return;
        x -= 216;
    } 
    
    else if (e.key == "ArrowDown"){
        if (isAnimating) return;

        isAnimating = true;

        player.classList.add("drop");

        player.addEventListener('animationend', () =>{
            player.classList.remove("drop");
            isAnimating = false;

            isRedTurn = !isRedTurn;

            if (isRedTurn){
                player.classList.remove("bg-warning");
                player.classList.add("bg-danger");
            }
            else{
                player.classList.remove("bg-danger");
                player.classList.add("bg-warning");
            }
            
            dropPiece();

        }, {once: true});
    }
    if (x <= 0) x = 0;
    if (x >= 1080) x = 1080;

    player.style.left = `${x}px`;
})

function dropPiece(col, player) {

    for (let row = 5; row >= 0; row--) {

        if (grid[col][row] === null) {

            grid[col][row] = player;

            render(col, row, player);

            return;
        }
    }
}

function render(col, row, player) {

    const index = row * 7 + col; // 7 colonne

    cells[index].classList.add(player);
}
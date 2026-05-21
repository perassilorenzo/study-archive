let isRedTurn = true;
let currentCol = 1;
let grid = [
    [0,0,0,0,0,0],
    [0,0,0,0,0,0],
    [0,0,0,0,0,0],
    [0,0,0,0,0,0],
    [0,0,0,0,0,0],
    [0,0,0,0,0,0],
];

function colChangeToWhite(colIndex){
    let col = document.getElementById(`col${colIndex}`);
    col.classList.remove("bg-danger");
    col.classList.remove("bg-warning");
    col.classList.add("bg-white");
}

function colChangeColor(colIndex){
    let col = document.getElementById(`col${colIndex}`);
    col.classList.remove("bg-white");
    col.classList.remove("bg-danger");
    col.classList.remove("bg-warning");
    if (isRedTurn) col.classList.add("bg-danger");
    else col.classList.add("bg-warning");
}

window.addEventListener('keydown', (e) => {

    if (e.key == "ArrowRight"){
        if (currentCol >= 6) return;

        colChangeToWhite(currentCol);
        currentCol++;
        colChangeColor(currentCol);
    }

    else if (e.key == "ArrowLeft"){
        if (currentCol <= 1) return;

        colChangeToWhite(currentCol);
        currentCol--;
        colChangeColor(currentCol);
    } 
    
    else if (e.key == "ArrowDown"){
        const dropped = addPiece(currentCol); 
        if (dropped){
            isRedTurn = !isRedTurn;           
            colChangeColor(currentCol);
        }            
    }
})

function addPiece(col){
    let allCells = document.querySelectorAll(".gameArea .row");
    for(let row = 5; row > 0; row--){
        if (grid[col-1][row] == 0){

            grid[col-1][row] = isRedTurn ? 1 : 2;

            let cell = allCells[row].querySelectorAll(".cicle")[col-1];
            cell.classList.remove("bg-white");
            if (!isRedTurn) cell.classList.add("bg-danger");
            else cell.classList.add("bg-warning");
        
            
        }
    }
}

// function dropPiece(col, player) {

//     for (let row = 5; row >= 0; row--) {

//         if (grid[col][row] === null) {

//             grid[col][row] = player;

//             render(col, row, player);

//             return;
//         }
//     }
// }

// function render(col, row, player) {

//     const index = row * 7 + col; // 7 colonne

//     cells[index].classList.add(player);
// }
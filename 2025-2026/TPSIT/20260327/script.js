const chat = document.getElementById("chat")
let message = document.getElementById("message")
let divReaction = document.getElementById("div-reaction-emoji");

function SendMessage(user){
    if(message.value == "") return;
    
    let newMessage = document.createElement("div");
    newMessage.textContent = message.value;
    newMessage.ondblclick = OpenReactionEmoji;
    chat.appendChild(newMessage);

    if (user == 1) newMessage.className = "div-message message-user1";
    else newMessage.className = "div-message message-user2";
}

function ModifyMessage(){
    if(message.value == "") return;
    
    let lastMessage = chat.lastElementChild;
    lastMessage.textContent = message.value;

    let newSpan = document.createElement("span")
    newSpan.textContent = "(modificato)"
    newSpan.style.color = "white"
    newSpan.style.fontSize = "10px"

    let newBr = document.createElement("br")
    
    lastMessage.appendChild(newBr)
    lastMessage.appendChild(newSpan)

}

let targetMessage = null;

function OpenReactionEmoji(){
    targetMessage = this;
    divReaction.style.display = "block";
}

function AddReactionEmoji(emoji){
    if (!targetMessage) return;
    let existingEmoji = targetMessage.querySelector(".div-emoji");
    
    if (!existingEmoji){
        let newDiv = document.createElement("div");
        newDiv.textContent = emoji;
        newDiv.className = "div-emoji";
        targetMessage.appendChild(newDiv);
    }
    else{
        existingEmoji.textContent = emoji;
    }

    CloseReactionEmoji();
}

function CloseReactionEmoji(){
    divReaction.style.display = "none";
}

/*
======================================================== TPSIT 0508 ========================================================

eventi comuni:

click --> utente clicca su un elemento
mouseover --> utente passa il mouse su un elemento
mouseout --> utente sposta il mouse fuori da un elemento
keydown --> utente preme un tasto sulla tastiera
input --> utente inserisce del testo in un campo di input
submit --> utente invia un modulo

*/

let btn_user1 = document.getElementById("btn-user1");
btn_user1.addEventListener("click", () => SendMessage(1));

let btn_user2 = document.getElementById("btn-user2");
btn_user2.addEventListener("click", () => SendMessage(2));

message.addEventListener("keydown", function(event){
    if(event.key == "Enter") SendMessage(1);
});
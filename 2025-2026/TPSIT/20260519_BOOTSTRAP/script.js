document.getElementById("btn-notifica").addEventListener('click', () => {
    document.getElementById("toast").classList.add("show");
    setTimeout(() => {
        document.getElementById("toast").classList.remove("show");
    }, 3000);
})
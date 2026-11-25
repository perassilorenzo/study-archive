# ATTENZIONE

Se si prova a lanciare in locale l'exploit, avere cura di passare all'headless un link che inizia con `http://service:3000`, in quanto questo è il dominio con il quale l'headless può accedere internamente alla challenge.

Quindi, se la nota è all'url `http://localhost:40002/note/2169d69e-165a-4eeb-95a7-5317021efa8b`, all'admin bisogna inviare `http://service:3000/note/2169d69e-165a-4eeb-95a7-5317021efa8b`.

QUESTA COSA VALE SOLO IN LOCALE, in remoto utilizzare normalmente il link della challenge.

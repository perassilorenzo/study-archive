#!/bin/bash

# 1. Creare il file "file-prova-1.txt" con all'interno la stringa
#    "Buongiorno Mondo"

echo "Buongiono Mondo" > "file-prova-1.txt"

# 2. Creare la cartella "cartella-prova-1"

mkdir "cartella-prova-1"

# 3. Copiare il file "file-prova-1.txt" dentro la
#    cartella "cartella-prova-1", dandogli il nuovo nome "prova-2.txt"

cp "file-prova-1.txt" "./cartella-prova-1/prova-2.txt"

# 4. Assegnare al file creato nel punto precedente i permessi di sola
#    lettura e scrittura per utente e gruppo
#    Nessun permesso deve essere dato all'infuori di quanto specificato.

chmod 660 "prova-2.txt"

# 5. Leggere dal primo argomento un valore, se questo valore è una stringa
#    uguale a "password-segretissima" stampare a video la scritta
#    "Accesso consentito", altrimenti la scritta "Accesso negato"

if [ "$1" == "password-segretissima" ]; then
    echo "Accesso consentito"
else
    echo "Accesso negato"
fi
 
# 6. Assegnare a una variabile "lorem_ipsum_words" i valori della seguente lista
#    "lorem" "ipsum" "dolor" "sit" "amet" "consectetur"
#    e stampare l'intera lista a video, scorrendola

"lorem_ipsum_words"=("lorem" "ipsum" "dolor" "sit" "amet" "consectetur")
for word in ${lorem_ipsum_words[@]}; do
    echo "$word"
done


#----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------#

# 7. Trovare quali comandi hanno un parametro "-r" fra quelli studiati
# "ls" "cd" "mv" "mkdir" "chmod" "rmdir" "rm" "chown" "echo" "sudo" "git"

commands=("ls" "cd" "mv" "mkdir" "chmod" "rmdir" "rm" "chown" "echo" "sudo" "git")
for command in ${commands[@]}; do
    command_help=$("$command --help | grep -- ' -r '")
    if [ "$command_help" != ""]; then
        echo "$command"
    fi
done

# 8. Stessa consegna del #7, ma salva tutto in un file (1 comando)

function commands_with_dash_r() {
    commands=("ls" "cd" "mv" "mkdir" "chmod" "rmdir" "rm" "chown" "echo" "sudo" "git")
    for command in ${commands[@]}; do
        command_help=$("$command --help | grep -- ' -r '")
        if [ "$command_help" != ""]; then
            echo "$command"
        fi
    done    
}

commands_with_dash_r > file.txt

# 9. Data una cartella in input, contare quanti file con estensione ".log" ci sono.
# Se specifico come primo parametro "-r" controlla anche la sotto-cartelle e aggiunge al conteggio
# count_logs -r .
# count_logs cartella
# count_logs -r cartella

function count_logs () {
    recursive="false"
    directory=""
    if [ $# -lt 1 ]; then
        echo "Usage: count_logs [-r] DIRECTORY"
    elif [ $# -eq 1 ]; then
        directory="$1"
    elif [ "$1" == "-r" ]; then
        recursive="true"
        directory="$2"
    else
        directory="$1"
    fi

    count="0"
    file_list="$(ls)"
    for file in ${file_list[@]}; do
        is_log="$(grep '.log' -- $file)"
        if [ $is_log != "" ]; then
            count=$((count + 1))
        fi

        is_directory=$(ls -l $file | grep '-d' -- $file)
        if [ ${is_directory:0:1} == "d" -a $recursive == "true" ]; then
            inner_count=$(count_logs -r $file)
            count=$((count + inner_count))
        fi
    done

    echo "$count"
}
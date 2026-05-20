🏗️ Struttura Base e Contenitori (19/09/2025)

Questi tag definiscono lo scheletro e la gerarchia della pagina.

    Struttura Essenziale:

        <HTML>: Apertura e chiusura della pagina web.

        <HEAD>: Contiene i metadati, invisibili all'utente.

        <BODY>: Contiene il contenuto visualizzato dall'utente.

    Contenitori Principali:

        <DIV>: Principale tag di contenimento a livello di blocco.

        <TITLE>: Metadato in <HEAD> che definisce il titolo della scheda del browser.

    Contenuto Testuale Base:

        <h1> a <h6>: Intestazioni (heading) gerarchiche (H1 è il più grande).

        <p>: Paragrafo.

    Ausiliario:

        ``: Sintassi per inserire commenti nel codice.

📝 Formattazione del Testo e Liste (26/09/2025)

Tag per la presentazione del testo e l'organizzazione in elenchi.

    Formattazione Visiva:

        <b> / <i> / <u>: Grassetto, Corsivo, Sottolineato.

        <del>: Testo barrato (cancellato).

        <sup> / <sub>: Testo in Apice (sopra) o Pedice (sotto).

    Formattazione Semantica:

        <strong>: Indica che un contenuto è importante (solitamente grassetto).

        <em>: Indica enfasi nel discorso (solitamente corsivo).

    Elementi di Separazione e Ausiliari:

        <span>: Contenitore neutro a livello in linea.

        <hr>: Inserisce una riga orizzontale di separazione.

        <br>: Forza una interruzione di riga (vai a capo).

    Liste:

        <ul>: Lista non ordinata (puntata).

        <ol>: Lista ordinata (numerata).

        <li>: Elemento della lista.

        <dl>: Lista di definizioni, con <dt> (Termine) e <dd> (Definizione).

🖼️ Tag Multimediali (10/10/2025)

Inserimento di immagini, video e audio.

    Immagini:

        <img>: Tag per l'immagine (senza chiusura).

            Attributi Essenziali: src (sorgente), alt (testo alternativo/visibile).

        <figure> / <figcaption>: Contenitore per elementi indipendenti e la sua didascalia.

    Video e Audio:

        <video> / <audio>: Tag per l'inserimento di video o tracce audio.

        <source>: Definisce le diverse sorgenti (src e type) per video/audio.

    Incorporamento Esterno:

        <iframe>: Incorpora codice o contenuti esterni (es. video di YouTube).

    Attributi Comuni Media:

        controls: Mostra i controlli di riproduzione.

        autoplay / loop / muted: Avvia automaticamente, riproduce in loop, silenzia.

        preload: Controlla il pre-caricamento (metadata o none).

        poster (solo video): Imposta l'immagine di copertina.

📝 Moduli (Form): Struttura e Input (29/10/2025)

Creazione di moduli per la raccolta di dati e l'interazione utente.

    Struttura del Modulo:

        <form>: Contenitore principale del modulo.

        <fieldset> / <legend>: Raggruppa i campi visivamente e il relativo titolo.

        <label>: Etichetta descrittiva associata a un campo.

    Campo Input Standard:

        <input>: Tag principale per campi interattivi. Il comportamento è definito dall'attributo type.

    Tipi di Input (type="..."):

        Testuali: text, email, tel, url, search.

        Numerici/Intervallo: number, range.

        Data/Tempo: date, time, month, week.

        Bottoni: submit (invia), reset (cancella), button (generico).

        Invisibile: hidden.

        Selezione: radio (scelta singola), checkbox (scelta multipla).

    Attributi Chiave per Form e Input:

        action / method: Dove e come inviare i dati.

        name: Identificatore del campo (essenziale per l'invio dati).

        placeholder: Testo guida che appare nel campo.

        required / readonly / disabled: Rende il campo obbligatorio, non modificabile o disabilitato.

        maxlength / pattern / title: Limiti caratteri, formato richiesto, messaggio di errore.

        autofocus: Posiziona il cursore all'apertura.

🎯 Elementi di Selezione Avanzati

    Liste di Opzioni:

        <select> / <option>: Campo di selezione a tendina e singole opzioni.

        <optgroup>: Raggruppa le opzioni all'interno di <select>.

        <datalist>: Contiene una lista di suggerimenti da agganciare a un <input type="text"> tramite l'attributo list.
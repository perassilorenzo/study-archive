# Appunti Completi di Elettrotecnica: Dalla Teoria alla Pratica

---

## 1. Grandezze Elettriche Fondamentali e Principi Base

### 1.1 Tensione, Corrente e Legge di Ohm
* **Corrente Elettrica ($I$):** Rappresenta il movimento ordinato di cariche elettriche (elettroni) all'interno di un conduttore. Si misura in **Ampere (A)**.
* **Tensione Elettrica / Differenza di Potenziale ($V$ o $U$):** È il lavoro necessario per spostare una carica unitaria tra due punti. Si misura in **Volt (V)**.
* **Resistenza Elettrica ($R$):** Misura l'opposizione che un materiale offre al passaggio della corrente. Si misura in **Ohm ($\Omega$)**.

#### Legge di Ohm Fondamentale
Per un resistore ideale, la tensione ai capi è **direttamente proporzionale** alla corrente che lo attraversa:
$$V = R \cdot I \implies I = \frac{V}{R} \implies R = \frac{V}{I}$$

> **Nota di attenzione:** Tensione e corrente sono direttamente proporzionali (se aumenta $I$, aumenta $V$). Non sono inversamente proporzionali.

---

### 1.2 Potenza Elettrica e Conservazione dell'Energia
* **Potenza Dissipata dai Resistori ($P_d$):** I resistori trasformano l'energia elettrica in calore (effetto Joule):
  $$P = V \cdot I = R \cdot I^2 = \frac{V^2}{R} \quad \text{[Watt, W]}$$
* **Potenza Generata dai Generatori ($P_g$):**
  $$P_g = E \cdot I_g \quad \text{[W]}$$
* **Principio di Conservazione dell'Energia (Bilancio delle Potenze):** In qualsiasi circuito chiuso, la potenza totale erogata dai generatori deve essere sempre esattamente uguale alla somma delle potenze dissipate da tutti i resistori presenti:
  $$\sum P_{\text{generata}} = \sum P_{\text{dissipata}}$$

---

## 2. Topologia dei Circuiti e Leggi di Kirchhoff (LKC e LKV)

### 2.1 Elementi Topologici
* **Nodo:** Punto del circuito in cui confluivano/convergono **almeno 3 conduttori (lati)**.
* **Ramo (o Lato):** Componente o serie di componenti compresi tra due nodi.
* **Maglia:** Un percorso chiuso formato da un insieme continuo di lati, in cui nessun nodo viene attraversato più di una volta.

---

### 2.2 Prima Legge di Kirchhoff (LKC - Legge dei Nodi)
Basata sulla conservazione della carica elettrica: la somma delle correnti entranti in un nodo è uguale alla somma delle correnti uscenti.
$$\sum I_{\text{entranti}} = \sum I_{\text{uscenti}} \implies \sum_{k=1}^{n} I_k = 0$$

---

### 2.3 Seconda Legge di Kirchhoff (LKV - Legge delle Maglie)
Basata sulla conservazione dell'energia: la somma algebrica delle tensioni lungo qualsiasi maglia chiusa è pari a zero.
$$\sum_{k=1}^{n} V_k = 0$$

> **Concetto Chiave sulle Tensioni nei Nodi:** 
> La tensione non "passa" da un nodo all'altro come fa la corrente. Ogni nodo si trova a un determinato **potenziale elettrico** espresso rispetto a un nodo di riferimento (massa, $0\text{ V}$). La tensione tra due nodi $A$ e $B$ è la differenza di potenziale $V_{AB} = V_A - V_B$.

---

## 3. Semplificazione delle Reti Resistive (Serie e Parallelo)

### 3.1 Resistori in Serie
Due o più resistori sono in **serie** se sono attraversati dalla **stessa identica corrente**.
* **Resistenza Equivalente ($R_{eq}$):** Si sommano direttamente le resistenze:
  $$R_{eq} = R_1 + R_2 + R_3 + \dots + R_n$$
* **Proprietà:** La tensione totale si suddivide proporzionalmente ai valori delle resistenze (Partitore di Tensione).

---

### 3.2 Resistori in Parallelo
Due o più resistori sono in **parallelo** se sono sottoposti alla **stessa identica tensione** (ossia collegati agli stessi due nodi).
* **Resistenza Equivalente ($R_{eq}$):** Si determina sommando i reciproci delle resistenze:
  $$\frac{1}{R_{eq}} = \frac{1}{R_1} + \frac{1}{R_2} + \dots + \frac{1}{R_n}$$
* **Formula Rapida per 2 Resistori in Parallelo:**
  $$R_{12} = \frac{R_1 \cdot R_2}{R_1 + R_2}$$
* **Proprietà:** La corrente totale si suddivide nei vari rami in modo inversamente proporzionale alle resistenze (Partitore di Corrente).

---

### 3.3 Riconoscimento e Semplificazione di Reti Complesse
Non tutte le reti con un solo generatore sono semplificabili solo con serie e parallelo tradizionali (in alcuni casi servono trasformazioni Stella-Triangolo o i teoremi di Thevenin/Norton). Tuttavia, quando si analizza una rete:
1. **Identificare le serie evidenti:** Cerca rami senza derivazioni di nodo intermedi (es. $R_6$ ed $R_7$ in serie $\implies R_{67} = R_6 + R_7$).
2. **Sostituire le parti equivalenti:** Ridipingi il circuito ponendo il valore $R_{67}$ al posto dei due resistori.
3. **Identificare i paralleli:** Verifica se un gruppo/resistore condivide entrambi i nodi estremi con un altro (es. $R_4$ in parallelo a $R_{67} \implies R_{467} = \frac{R_4 \cdot (R_6 + R_7)}{R_4 + R_6 + R_7}$).
4. **Procedere dall'esterno verso la sorgente:** Ridurre la rete gradualmente fino a trovare la resistenza equivalente totale vista dal generatore.

---

## 4. Generatori Reali di Tensione, Adattamento del Carico e Rendimento

### 4.1 Modello del Generatore Reale di Tensione
Un generatore reale di tensione si modella come un **generatore ideale di tensione $E$** (tensione a vuoto) in **serie** con una **resistenza interna $R_i$**.

```
       +-------------------[ R_i ]----+--- (Polo +)
       |                              |
    ( E )                             |  Carico R_L
       |                              |
       +------------------------------+--- (Polo -)
```

* **Tensione a Vuoto ($E$):** La tensione presente ai morsetti quando non vi è alcun carico applicato ($I = 0$). Non si può misurare direttamente all'interno della struttura fisica del generatore, ma si misura a vuoto con un voltmetro ai suoi capi esterni.
* **Tensione sul Carico ($V_L$):** Quando si collega una resistenza di carico $R_L$, passa corrente e parte della tensione cade su $R_i$:
  $$I = \frac{E}{R_i + R_L}$$
  $$V_L = R_L \cdot I = E \cdot \frac{R_L}{R_i + R_L}$$

---

### 4.2 Massima Potenza Trasferita (Teorema dell'Adattamento del Carico)
Per trasferire la **massima potenza possibile** dal generatore al carico $R_L$, la resistenza del carico deve essere resa uguale alla resistenza interna del generatore:
$$R_L = R_i \quad \text{(Condizione di Adattamento)}$$

* **In condizioni di adattamento ($R_L = R_i$):**
  1. La resistenza totale vista dal generatore ideale interno è:
     $$R_{tot} = R_i + R_L = 2 R_i$$
  2. La tensione sul carico diventa esattamente la metà della tensione a vuoto:
     $$V_L = \frac{E}{2}$$
  3. La potenza massima erogata sul carico è:
     $$P_{L,\text{max}} = \frac{E^2}{4 R_i}$$

---

### 4.3 Rendimento del Generatore ($\eta$)
Il rendimento $\eta$ misura l'efficienza della trasmissione di potenza ed è definito come il rapporto tra la potenza utile assorbita dal carico e la potenza totale erogata dal generatore ideale:
$$\eta = \frac{P_L}{P_{tot}} = \frac{I^2 \cdot R_L}{I^2 \cdot (R_i + R_L)} = \frac{R_L}{R_i + R_L}$$

#### Regole fondamentali sul Rendimento:
* **Con Carico Adattato ($R_L = R_i$):**
  $$\eta = \frac{R_i}{R_i + R_i} = 0,5 = 50\%$$
* **Limiti del rendimento:** Il rendimento in condizioni di massimo trasferimento di potenza è **sempre del 50%**.
* Per ottenere un **rendimento più alto (fino al 100%)**, occorre fare in modo che $R_L \gg R_i$ (carico molto maggiore della resistenza interna).
* **Telecomunicazioni vs Elettrotecnica di Potenza:**
  * In **Telecomunicazioni/Elettronica di segnale** si cerca l'**adattamento del carico** ($R_L = R_i$) per trasferire la massima potenza del segnale, accettando un rendimento del 50%.
  * In **Elettrotecnica di potenza** si cerca di **massimizzare il rendimento** ($\eta \to 100\%$), riducendo al minimo la resistenza interna del generatore $R_i$.

---

## 5. Metodologia di Risoluzione Passo-Passo dei Circuiti in D.C.

### Guida Pratica al Calcolo Completo di una Rete
Quando si deve analizzare un circuito completo (trovare correnti, tensioni e potenze nei singoli rami):

1. **Calcolo delle resistenze equivalenti parziali e totali:**
   * Semplificare le parti in serie e in parallelo fino a ottenere la resistenza totale $R_{tot}$ vista dal generatore $E$.
2. **Calcolo della Corrente Totale Erogata ($I_{tot}$):**
   $$I_{tot} = \frac{E}{R_{tot}}$$
3. **Applicazione dei Partitori:**
   * **Partitore di tensione:** Trovare la tensione su un ramo serie:
     $$V_{R1} = E \cdot \frac{R_1}{R_1 + R_2}$$
   * **Partitore di corrente:** Trovare la corrente in uno di due rami in parallelo ($R_a$ e $R_b$):
     $$I_a = I_{tot} \cdot \frac{R_b}{R_a + R_b}$$
4. **Calcolo dei Potenziali ai Nodi e Differenze di Potenziale ($V_{AB}$):**
   * Fissare un nodo come riferimento ($0\text{ V}$).
   * Calcolare il potenziale degli altri nodi risalendo i rami tramite la caduta di tensione ($V = R \cdot I$).
   * Ricavare $V_{AB} = V_A - V_B$.
5. **Calcolo e Verifica delle Potenze Dissipate ($P = R \cdot I^2$):**
   * Calcolare la potenza dissipata da ciascun resistore.
   * Sommare tutte le potenze per verificare che il totale corrisponda alla potenza generata $P_g = E \cdot I_{tot}$.
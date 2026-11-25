def genera_descrizione():
    print("Benvenuto nel generatore di descrizioni per Vinted!\n")
    
    # Richiesta input
    marca = input("Marca: ")
    tipo_capo = input("Tipo di capo (es. maglione, jeans, giacca): ")
    colore = input("Colore: ")
    taglia = input("Taglia: ")
    materiale = input("Materiale (es. cotone, lana, poliestere): ")
    condizioni = input("Condizioni (Nuovo, Come nuovo, Usato poco, Segni di usura): ")
    vestibilita = input("Vestibilità (Oversize, Aderente, Regolare, ecc.): ")
    motivo_vendita = input("Motivo della vendita: ")
    dettagli = input("Dettagli sul capo (es. presenza di tasche, cerniere, bottoni speciali, fodera interna, ecc.): ")
    consigli_uso = input("Consigli su come abbinarlo o per quali occasioni è adatto: ")
    extra = input("Dettagli extra (es. Perfetto per l'inverno, Spedizione veloce, ecc.): ")
    
    # Generazione descrizione
    descrizione = f"""
    **{marca} {tipo_capo.capitalize()} - Taglia {taglia} - {condizioni}**
    
    Questo {tipo_capo.lower()} del marchio {marca} è un capo di alta qualità, perfetto per chi cerca uno stile elegante e versatile. Il colore {colore} lo rende facilmente abbinabile a diversi outfit, mentre la vestibilità {vestibilita.lower()} garantisce il massimo del comfort e della praticità. 
    
    ✅ **Materiale:** Realizzato in {materiale}, questo capo offre una sensazione piacevole sulla pelle ed è ideale per diverse stagioni. 
    ✅ **Condizioni:** {condizioni}. Nessun difetto evidente, è stato utilizzato con cura ed è pronto per una nuova vita nel tuo guardaroba.
    ✅ **Dettagli extra:** {dettagli}.
    
    🔹 **Perché acquistarlo?**
    {motivo_vendita}. Si tratta di un capo che merita di essere indossato e apprezzato, perfetto per chi ama la moda sostenibile e vuole dare nuova vita a pezzi di qualità. 
    
    🔹 **Come abbinarlo?**
    {consigli_uso}. Può essere indossato sia in occasioni casual che più eleganti, a seconda di come viene abbinato agli accessori e agli altri capi. 
    
    ✨ {extra} ✨
    
    📦 **Spedizione veloce e imballaggio accurato per garantire che il capo arrivi in perfette condizioni.**
    
    #ModaSostenibile #{marca} #{tipo_capo.capitalize()} #{taglia} #{colore} #SecondHand #FashionLover
    """
    
    print("\nEcco la tua descrizione pronta da copiare su Vinted:\n")
    print(descrizione)
    
# Esegui la funzione
genera_descrizione()
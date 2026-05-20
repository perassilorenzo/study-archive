let parcheggi = [true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true];

function parcheggia(){
    let i = Math.floor(Math.random() * 20);
    let persona = document.querySelector('input[name="tipo"]:checked');


    if (parcheggi[i])
    {
        let parcheggio = document.getElementById(i);

        if (parcheggio >= '5' && parcheggio <= '20')
        {

        }
        else if (parcheggio == '3' || parcheggio == '4')
        {
            if (persona == 'disabili' || persona == 'mamme')
            {

            }
        }
        else if(persona == 'disabili')
        {

        }
        else
        {

        }
    }
}
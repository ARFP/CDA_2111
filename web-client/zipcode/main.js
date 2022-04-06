const url = "https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json";
const btn = document.getElementById('button');
const thead = document.querySelector('#col');
const display = document.querySelector('#result');

// variable pour stocker les données du json
let dataVilles;

let tr = document.createElement('tr');
thead.appendChild(tr);
let thPostalCode = document.createElement('th');
thPostalCode.textContent = 'Code Postal';
let thCodeCommune = document.createElement('th');
thCodeCommune.textContent = 'Code Commune';
let thnomCommune = document.createElement('th');
thnomCommune.textContent = 'Nom Commune';
let thLibelleAcheminement = document.createElement('th');
thLibelleAcheminement.textContent = 'libelleAcheminement';
tr.appendChild(thPostalCode);
tr.appendChild(thCodeCommune);
tr.appendChild(thnomCommune);
tr.appendChild(thLibelleAcheminement);

// Récupération des données dans le fichier .json. On ajoute dans notre datalist toutes les lignes du fichier.
fetch(url)
.then(res =>res.json() )
.then(listeVilles => {
    dataVilles = listeVilles;
    const dataList = document.querySelector('#searchList');

    
    for(let ville of dataVilles){
        let option = document.createElement('option');
        option.setAttribute('value', ville.codePostal);
        option.textContent = ville.nomCommune;
        dataList.appendChild(option);
    }
})
.catch(function(error) {
    console.log(error);
});

btn.addEventListener('click', function(event) {
    event.preventDefault();
    const value = document.querySelector('#search').value;
    
    document.getElementById('result').innerHTML = '';
        
    /**On cherche dans les données des villes les lignes qui contiennent le code postal recherché.
     * Les lignes correspondantes sont ajoutées dans le DOM via un tableau. */ 
    for(let ville of dataVilles){
        if(value === ville.codePostal){
            let tr = document.createElement('tr')
            display.appendChild(tr);
            let tdPostalCode = document.createElement('td');
            tdPostalCode.textContent = ville.codePostal;
            let tdCodeCommune = document.createElement('td');
            tdCodeCommune.textContent = ville.codeCommune;
            let tdnomCommune = document.createElement('td');
            tdnomCommune.textContent = ville.nomCommune;
            let tdLibelleAcheminement = document.createElement('td');
            tdLibelleAcheminement.textContent = ville.libelleAcheminement;
            tr.appendChild(tdPostalCode);
            tr.appendChild(tdCodeCommune);
            tr.appendChild(tdnomCommune);
            tr.appendChild(tdLibelleAcheminement);
        }
    }
   
});

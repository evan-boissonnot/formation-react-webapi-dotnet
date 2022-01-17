// import { Drone } from './drone-indus';

function recupererJson(contenuJson) {
    console.info('2. On a transformé le contenu en json', contenuJson);
}

function retourApi(reponseHttp) {
    console.info('1. Retour api, on a juste la reponse');
    return reponseHttp.json();
}

console.info('1. Appel');
const appel = fetch('https://swapi.dev/api/people');
const retour = appel.then(retourApi)
                    .then(recupererJson);

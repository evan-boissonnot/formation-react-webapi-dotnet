/**
 * 2. Fonction et this : étrange vous avez dit ?
 */

function SuperDrone() {
    console.log('superdrone', this);
    this.matricule = '1245665X';
}
SuperDrone();

const monDrone = new SuperDrone();
monDrone.matricule = '1';

console.log('monDrone.matricule', monDrone.matricule);
console.log('this.matricule', this.matricule, window.matricule);

function Camion() {
    this.length = 300;
    console.log('Camion', this);
}

const monCamion = new Camion();

// Ici on exécute la fonction SuperDrone, avec le contexte de la variable monCamion.
SuperDrone.call(monCamion);



/** 1. Introduction à l'objet en js */
if (false) {
    const drone = new Drone('12345dfdfdxxx');
    drone.myMatricule = '4545';

    const drone2 = new Drone('12345dfdfdxxx');
    drone.myMatricule = '458520';
}

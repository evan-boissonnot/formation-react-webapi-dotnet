import DroneTableau from "../DroneTableau/DroneTableau";

const SuiviDrones = props => {
//const SuiviDrones = function(props)  {
    console.log('SuiviDrones', this);

    const drone = {
        id: 1,
        matricule: 'XD4520',
        status: {
            id: 2,
            libelle: 'Abimé'
        }
    };

    return (
        <div>
            <h1>{ props.title }</h1>
            <DroneTableau item={drone}></DroneTableau>
        </div>
    );
};

export default SuiviDrones;
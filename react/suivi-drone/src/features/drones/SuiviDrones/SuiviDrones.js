import DroneTableau from "../DroneTableau/DroneTableau";
import { DroneService } from "../services/drone-service";

const SuiviDrones = props => {
//const SuiviDrones = function(props)  {
    //console.log('SuiviDrones', this);

    const loadDrones = async () => {
        const service = new DroneService();
        const drones = await service.getAll();
    
        console.info(drones);
    }

    

    // const drone = {
    //     id: 1,
    //     matricule: 'XD4520',
    //     status: {
    //         id: 2,
    //         libelle: 'Abimé'
    //     }
    // };

    return (
        <div>
            <h1>{ props.title }</h1>
            <DroneTableau items={drones}></DroneTableau>
        </div>
    );
};

export default SuiviDrones;
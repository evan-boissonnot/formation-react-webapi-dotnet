import DroneTableau from "../DroneTableau/DroneTableau";
import { DroneService } from "../services/drone-service";
import {useState} from "react";

const SuiviDrones = props => {
    //const SuiviDrones = function(props)  {
    //console.log('SuiviDrones', this);
    // let drones = [];
    const [drones, setDrones] = useState([]);

    const loadDrones = async () => {
        const service = new DroneService();
        const result = await service.getAll();

        setDrones(result);
        //console.info(drones);
    };

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
            <h1 className="titre">{props.title}</h1>
            <button onClick={loadDrones}>Recharger les drones</button>
            <DroneTableau items={drones}></DroneTableau>
        </div>
    );
};

export default SuiviDrones;


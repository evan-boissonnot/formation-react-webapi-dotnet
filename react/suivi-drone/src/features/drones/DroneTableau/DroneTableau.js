const DroneTableau = props => {
    // console.log('drones', props.items);
    const lignes = props.items.map(item => <tr><td>{item.id}</td><td>{item.matricule}</td></tr>);

    return (
    <table>
        <tbody>
            {/* <tr>
                <td> { props.item.id }</td>
                <td> { props.item.matricule }</td>
                <td> { props.item.status.libelle }</td>
            </tr> */}
            { lignes }
        </tbody>
    </table>
    );
};

export default DroneTableau;
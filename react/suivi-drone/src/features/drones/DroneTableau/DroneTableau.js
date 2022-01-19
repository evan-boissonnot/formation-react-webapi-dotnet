const DroneTableau = props => {
    return (
    <table>
        <tbody>
            <tr>
                <td> { props.item.id }</td>
                <td> { props.item.matricule }</td>
                <td> { props.item.status.libelle }</td>
            </tr>
        </tbody>
    </table>
    );
};

export default DroneTableau;
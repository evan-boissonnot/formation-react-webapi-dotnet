const e = React.createElement;

class DroneDiv extends React.Component {
    render() {
        return e('div', {}, e('div'));
    }
}

// Html 4
const root_avant = document.getElementById('root');

// Html 5
const root = document.querySelector('#root');

const composantReact = React.createElement(DroneDiv);

ReactDOM.render(composantReact, root);

import './App.css';
import SuiviDrones from '../../features/SuiviDrones/SuiviDrones';

function App() {
  const monApp = <div className="App">
                    <h1>Suivi des drones !</h1>
                    <SuiviDrones />
                  </div>;

  return (
    monApp
  );
}

export default App;

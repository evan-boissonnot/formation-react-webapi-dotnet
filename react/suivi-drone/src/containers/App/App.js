import './App.css';
import SuiviDrones from '../../features/drones/SuiviDrones/SuiviDrones';

/**
 * Container parent
 * @returns 
 */
function App() {
  const monApp = <div className="App">
                    <h1>Suivi des drones !</h1>
                    <SuiviDrones title="Suivi des drones" />
                  </div>;

  return (
    monApp
  );
}

export default App;

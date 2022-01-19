export class DroneService {
    async getAll() {
        const apiUrl = 'https://localhost:7064/api/Drones'; // ATTENTION, ON NE LAISSE JAMAIS CA EN DUR !!!

        const response = await fetch(apiUrl);
        const droides = await response.json();

        console.log(droides);

        return droides;
    }
}


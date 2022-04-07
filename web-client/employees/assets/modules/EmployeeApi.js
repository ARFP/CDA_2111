import { Employee } from "./Employee.js";

export class EmployeeApi {
    
    constructor(apiUrl)
    {
        this.apiUrl = apiUrl;
        this.jsonEmployees = "";
        this.fetchPromise = "";
        this.listEmployees = [];
    }

    /**
     * Methode qui va réaliser le fetch sur l'API.
     */
    fetchData()
    {
        this.fetchPromise = this.makeFetch();
    }

    /**
     * Méthode utilisé par fetchData() pour réaliser
     * le fetch,
     * Elle permet de définir le "async" et donc
     * de gérer l'asynchrone.
     * 
     * @returns une promesse qui permettra dans
     * le code utilisant l'API d'être sûr que
     * les données ont bien été récupéré.
     */
    async makeFetch()
    {
        let request = await fetch(this.apiUrl);
        let json = await request.json();
        this.jsonEmployees = json.data;
        this.jsonEmployees.forEach(employeeJson => {
            let employee = new Employee(employeeJson.id, employeeJson.employee_name, employeeJson.employee_age, employeeJson.employee_salary);
            this.listEmployees.push(employee);
        });

        return json;
    }

    /**
     * Methode utilisé pour vérifier que
     * la promesse du fetch a été correctement
     * réalisé et que les données sont
     * disponibles.
     */
    fetchDone()
    {
        return this.fetchPromise;
    }

};

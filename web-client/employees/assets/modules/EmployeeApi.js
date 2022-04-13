import { Employee } from "./Employee.js";

export class EmployeeApi {
    
    constructor(apiUrl)
    {
        this.apiUrl = apiUrl;
        this.jsonEmployees = "";
        this.fetchPromise = "";
    }

    /**
     * Methode qui va réaliser le fetch sur l'API.
     */
    fetchData()
    {
        this.fetchPromise = this.makeFetch(); // ???
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
        json.data.forEach(employeeJson => {
            let employee = new Employee(employeeJson);
            this.jsonEmployees.push(employee);
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
        return this.fetchPromise; // on réinvente le rôle de la promesse ? :D
    }

    /**
     * Récupérer la liste des employée.
     */
    getAll()
    {
        return this.jsonEmployees;
    }

    /**
     * Récupérer un seul employé, par son ID.
     */
    get(_idEmployee)
    {
        /*this.listEmployees.forEach((employee) => {
            if (employee.id == _idEmployee) {
                return employee;
            }
        })*/
        let jsonEmployee = this.jsonEmployees.find((employee) => employee.id == _idEmployee);

        if (jsonEmployee === undefined) {
            throw new Error(`There is no employee with ID ${_idEmployee}`);
        }

        return employee;
    }

    /**
     * Ajout d'un employé, en vérifiant qu'il a un ID différent des autres employés
     * @param {*} _employee 
     */
    post(_employee)
    {
        if (!_employee instanceof Employee) {
            throw new Error("You have to send an Employee object.");
        }

        if (this.jsonEmployees.find((employee) => employee.id == _employee.id)) {
            throw new Error(`Your employee has an existing ID ${_employee.id}`);
        }

        this.jsonEmployees.push(new Employee(employeeJson));
    }

    /**
     * On duplique un employé en lui assigant un nouvel ID.
     */
    duplicate(_idEmployee)
    {
        let newEmployee = {}; // cible du clonage
        let currentEmployee = this.get(_idEmployee);
        Object.assign(newEmployee, currentEmployee); // clonage de currentEmployee vers newEmployee
        
        let newId = Math.max.apply(Math, this.jsonEmployees.map(o => o.id)); // recherche de l'id max
        
        newEmployee.id = ++newId; // assignation du nouvel identifiant (pre incrémentation = incrémentation avant assignation)
        
        this.post(target);        
    }

    /**
     * On supprime un employé.
     * @param {*} _idEmployee 
     */
    delete(_idEmployee)
    {
        this.jsonEmployees = this.jsonEmployees.filter(employee => employee.id != _idEmployee);
    }
};

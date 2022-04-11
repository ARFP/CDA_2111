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

    /**
     * Récupérer la liste des employée.
     */
    getAll()
    {
        let listEmployee = [];

        this.jsonEmployees.forEach(employeeJson => {
            let employee = new Employee(employeeJson);
            listEmployee.push(employee);
        });
        return listEmployee;
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

        let employee = new Employee(jsonEmployee);

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

        let employeeJson = {};
        
        ({
            id: employeeJson.id,
            fullName: employeeJson.employee_name,
            age: employeeJson.employee_age,
            salary: employeeJson.employee_salary,
            image: employeeJson.profile_image
        } = _employee);

        this.jsonEmployees.push(employeeJson);
    }

    /**
     * On duplique un employé en lui assigant un nouvel ID.
     */
    duplicate(_idEmployee)
    {
        
        let newId = this.jsonEmployees[this.jsonEmployees.length - 1].id + 1;
        let newEmployee = this.get(_idEmployee);
        newEmployee.id = newId;
        this.post(newEmployee);
        
    }

    /**
     * On supprime un employé.
     * @param {*} _idEmployee 
     */
    delete(_idEmployee)
    {
        let indexEmployee = this.jsonEmployees.findIndex((employee) => employee.id == _idEmployee);
       
        if (indexEmployee === -1) {
            throw new Error(`The employee with ID ${_idEmployee} is not found for deletion.`);
        }
        this.jsonEmployees.splice(indexEmployee, 1);
        // delete this.jsonEmployees[indexEmployee]; //delete laisse un élément vide dans le tableau et ne le supprime pas


    }
};

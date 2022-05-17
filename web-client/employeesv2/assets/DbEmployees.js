import { Employee } from './Employee.js'

class DbEmployees 
{
    static async #getEmployeesJson() {
        try {
            let response = await fetch('https://arfp.github.io/tp/web/frontend/employees/employees.json')
            let json = await response.json()
            json = json.data;
            return json

        } catch(error) {
            console.error(error)
        }
    }    

    static async getEmployees() {
        let json = await DbEmployees.#getEmployeesJson()

        //json.forEach(element => {})
        /*let result = []
        for(let element of json) {
            result.push(new Employee(element))
        }
        return result*/

        return json.map(element => new Employee(element))
    }
    /*
    {
            "id": 1,
            "employee_name": "Tiger Nixon",
            "employee_salary": 320800,
            "employee_age": 61,
            "profile_image": ""
        }
    */
}


// export de la classe Employee 
export { DbEmployees }
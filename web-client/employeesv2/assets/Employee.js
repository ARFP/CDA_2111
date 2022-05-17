/*
    {
        "id": 1,
        "employee_name": "Tiger Nixon",
        "employee_salary": 320800,
        "employee_age": 61,
        "profile_image": ""
    }
    */

class Employee 
{
    constructor(_emp) {
        Object.assign(this, _emp)
        this.generateEmail();
        this.monthlySalary = Math.round(this.employee_salary/12 * 100) / 100

        let now = new Date().getFullYear()
        
        this.birthYear = now - this.employee_age
    }

    generateEmail() {
        let firstletter = this.employee_name.charAt(0)
        let lastname = this.employee_name.split(' ')[1] ?? 'John'

        /*if(this.employee_name.split(' ')[1] === undefined || this.employee_name.split(' ')[1] === null) {
            lastname = 'John'
        }*/

        this.email = (`${firstletter}.${lastname}@email.com`).toLowerCase()
    }

    



}

export { Employee }
export class Employee {
    // constructor(id, name, age, salary, profileImage = "")
    // {
    //     this.id = id;
    //     this.name = name;
    //     this.age = age;
    //     this.salary = salary;
    //     this.profileImage = profileImage;
    //     this.email = this.setEmail();
    // }

    constructor(_employe){
        ({id: this.id, employee_name: this.fullName, employee_salary: this.salary, profile_image: this.image} = _employe);
        this.email = this.setEmail();
        this.monthlySalary = this.setMonthlySalary();
        this.yearOfBirth = new Date().getFullYear() - _employe.employee_age;

    }

    setEmail()
    {
        let firstLetterFirstName = this.fullName[0].toLowerCase();
        let lastName = this.fullName.split(" ")[1].toLowerCase();
        return `${firstLetterFirstName}.${lastName}@email.com`;
    }

    setMonthlySalary(){
        let monthlySalary = (this.salary /12).toFixed(2);
        return monthlySalary;
    }
}
export class Employee {
    constructor(id, name, age, salary, profileImage = "")
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.salary = salary;
        this.profileImage = profileImage;
        this.email = this.setEmail();
    }

    setEmail()
    {
        let firstLetterFirstName = this.name[0].toLowerCase();
        let lastName = this.name.split(" ")[1].toLowerCase();
        return `${firstLetterFirstName}.${lastName}@email.com`;
    }
}
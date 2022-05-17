// import { EmployeeApi } from "./EmployeeApi.js";

export class EmployeesTable {

    constructor(_employeeApi, _tbodyElement) {
        this.employeeApi = _employeeApi;
        this.tbodyElement = _tbodyElement;
        this.sortOrderAsc = false;

    }

    createFilledLine(employee) {
        let tr = document.createElement('tr');
        // console.log(this.tbodyElement);
        this.tbodyElement.appendChild(tr);

        let tdId = document.createElement('td');
        let tdName = document.createElement('td');
        let tdSalary = document.createElement('td');
        let tdEmail = document.createElement('td');
        let tdBirth = document.createElement('td');
        let tdActions = document.createElement('td');

        tdActions.dataset.employeeId = employee.id;

        let duplicateButton = document.createElement('button');
        duplicateButton.setAttribute('class','duplicate'); //deleteButton.className = 'deuplicate';
        
        let deleteButton = document.createElement('button');
        deleteButton.setAttribute('class','delete'); //deleteButton.className = 'delete';
        
        tr.appendChild(tdId);
        tr.appendChild(tdName);
        tr.appendChild(tdEmail);
        tr.appendChild(tdSalary);
        tr.appendChild(tdBirth);
        tr.appendChild(tdActions);

        tdActions.appendChild(duplicateButton);
        tdActions.appendChild(deleteButton);
        
        tdId.textContent = employee.id;
        tdName.textContent = employee.fullName;
        tdSalary.textContent = employee.monthlySalary;
        tdEmail.textContent = employee.email;
        tdBirth.textContent = employee.yearOfBirth;
        deleteButton.innerHTML = `&#128465; DELETE`;
        duplicateButton.innerHTML = '&#128462;  DUPLICATE  &#128462;';
    }

    generateTableBody(){
        this.tbodyElement.innerHTML = '';
        this.sortOrderAsc = false;
        let totalSalary = 0;
        let employeesCounter = 0;
        for(let employee of this.employeeApi.getAll()) {
            this.createFilledLine(employee);

            totalSalary += employee.salary;
            employeesCounter++;
        }

        this.generateTableFoot(totalSalary,employeesCounter);
        

    }

    generateTableFoot(_totalSalary,_totalEmployees) {
        let table = document.querySelector('table');
        let tFoot = document.getElementsByTagName('tfoot')[0];
        if (tFoot != null){
            tFoot.innerHTML = '';
        }
        else {
            tFoot = document.createElement('tfoot');
        }
        
        table.appendChild(tFoot);

        let tr = document.createElement('tr');
        let tdTotalEmployees = document.createElement('td');
        let td2 = document.createElement('td');
        let tdMonthlySalaryTotal = document.createElement('td');
        let td3 = document.createElement('td');
        let td5 = document.createElement('td');
        let td6 = document.createElement('td');

        tFoot.appendChild(tr);
        tr.appendChild(tdTotalEmployees);
        tr.appendChild(td2);
        tr.appendChild(td3);
        tr.appendChild(tdMonthlySalaryTotal);
        tr.appendChild(td5);
        tr.appendChild(td6);

        tdTotalEmployees.textContent = _totalEmployees;
        tdMonthlySalaryTotal.textContent = (Math.round((_totalSalary*100)/12))/100;

    }

    generateTableSortSalary(){
        this.tbodyElement.innerHTML = '';
        if(this.sortOrderAsc){
            let salarySort = this.employeeApi.getAll().sort(function(a, b){
                return a.monthlySalary - b.monthlySalary;
            });
            for(let employee of salarySort) {
                this.createFilledLine(employee);
            } 

        } else {
            let salarySort = this.employeeApi.getAll().sort(function(a, b){
                return b.monthlySalary - a.monthlySalary;
            });
            for(let employee of salarySort) {
                this.createFilledLine(employee);
            }
        }
    }

    setEventSort() 
    {
        document.querySelector('.myButtonSort').addEventListener('click', () => {
            this.sortOrderAsc = !this.sortOrderAsc
            this.generateTableSortSalary(this.sortOrderAsc);
             })
    };

    setEvent()
    {
        this.tbodyElement.addEventListener('click', (event) => {
            if (event.target.classList.contains("duplicate")) {
                let idEmployee = event.target.parentNode.dataset.employeeId;
                let duplicatedEmployee = this.employeeApi.duplicate(idEmployee);
                // Si la duplication a fonctionné, je réaffiche le tableau
                if(duplicatedEmployee) {
                    this.generateTableBody();
                }
            } else if (event.target.classList.contains("delete")) {
                let idEmployee = event.target.parentNode.dataset.employeeId;
                let deletedEmployee = this.employeeApi.delete(idEmployee);
                // S'il y a bien eu suppression, je régénère le tableau affiché
                if(deletedEmployee){
                    this.generateTableBody();
                }
            }
        });
    }
}

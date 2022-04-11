// import { EmployeeApi } from "./EmployeeApi.js";

export class EmployeesTable {

    constructor(_employeeApi) {
        this.employeeApi = _employeeApi;
    }

    createFilledLine(_target, employee) {
        
        let tr = document.createElement('tr');
        // console.log(_target);
        _target.appendChild(tr);

        let tdId = document.createElement('td');
        let tdName = document.createElement('td');
        let tdSalary = document.createElement('td');
        let tdEmail = document.createElement('td');
        let tdBirth = document.createElement('td');
        let tdActions = document.createElement('td');

        tdActions.dataset.employeeId = employee.id;

        let duplicateButton = document.createElement('button');
        duplicateButton.setAttribute('class','duplicate');
        
        let deleteButton = document.createElement('button');
        deleteButton.setAttribute('class','delete');

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
        deleteButton.textContent = 'DELETE';
        duplicateButton.textContent = 'DUPLICATE';
    }

    setEvent(_tbodySelector)
    {
        const tbodyElement = document.querySelector(_tbodySelector);

        tbodyElement.addEventListener('click', (event) => {
            if (event.target.classList.contains("duplicate")) {
                let idEmployee = event.target.parentNode.dataset.employeeId;
                this.employeeApi.duplicate(idEmployee);
            } else if (event.target.classList.contains("delete")) {
                let idEmployee = event.target.parentNode.dataset.employeeId;
                this.employeeApi.delete(idEmployee);
            }
        });
    }
}

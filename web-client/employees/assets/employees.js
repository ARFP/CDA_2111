

const myEmployeeJson = "https://arfp.github.io/tp/web/frontend/employees/employees.json"

const myTableData = document.getElementById('columnEntitledTable');
const rowCategoryHeader = document.createElement('tr');
myTableData.appendChild(rowCategoryHeader);

const arrayHeader = ['EID', 'Full Name', 'Email', 'Monthly salary', 'Year of birth', 'Actions']

function createHeader(elem, arrayName) {
    arrayName.forEach(value => {
        let columnHeader = document.createElement('th');
        columnHeader.textContent = value;
        if(columnHeader.textContent == 'Monthly salary'){
            let sortButton = document.createElement('button');
            sortButton.textContent = 'toto';
            columnHeader.appendChild(sortButton);
            sortButton.setAttribute('class', 'myButtonSort');
        }
        elem.appendChild(columnHeader);
    });
 
}









createHeader(rowCategoryHeader, arrayHeader);

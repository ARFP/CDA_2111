const myEmployeeJson = "https://arfp.github.io/tp/web/frontend/employees/employees.json"
const myTableData = document.getElementById('columnEntitledTable');
const rowCategoryHeader = document.createElement('tr');

const arrayHeader = ['EID', 'Full Name', 'Email', 'Monthly salary', 'Year of birth', 'Actions']

function createHeader(elem, arrayName) {
    arrayName.forEach(value => {
        var columnHeader = document.createElement('th');
        columnHeader.textContent = value;
        elem.appendChild(columnHeader);
    });
}

myTableData.appendChild(rowCategoryHeader);
createHeader(rowCategoryHeader, arrayHeader);

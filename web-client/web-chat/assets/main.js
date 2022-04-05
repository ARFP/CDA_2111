function generateTable(json) 
{
    //for(let user of json) { }
    //json.forEach(user => { });

    for(let i = 0; i < json.length; i++) {
        let user = json[i];

        let tr = document.createElement('tr');
        let td = document.createElement('td');
        td.textContent = user.user_name;
        tr.appendChild(td);      

        document.querySelector('#quaranteDeux').appendChild(tr);

    }

}


fetch('https://api.devoldere.net/dataset/users.json')
.then((response) => {
    console.log(response);
    return response.json();
})
.then(json => {
    console.log(json);
    generateTable(json);
})
.catch(error => {
    console.log(error);
});
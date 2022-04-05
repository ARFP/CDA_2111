// resolvedPromise = function() {}

let resolvedPromise = () => {
    console.log('Vous êtes majeur !');
}

let rejectedPromise = () => {
    console.error('Vous êtes mineur !');
}


let isMajor = (age) =>
{
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            if(age >= 18) {
                resolve();
            } else {
                reject();
            }
        }, 5000);
    });
}

//let isMajor2 = async function(age)
async function isMajor2(age)
{
    return await new Promise((resolve, reject) => {
        setTimeout(() => {
            if(age >= 18) {
                resolve();
            } else {
                reject();
            }
        }, 5000);
    });
}


isMajor2(17)
.then((resolve) => {
    resolvedPromise();
})
.catch((reject) => {
    rejectedPromise();
});

console.log('Bonjour');
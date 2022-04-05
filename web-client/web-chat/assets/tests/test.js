class User 
{
    constructor() {
        this.name = "toto";
    }

    getName() {
        return this.name;
    }

}

const User2 = function() 
{
    this.name = "toto";
}

User2.prototype.getName = function() {
    return this.name;
}

const User3 = {
    name: "toto"
}

let u1 = new User();
let u2 = new User2();

console.log(u1, u2);

console.log(u1.getName());
console.log(u2.getName());

User2.prototype.getName = null;

let a = [];
a.push("toto");
console.log(a);

Array.prototype.push = function(item) {
    console.log("NON");
}

a.push("titi");
console.log(a);

User2.name;
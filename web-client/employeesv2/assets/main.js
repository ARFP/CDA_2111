// import de DbEmployees
import { DbEmployees } from "./DbEmployees.js"

const o = {}

const myBeautifullApp = {

    data() {
        return  {
            title: 'Liste des employées',
            employees: []
        }
    },

    async mounted() {
        this.employees = await DbEmployees.getEmployees()
        console.log(this.employees)

    },

    methods: {
        
    }


}

Vue.createApp(myBeautifullApp).mount('#app')

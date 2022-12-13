<template>

    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <div class="alert alert-danger mt-4" v-if="errors.length">
                    <ul class="mb-0">
                        <li v-for="(errors, index) in errors" :key="index">
                            {{errors}}
                        </li>
                    </ul>
                </div>
                <form @submit.prevent="saveContact" novalidate>
                    <fieldset>
                        <div class="form-group">
                            <label class="form-label mt-4">ID</label>
                            <input type="number" class="form-control" v-model="Clientes.id" placeholder="Enter Name">
                        </div>
                        <div class="form-group">
                            <label class="form-label mt-4">Name</label>
                            <input type="text" class="form-control" v-model="Clientes.nombre" placeholder="Enter Name">
                        </div>
                        <div class="form-group">
                            <label class="form-label mt-4">mail</label>
                            <input type="text" class="form-control" v-model="Clientes.email" placeholder="Enter Email">
                        </div>
                        <button class="btn btn-primary mt-4">Submit</button>
                    </fieldset>
                </form>
            </div>
        </div>
    </div>
</template>

<script>
import axios from 'axios';
    export default {
    name: "AddContact",
    data() {
        return {
            Clientes: {
                id: 0,
                nombre: "",
                email: ""
            },
            errors: []
        };
    },
    methods: {
        async saveContact() {
            this.errors = [];
            if (!this.Clientes.id) {
                this.errors.push("ID is required");
            }
            if (!this.Clientes.nombre) {
                this.errors.push("Name is required");
            }
            if (!this.Clientes.email) {
                this.errors.push("email is required");
            }
            if (!this.errors.length) {
                let formData = new FormData();
                formData.append("id", this.Clientes.id);
                formData.append("name", this.Clientes.nombre);
                formData.append("email", this.Clientes.email);
                let url = "https://localhost:44342/api/Cliente";
                await axios.post(url, this.Clientes).then((response) => {
                    console.log(response);
                    if (response.status == 200) {
                        this.Clientes.id = 0;
                        this.Clientes.nombre = "";
                        this.Clientes.email = "";
                        alert("Datos ingresados correctamente");
                        //this.$refs.listar.ContactList.getContacts();
                        this.$router.push({ path: '/' })
                    }
                    else {
                        console.log("error");
                    }
                }).catch(error => {
                    this.errors.push(error.response);
                });
            }
        }
    }
}
</script>
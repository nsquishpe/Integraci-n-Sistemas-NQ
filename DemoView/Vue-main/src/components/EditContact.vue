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
                <form @submit.prevent="updateContact" novalidate>
                    <fieldset>
                        <div class="form-group">
                            <label class="form-label mt-4">ID</label>
                            <input type="text" class="form-control" v-model="Clientes.id" placeholder="Enter Name">
                        </div>
                        <div class="form-group">
                            <label class="form-label mt-4">Nombre</label>
                            <input type="text" class="form-control" v-model="Clientes.nombre" placeholder="Enter Email">
                        </div>
                        <div class="form-group">
                            <label class="form-label mt-4">Email</label>
                            <input type="text" class="form-control" v-model="Clientes.email"
                                placeholder="Enter Designation">
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
        name: 'EditContact',
        data() {
            return {
                Clientes:{
                    id: 0,
                nombre: '',
                email: ''
                },
                errors: []
            }
        },
        created(){
            this.getContactbyid();

        },
        methods: {
            
            async getContactbyid(){
                let url= `https://localhost:44342/api/Cliente/${this.$route.params.id}` ;

                await axios.get(url).then(response=>{
                    console.log(response);
                    this.Clientes= response.data;
                });

            },

            async updateContact() {
                this.errors = [];
                if (!this.Clientes.id) {
                    this.errors.push("ID is required")
                }
                if (!this.Clientes.nombre) {
                    this.errors.push("Name is required")
                }
                if (!this.Clientes.email) {
                    this.errors.push("email is required")
                }
                if (!this.errors.length) {
                    let Clientes =  this.getContactbyid();
                    Clientes.id = this.Clientes.id;
                    Clientes.nombre =  this.Clientes.nombre;
                    Clientes.email =  this.Clientes.email;

                    let url=`https://localhost:44342/api/Cliente/${this.$route.params.id}`;
                    
                    await axios.put(url, Clientes).then((response)=>{
                        console.log(response);
                        if(response.status == 200){
                            alert("Datos actualizados correctamente");
                        }
                        else{
                            console.log('error');
                        }
                    }).catch( error=>{
                        this.errors.push(error.response);
                    });

                }

            }
        },
        mounted: function(){
            console.log('edit loaded...');
        }
    }
</script>
<template>

<div class="container">
    <table class="table table-hover">
        <thead>
            <tr>
                <th scope="col">id</th>
                <th scope="col">nombre</th>
                <th scope="col">email</th>
            </tr>
        </thead>
        <tbody v-for="contact in contacts" :key="contact.id">
            <tr class="table-secondary">
                <th scope="row">{{contact.id}}</th>
                <th scope="row">{{contact.nombre}}</th>
                <th scope="row">{{contact.email}}</th>

                <th scope="row"><RouterLink :to="{name:'EditContact',params:{id:contact.id}}" 
                    class="btn btn-primary btn-sm" @click.prevent="(contact.id)">
                    Edit</RouterLink></th>

                <th scope="row"><button class="btn btn-danger btn-sm" @click.prevent="deleteContact(contact.id)">Delete</button></th>
                
            </tr>
        </tbody>
    </table>
</div>
</template>

<script>  
 import axios from 'axios';

export default{
       name:'ContactList',
       data(){
           return {
             contacts:Array
           }
       },
       created(){
           this.getContacts();
       },
       methods:{
           async getContacts(){
               let url ='https://localhost:44342/api/Cliente';
               await axios.get(url).then(response=>{
                   this.contacts = response.data;
                   console.log(this.contacts);
               }).catch(error =>{
                   console.log(error);
               });
           },
            async deleteContact(id){
                  
                let url='https://localhost:44342/api/Cliente/'+id;

                await axios.delete(url).then(response=>{
                    if(response.status == 200){
                        alert("Registro eliminado con exito.");
                        this.getContacts();
                    }
                }).catch(error=>{
                    console.log(error);
                });
            }
       },
       mounted(){
           console.log('Contact List component mounted');
       }
}
 </script>
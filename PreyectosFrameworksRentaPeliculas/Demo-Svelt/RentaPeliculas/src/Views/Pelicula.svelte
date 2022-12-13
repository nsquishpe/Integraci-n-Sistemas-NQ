<script>
	let Empresa = [];
	let activado = true;
	let datosEmpreas = {
		PELIID: "",
		NOMBREPELI: "",
        DIRECTORPELI: "",
        GENEROPELI: "",
	};

	let mostrarEmpresa = () => {
		fetch("https://localhost:44378/api/Pelicula/")
			.then((respuesta) => respuesta.json())
			.then((datosRespuesta) => {
				Empresa = datosRespuesta;
				datosEmpreas = {
					PELIID: "",
                    NOMBREPELI: "",
                    DIRECTORPELI: "",
                    GENEROPELI: "",
				};
				activado = true;
			})
			.catch(console.log);
	};

	let agregarEmpreas = () => {
		const nuevoEmpreas = {
            PELIID: datosEmpreas.PELIID,
		    NOMBREPELI: datosEmpreas.NOMBREPELI,
            DIRECTORPELI: datosEmpreas.DIRECTORPELI,
			GENEROPELI:datosEmpreas.GENEROPELI,
		};

		fetch("https://localhost:44378/api/Pelicula", {
			method: "POST",
			headers: { "Content-type": "application/json; charset=UTF-8" },
			body: JSON.stringify(nuevoEmpreas),
		})
			.then((respuesta) => respuesta.json())
			.then((datosRespuesta) => {
				console.log(nuevoEmpreas);
				console.log(datosRespuesta);
				mostrarEmpresa();
			})
			.catch(console.log);
	};

	let borrarEmpresa = (id) => {
		fetch("https://localhost:44378/api/Pelicula/" + id, {
			method: "DELETE",
		})
			.then((respuesta) => respuesta.json())
			.then((datosRespuesta) => {
				mostrarEmpresa();
			})
			.catch(console.log);
	};

	let editarEmpresa = (Empresa) => {
		datosEmpreas = Empresa;
		activado=false;
	};

	let actualizarEmpresa = () => {
		fetch("https://localhost:44378/api/Pelicula/" + datosEmpreas.PELIID, {
			method: "PUT",
			headers: { "Content-type": "application/json; charset=UTF-8" },
			body: JSON.stringify(datosEmpreas),
		})
			.then((respuesta) => respuesta.json())
			.then((datosRespuesta) => {
				console.log(datosEmpreas);
				console.log(datosRespuesta);
				mostrarEmpresa();
			})
			.catch(console.log);
	};

	mostrarEmpresa();
</script>

<body>
    <div class="pater">
        <div class="card border-dark" style="width: 30%; float:left;"> 
                <div class="card-header" id="card1">Películas</div>
                <div class="card-body">
                    <form>
                        <div class="mb-3">
                            <label for="" class="form-label">ID</label>
                            <input
                                type="text"
                                bind:value={datosEmpreas.PELIID}
                                class="form-control"
                            />
                            <label for="" class="form-label">Nombre</label>
                            <input
                                type="text"
                                bind:value={datosEmpreas.NOMBREPELI}
                                class="form-control"
                            />
                            <label for="" class="form-label">Género</label>
                            <input
                                type="text"
                                bind:value={datosEmpreas.GENEROPELI}
                                class="form-control"
                            />
                            <label for="" class="form-label">Director</label>
                            <input
                                type="text"
                                bind:value={datosEmpreas.DIRECTORPELI}
                                class="form-control"
                            />
                        </div>
                        <button
                            type="button"
                            class="btn btn-success"
                            on:click|preventDefault={agregarEmpreas}
                            
                        >
                            Agregar
                        </button>
    
                        <button
                            type="button"
                            class="btn btn-primary"
                            on:click|preventDefault={actualizarEmpresa}
                            
                        >
                            Actualizar
                        </button>
                    </form>
                </div>
            </div>
        <div style="width: 8%;"></div>
        <div class="card border-dark" style="width: 50%; ">
            <table class="table" style="width: 100%;">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Nombre</th>
                        <th>Género</th>
                        <th>Director</th>
                        <th></th>
                    </tr>
                </thead>
    
                <tbody >
                    {#each Empresa as Empresa}
                        <tr>
                            <td>{Empresa.PELIID}</td>
                            <td>{Empresa.NOMBREPELI}</td>
                            <td>{Empresa.GENEROPELI}</td>
                            <td>{Empresa.DIRECTORPELI}</td>
                            <td>
                                <button
                                    type="submit"
                                    class="btn btn-primary"
                                    on:click={editarEmpresa(Empresa)}
                                    >Editar
                                </button>
        
                                <button
                                    type="submit"
                                    class="btn btn-danger"
                                    on:click={borrarEmpresa(Empresa.PELIID)}
                                >
                                    Borrar</button
                                >
                            </td>
                        </tr>
                    {/each}
                </tbody>
            </table>
        </div>
    </div>
</body>



<style>
    .pater > div {
   display: inline-block;
   width: 24%;
    /*** Sólo a efectos de visualización ***/
   margin: 0;
    }
   .card{
    display: flex;
  justify-content: center;
  align-items: center;
  background-color: beige;
 }
button{
	color: white;
	height: 40px;
	cursor: pointer;
	margin-top: 5px;
	font-size: 0.8em;
	font-family: 'Sniglet', cursive;
	-webkit-transition: background-color 0.5s;
	-moz-transition: background-color 0.5s;
	-o-transition: background-color 0.5s;
	transition: background-color 0.5s;
}
body{
    font-family:Arial, Helvetica, sans-serif, cursive;
	font-size: 1.15em;
    background: #076585;  /* fallback for old browsers */
background: -webkit-linear-gradient(to right, #fff, #076585);  /* Chrome 10-25, Safari 5.1-6 */
background: linear-gradient(to right, #fff, #076585); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */


}
.card-header{
    font-size: 1.2em;
    background: #083f5f;  
color: azure;
}
.form-label{
    font-weight: bold;
}
th{
    background: #00a2ec;  
}
tr{
    border-radius: 5px;
}
</style>



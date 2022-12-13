<script>
	let Empresa = [];
	let activado = true;
	let datosEmpreas = {
		CLIID: "",
		CEDULACLI: "",
        NOMBRECLI: "",
        EMAILCLI: "",
	};

	let mostrarEmpresa = () => {
		fetch("https://localhost:44392/api/Cliente/")
			.then((respuesta) => respuesta.json())
			.then((datosRespuesta) => {
				Empresa = datosRespuesta;
				datosEmpreas = {
					CLIID: "",
                    NOMBRECLI: "",
                    CEDULACLI: "",
                    EMAILCLI: "",
				};
				activado = true;
			})
			.catch(console.log);
	};

	let agregarEmpreas = () => {
		const nuevoEmpreas = {
            CLIID: datosEmpreas.CLIID,
            NOMBRECLI: datosEmpreas.NOMBRECLI,
            CEDULACLI: datosEmpreas.CEDULACLI,
			EMAILCLI:datosEmpreas.EMAILCLI,
		};

		fetch("https://localhost:44392/api/Cliente", {
			method: "POST",
			headers: { "Content-type": "application/json; charset=UTF-8" },
			body: JSON.stringify(nuevoEmpreas),
		})
			.then((respuesta) => respuesta.json())
			.then((datosRespuesta) => {
                mostrarEmpresa();
				console.log(nuevoEmpreas);
				console.log(datosRespuesta);
			})
			.catch(console.log);
	};

	let borrarEmpresa = (id) => {
		fetch("https://localhost:44392/api/Cliente/" + id, {
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
		fetch("https://localhost:44392/api/Cliente/" + datosEmpreas.CLIID, {
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
        <div class="card border-dark" style="width: 30%; float:left"> 
                <div class="card-header">Clientes</div>
                <div class="card-body">
                    <form>
                        <div class="formgroup" >
                            <label for="" class="form-label">ID</label>
                            <input
                                type="text"
                                bind:value={datosEmpreas.CLIID}
                                class="form-control"
                            />
                            <label for="" class="form-label">Nombre</label>
                            <input
                                type="text"
                                bind:value={datosEmpreas.NOMBRECLI}
                                class="form-control"
                            />
                            <label for="" class="form-label">Cédula</label>
                            <input
                                type="text"
                                bind:value={datosEmpreas.CEDULACLI}
                                class="form-control"
                            />
                            <label for="email" class="form-label">Email</label>
                            <input
                                type="text"
                                bind:value={datosEmpreas.EMAILCLI}
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
            <table class="table" >
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Cédula</th>
                        <th>Nombre</th>
                        <th>Email</th>
                        <th></th>
                    </tr>
                </thead>
    
                <tbody>
                    {#each Empresa as Empresa}
                        <tr>
                            <td>{Empresa.CLIID}</td>
                            <td>{Empresa.CEDULACLI}</td>
                            <td>{Empresa.NOMBRECLI}</td>
                            <td>{Empresa.EMAILCLI}</td>
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
                                    on:click={borrarEmpresa(Empresa.CLIID)}
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


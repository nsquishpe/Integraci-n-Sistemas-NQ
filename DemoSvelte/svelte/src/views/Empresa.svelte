<script>
	let Empresa = [];
	let activado = true;
	let datosEmpreas = {
		id: 0,
		nombre: "",
        email: "",
	};

	let mostrarEmpresa = () => {
		fetch("https://localhost:44342/api/Cliente/")
			.then((respuesta) => respuesta.json())
			.then((datosRespuesta) => {
				Empresa = datosRespuesta;
				datosEmpreas = {
					id: 0,
					nombre: "",
                    email: "",
				};
				activado = true;
			})
			.catch(console.log);
	};

	let agregarEmpreas = () => {
		const nuevoEmpreas = {
            id: datosEmpreas.id,
		    nombre: datosEmpreas.nombre,
            email: datosEmpreas.email,
			
		};

		fetch("https://localhost:44342/api/Cliente/", {
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
		fetch("https://localhost:44342/api/Cliente/" + id, {
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
		fetch("https://localhost:44342/api/Cliente/" + datosEmpreas.id, {
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

<br>
<br>
<br>
<br>
<div class="container">
    <div class="row">
        <div class="col-md-6" />
        <div class="card">
            <div class="card-header">Empresa</div>
            <div class="card-body">
                <form>
                    <div class="mb-3">
                        <label for="" class="form-label">id</label>
                        <input
                            type="number"
                            bind:value={datosEmpreas.id}
                            class="form-control"
                        />
                        <label for="" class="form-label">Nombre</label>
                        <input
                            type="text"
                            bind:value={datosEmpreas.nombre}
                            class="form-control"
                        />
                        <label for="" class="form-label">Email</label>
                        <input
                            type="text"
                            bind:value={datosEmpreas.email}
                            class="form-control"
                        />
                    </div>
                    <button
                        type="button"
                        class="btn btn-primary"
                        on:click|preventDefault={agregarEmpreas}
                        
                    >
                        Agregar Empresa
                    </button>

                    <button
                        type="button"
                        class="btn btn-primary"
                        on:click|preventDefault={actualizarEmpresa}
                        
                    >
                        Actualizar Empresa
                    </button>
                </form>
            </div>
        </div>
    </div>
    <div class="col-md-6">
        <table class="table">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Nombre</th>
                    <th>Email</th>
                </tr>
            </thead>

            <tbody>
                {#each Empresa as Empresa}
                    <tr>
                        <td>{Empresa.id}</td>
                        <td>{Empresa.nombre}</td>
                        <td>{Empresa.email}</td>
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
                                on:click={borrarEmpresa(Empresa.id)}
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
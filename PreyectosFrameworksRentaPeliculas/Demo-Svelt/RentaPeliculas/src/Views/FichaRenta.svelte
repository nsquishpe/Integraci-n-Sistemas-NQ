<script>
    let res = [] ;
	let activado = true;
    let FICHARENTA={
                RENTID: '',
                PELIID: '',
                CLIID: '',
                FECHAREGRENT: '',
                FECHADEVRENT: '',
                FECHAENTRENT: ''
            };

    let cargarCombo = async () => {
        let url1 = "https://localhost:44392/api/Cliente/";
        let response1 = await fetch(url1);
        let Cliente = await response1.json();
        let est= Cliente;
        for (let i=0; i<est.length; i++) {
            var c = document.getElementById("comboCli");
            var option = document.createElement("option");
            option.value = est[i].CLIID;
            option.text = est[i].NOMBRECLI;
             c.appendChild(option);     
        }
	};
    
    let cargarComboPel = async () => {
        let url1 = "https://localhost:44378/api/Pelicula/";
        let response1 = await fetch(url1);
        let Cliente = await response1.json();
        let est= Cliente;
        for (let i=0; i<est.length; i++) {
            var c = document.getElementById("comboPel");
            var option = document.createElement("option");
            option.value = est[i].PELIID;
            option.text = est[i].NOMBREPELI;
             c.appendChild(option);     
        }
	};

    
	let mostrarEmpresa = async () => {
        res =[];
		let url = 'https://localhost:44393/api/Renta';
        let response = await fetch(url);
        let rentas = await response.json();

        console.log(rentas);
        

        for(var i = 0; i < rentas.length; i++){
            let modelo = {RENTID: '',NOMBRECLI: '', NOMBREPELI: '',FECHAREGRENT: '', FECHADEVRENT:'', FECHAENTRENT:''};
            modelo.RENTID = rentas[i].RENTID;
            modelo.FECHAREGRENT = rentas[i].FECHAREGRENT;
            modelo.FECHADEVRENT = rentas[i].FECHADEVRENT;
            modelo.FECHAENTRENT = rentas[i].FECHAENTRENT;
            let url1 = "https://localhost:44392/api/Cliente/" + rentas[i].CLIID
            let response1 = await fetch(url1);
            let Cliente = await response1.json();
            modelo.NOMBRECLI = Cliente.NOMBRECLI;
            let url2 = "https://localhost:44378/api/Pelicula/" + rentas[i].PELIID
            let response2 = await fetch(url2);
            let pelicula = await response2.json();
            modelo.NOMBREPELI = pelicula.NOMBREPELI;
            res.push(modelo);
        }
        res = res;
	};

	let agregarEmpreas = async () => {
        var e = document.getElementById("comboCli");
        var value = e.options[e.selectedIndex].value;

        var e1 = document.getElementById("comboPel");
        var value2 = e1.options[e1.selectedIndex].value;
        alert(value2);

		const nuevoEmpreas = {
            RENTID: FICHARENTA.RENTID,
            CLIID: value,
            PELIID: value2,
            FECHAREGRENT:FICHARENTA.FECHAREGRENT,
            FECHADEVRENT: FICHARENTA.FECHADEVRENT,
            FECHAENTRENT: FICHARENTA.FECHAENTRENT
		};

		fetch("https://localhost:44393/api/Renta", {
			method: "POST",
			headers: { "Content-type": "application/json; charset=UTF-8" },
			body: JSON.stringify(nuevoEmpreas),
		})
			.then((respuesta) => respuesta.json())
			.then((datosRespuesta) => {
                mostrarEmpresa();
			})
			.catch(console.log);
	};

	let borrarEmpresa = (id) => {
		fetch("https://localhost:44393/api/Renta/" + id, {
			method: "DELETE",
		})
			.then((respuesta) => respuesta.json())
			.then((datosRespuesta) => {
				mostrarEmpresa();
			})
			.catch(console.log);
	};

	let editarEmpresa = async (res) => {
        let url1 = "https://localhost:44393/api/Renta/" + res.RENTID;
        let response1 = await fetch(url1);
        let renta = await response1.json();
        document.getElementById("comboCli").value = renta.CLIID;
        document.getElementById("comboPel").value = renta.PELIID;
        FICHARENTA = res;
		activado=false;
	};

	let actualizarEmpresa = () => {
		fetch("https://localhost:44393/api/Renta/" + FICHARENTA.RENTID, {
			method: "PUT",
			headers: { "Content-type": "application/json; charset=UTF-8" },
			body: JSON.stringify(FICHARENTA),
		})
			.then((respuesta) => respuesta.json())
			.then((datosRespuesta) => {
				console.log(FICHARENTA);
				console.log(datosRespuesta);
				mostrarEmpresa();
			})
			.catch(console.log);
	};


	mostrarEmpresa();
    console.log(res);
    cargarCombo();
    cargarComboPel();
</script>

<body >
    <div class="pater">
        <div class="card border-dark" style="width: 30%; float:left"> 
                <div class="card-header">Membresías</div>
                <div class="card-body">
                    <form>
                        <div class="formgroup" >
                            <label for="" class="form-label">ID</label>
                            <input
                                type="text"
                                bind:value={FICHARENTA.RENTID}
                                class="form-control"
                            />

                            <label for="" class="form-label">Cliente</label>
                            <select class="form-control" id="comboCli"></select>

                            <label for="" class="form-label">Película</label>
                            <select class="form-control" id="comboPel"></select>
                            
                            <label for="" class="form-label">Fecha Registro</label>
                            <input
                                type="text"
                                bind:value={FICHARENTA.FECHAREGRENT}
                                class="form-control"
                            />
                            <label for="email" class="form-label">Fecha Devolución</label>
                            <input
                                type="text"
                                bind:value={FICHARENTA.FECHADEVRENT}
                                class="form-control"
                            />
                            <label for="email" class="form-label">Fecha Entrega</label>
                            <input
                                type="text"
                                bind:value={FICHARENTA.FECHAENTRENT}
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
                        <th>Cliente</th>
                        <th>Película</th>
                        <th>Date Registro </th>
                        <th>Date Devolución</th>
                        <th>Date Entrega</th>
                        <th></th>
                    </tr>
                </thead>
    
                <tbody>
                    {#each res as res}
                        <tr>
                            <td>{res.RENTID}</td>
                            <td>{res.NOMBRECLI}</td>
                            <td>{res.NOMBREPELI}</td>
                            <td>{res.FECHAREGRENT}</td>
                            <td>{res.FECHADEVRENT}</td>
                            <td>{res.FECHAENTRENT}</td>
                            <td>
                                <button
                                    type="submit"
                                    class="btn btn-primary"
                                    on:click={editarEmpresa(res)}
                                    >Editar
                                </button>
        
                                <button
                                    type="submit"
                                    class="btn btn-danger"
                                    on:click={borrarEmpresa(res.RENTID)}
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


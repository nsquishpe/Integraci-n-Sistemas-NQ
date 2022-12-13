<script>
    import { Router, Link, Route } from "svelte-routing";
    import Pelicula from "./Views/Pelicula.svelte";
    import Cliente from "./Views/Cliente.svelte";
    import Membresia from "./Views/Membresia.svelte";
    import FichaRenta from "./Views/FichaRenta.svelte";
</script>

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">

<div>
    <Router>
        <nav
            class="navbar navbar-expand-lg navbar-dark bg-dark"
            id="mainNav"
        >
            <div class="container-fluid">
                <a class="navbar-brand" href="#page-top" 
                    ><img
                        style="display: inline-block; width: 70px"
                        src="https://cdn-icons-png.flaticon.com/512/2809/2809590.png"
                        alt="..."
                    /> Renta de Películas - SveltCrud</a
                >
                <button
                    class="navbar-toggler"
                >
                    <i class="fas fa-bars ms-1" />
                </button>
                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <ul class="navbar-nav text-uppercase ms-auto py-5 py-lg-3" style="color:black;">
                        <li class="nav-item">
                            <Link to="/Pelicula" class="nav-link">Gestión Películas</Link>
                        </li>
                        <li class="nav-item">
                            <Link to="/Cliente" class="nav-link">Gestión Clientes</Link>
                        </li>
                        <li class="nav-item">
                            <Link to="/Membresia" class="nav-link">Gestión Membresías</Link>
                        </li>
                        <li class="nav-item">
                            <Link to="/FichaRenta" class="nav-link">Gestión Fichas Renta</Link>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>

        <Route path="/Pelicula">
            <Pelicula/>
        </Route>
        <Route path="/Cliente">
            <Cliente/>
        </Route>
        <Route path="/Membresia">
            <Membresia/>
        </Route>
        <Route path="/FichaRenta">
            <FichaRenta/>
        </Route>


    </Router>
</div>



<script>
    import { Router, Link, Route } from "svelte-routing";
    import Empresa from "./views/Empresa.svelte";
    import Inicial from "./views/Inicial.svelte";
</script>

<div>
    <Router>
        <nav
            class="
          navbar navbar-expand-lg navbar-dark
          fixed-top
          navbar-dark
          bg-info
          text-warning
        "
            id="mainNav"
        >
            <div class="container">
                <a class="navbar-brand" href="#page-top"
                    ><img
                        style="display: inline-block; height: 50px; width: 50px"
                        src="https://ampajuandemairena.files.wordpress.com/2012/10/libros.gif"
                        alt="..."
                    /></a
                >
                <button
                    class="navbar-toggler"
                    type="button"
                    data-bs-toggle="collapse"
                    data-bs-target="#navbarResponsive"
                    aria-controls="navbarResponsive"
                    aria-expanded="false"
                    aria-label="Toggle navigation"
                >
                    Menu
                    <i class="fas fa-bars ms-1" />
                </button>
                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <ul class="navbar-nav text-uppercase ms-auto py-5 py-lg-3">
                        <li class="nav-item">

                            <Link to="/" class="nav-link">Home</Link>
                        </li>
                        <li class="nav-item">
                            <Link to="/Empresa" class="nav-link">Empre</Link>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>

        <Route path="/">
            <Inicial />
        </Route>

        <Route path="/Empresa">
            <Empresa />
        </Route>

    </Router>
</div>

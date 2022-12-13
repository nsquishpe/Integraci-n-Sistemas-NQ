/// <reference path="../jquery-3.6.0.slim.min.js" />

function TodasPeliculas() {
    $.ajax({
        type: 'GET',
        url: 'https://localhost:44378/api/Pelicula',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            $.each(data, function (key, value) {
                $(
                    '<tr>' +
                    '<td>' + value.PELIID + '</td>' +
                    '<td>' + value.NOMBREPELI + '</td>' +
                    '<td>' + value.DIRECTORPELI + '</td>' +
                    '<td>' + value.GENEROPELI +
                    '</tr>'
                ).appendTo('#pelicula');
            }
            );
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function CrearPeliculas() {

    var clienteNuevo = {
        PELIID: $("#pelid").val(),
        NOMBREPELI: $("#pelnom").val(),
        DIRECTORPELI: $("#peldir").val(),
        GENEROPELI: $("#genpel").val()
    };

    $.ajax({
        type: 'POST',
        url: 'https://localhost:44378/api/Pelicula',
        data: JSON.stringify(clienteNuevo),
        contentType: "application/json;charset=utf-8",
        success: function (data, textStatus, jqXHR) {
            alert("Película ingresada correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function ActualizarPelicula() {

    var clienteNuevo = {
        PELIID: $("#pelid").val(),
        NOMBREPELI: $("#pelnom").val(),
        DIRECTORPELI: $("#peldir").val(),
        GENEROPELI: $("#genpel").val()
    };

    $.ajax({
        type: 'PUT',
        url: 'https://localhost:44378/api/Pelicula',
        data: JSON.stringify(clienteNuevo),
        contentType: "application/json;charset=utf-8",
        success: function (data, textStatus, jqXHR) {
            alert("Película actualizada correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function EliminarPelicula() {

    var clienteNuevo = {
        PELIID: $("#pelid").val(),
        NOMBREPELI: $("#pelnom").val(),
        DIRECTORPELI: $("#peldir").val(),
        GENEROPELI: $("#genpel").val()
    };

    $.ajax({
        type: 'DELETE',
        url: 'https://localhost:44378/api/Pelicula/' + clienteNuevo.PELIID,
        data: JSON.stringify(clienteNuevo),
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            alert("Película eliminada correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function PeliculaPorID(id) {

    $.ajax({
        type: 'GET',
        url: 'https://localhost:44378/api/Pelicula/' + id,
        dataType: 'json',
        success: function (data) {
            detail = '<div><strong>Película ID</strong></div>' + '<div>' + data.PELIID + '</div>' +
                '<div><strong>Nombre</strong></div>' + '<div>' + data.NOMBREPELI + '</div>' +
                '<div><strong>Director</strong></div>' + '<div>' + data.DIRECTORPELI + '</div>' +
                '<div><strong>Género</strong></div>' + '<div>' + data.GENEROPELI + '</div>';
            $('#consulta').html(detail);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}
/// <reference path="../jquery-3.6.0.slim.min.js" />

function TodasRentas() {
    $.ajax({
        type: 'GET',
        url: 'https://localhost:44393/api/Renta',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            $.each(data, function (key, value) {
                $(
                    '<tr>' +
                    '<td>' + value.RENTID + '</td>' +
                    '<td>' + value.PELIID + '</td>' +
                    '<td>' + value.CLIID + '</td>' +
                    '<td>' + value.FECHAREGRENT + '</td>' +
                    '<td>' + value.FECHADEVRENT + '</td>' +
                    '<td>' + value.FECHAENTRENT +
                    '</tr>'
                ).appendTo('#renta');
            }
            );
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function CrearRentas() {

    var clienteNuevo = {
        RENTID: $("#renid").val(),
        PELIID: $("#pelid").val(),
        CLIID: $("#clid").val(),
        FECHAREGRENT: $("#fecha1").val(),
        FECHADEVRENT: $("#fecha2").val(),
        FECHAENTRENT: $("#fecha3").val()
    };

    $.ajax({
        type: 'POST',
        url: 'https://localhost:44393/api/Renta',
        data: JSON.stringify(clienteNuevo),
        contentType: "application/json;charset=utf-8",
        success: function (data, textStatus, jqXHR) {
            alert("Ficha Renta ingresada correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function ActualizarRenta() {

    var clienteNuevo = {
        RENTID: $("#renid").val(),
        PELIID: $("#pelid").val(),
        CLIID: $("#clid").val(),
        FECHAREGRENT: $("#fecha1").val(),
        FECHADEVRENT: $("#fecha2").val(),
        FECHAENTRENT: $("#fecha3").val()
    };

    $.ajax({
        type: 'PUT',
        url: 'https://localhost:44393/api/Renta',
        data: JSON.stringify(clienteNuevo),
        contentType: "application/json;charset=utf-8",
        success: function (data, textStatus, jqXHR) {
            alert("Ficha Renta actualizada correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function EliminarRenta() {

    var clienteNuevo = {
        RENTID: $("#renid").val(),
        PELIID: $("#pelid").val(),
        CLIID: $("#clid").val(),
        FECHAREGRENT: $("#fecha1").val(),
        FECHADEVRENT: $("#fecha2").val(),
        FECHAENTRENT: $("#fecha3").val()
    };

    $.ajax({
        type: 'DELETE',
        url: 'https://localhost:44393/api/Renta/' + clienteNuevo.RENTID,
        data: JSON.stringify(clienteNuevo),
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            alert("Ficha Renta eliminada correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}


function RentaPorID(id) {

    $.ajax({
        type: 'GET',
        url: 'https://localhost:44393/api/Renta/' + id,
        dataType: 'json',
        success: function (data) {
            detail = '<div><strong>Renta ID</strong></div>' + '<div>' + data.RENTID + '</div>' +
                '<div><strong>Película ID</strong></div>' + '<div>' + data.PELIID + '</div>' +
                '<div><strong>Cliente ID</strong></div>' + '<div>' + data.CLIID + '</div>' +
                '<div><strong>Fecha registro</strong></div>' + '<div>' + data.FECHAREGRENT + '</div>' +
                '<div><strong>Fecha devolución</strong></div>' + '<div>' + data.FECHADEVRENT + '</div>' +
                '<div><strong>Fecha entrega</strong></div>' + '<div>' + data.FECHAENTRENT + '</div>';
            $('#consulta').html(detail);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}
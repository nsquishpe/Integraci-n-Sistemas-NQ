/// <reference path="../jquery-3.6.0.slim.min.js" />

function TodasMembresias() {
    $.ajax({
        type: 'GET',
        url: 'https://localhost:44391/api/Membresia',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            $.each(data, function (key, value) {
                $(
                    '<tr>' +
                    '<td>' + value.MEMID + '</td>' +
                    '<td>' + value.CLIID + '</td>' +
                    '<td>' + value.FECHAREGMEM + '</td>' +
                    '<td>' + value.FECHAEXOMEM +
                    '</tr>'
                ).appendTo('#membresia');
            }
            );
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function CrearMembresias() {

    var clienteNuevo = {
        MEMID: $("#memid").val(),
        CLIID: $("#clid").val(),
        FECHAREGMEM: $("#fecha1").val(),
        FECHAEXOMEM: $("#fecha2").val()
    };

    $.ajax({
        type: 'POST',
        url: 'https://localhost:44391/api/Membresia',
        data: JSON.stringify(clienteNuevo),
        contentType: "application/json;charset=utf-8",
        success: function (data, textStatus, jqXHR) {
            alert("Membresía ingresada correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function ActualizarMembresia() {

    var clienteNuevo = {
        MEMID: $("#memid").val(),
        CLIID: $("#clid").val(),
        FECHAREGMEM: $("#fecha1").val(),
        FECHAEXOMEM: $("#fecha2").val()
    };

    $.ajax({
        type: 'PUT',
        url: 'https://localhost:44391/api/Membresia',
        data: JSON.stringify(clienteNuevo),
        contentType: "application/json;charset=utf-8",
        success: function (data, textStatus, jqXHR) {
            alert("Membresía actualizada correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function EliminarMembresia() {

    var clienteNuevo = {
        MEMID: $("#memid").val(),
        CLIID: $("#clid").val(),
        FECHAREGMEM: $("#fecha1").val(),
        FECHAEXOMEM: $("#fecha2").val()
    };

    $.ajax({
        type: 'DELETE',
        url: 'https://localhost:44391/api/Membresia/' + clienteNuevo.MEMID,
        data: JSON.stringify(clienteNuevo),
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            alert("Membresía eliminada correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function MembresiaPorID(id) {

    $.ajax({
        type: 'GET',
        url: 'https://localhost:44391/api/Membresia/' + id,
        dataType: 'json',
        success: function (data) {
            detail = '<div><strong>Membresía ID</strong></div>' + '<div>' + data.MEMID + '</div>' +
                '<div><strong>Cliente ID</strong></div>' + '<div>' + data.CLIID + '</div>' +
                '<div><strong>Fecha registro</strong></div>' + '<div>' + data.FECHAREGMEM + '</div>' +
                '<div><strong>Fecha expiración</strong></div>' + '<div>' + data.FECHAEXOMEM + '</div>';
            $('#consulta').html(detail);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}



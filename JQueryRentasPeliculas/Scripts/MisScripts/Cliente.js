/// <reference path="../jquery-3.6.0.slim.min.js" />

function TodosClientes() {
    $.ajax({
        type: 'GET',
        url: 'https://localhost:44392/api/Cliente',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            $.each(data, function (key, value) {
                $(
                    '<tr>' +
                    '<td>' + value.CLIID + '</td>' +
                    '<td>' + value.NOMBRECLI + '</td>' +
                    '<td>' + value.CEDULACLI + '</td>' +
                    '<td>' + value.EMAILCLI +
                    '</tr>'
                ).appendTo('#Clientes');
            }
            );
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function CrearClientes() {

    var clienteNuevo = {
        CLIID: $("#clid").val(),
        NOMBRECLI: $("#clinom").val(),
        CEDULACLI: $("#clicel").val(),
        EMAILCLI: $("#cliemail").val()
    };

    $.ajax({
        type: 'POST',
        url: 'https://localhost:44392/api/Cliente',
        data: JSON.stringify(clienteNuevo),
        contentType: "application/json;charset=utf-8",
        success: function (data, textStatus, jqXHR) {
            alert("Cliente ingresado correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function ActualizarCliente() {

    var clienteNuevo = {
        CLIID: $("#clid").val(),
        NOMBRECLI: $("#clinom").val(),
        CEDULACLI: $("#clicel").val(),
        EMAILCLI: $("#cliemail").val()
    };

    $.ajax({
        type: 'PUT',
        url: 'https://localhost:44392/api/Cliente',
        data: JSON.stringify(clienteNuevo),
        contentType: "application/json;charset=utf-8",
        success: function (data, textStatus, jqXHR) {
            alert("Cliente actualizado correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function EliminarClientes() {

    var clienteNuevo = {
        CLIID: $("#clid").val(),
        NOMBRECLI: $("#clinom").val(),
        CEDULACLI: $("#clicel").val(),
        EMAILCLI: $("#cliemail").val()
    };

    $.ajax({
        type: 'DELETE',
        url: 'https://localhost:44392/api/Cliente/' + clienteNuevo.CLIID,
        data: JSON.stringify(clienteNuevo),
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            alert("Cliente eliminado correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function ClientePorID(id) {

    $.ajax({
        type: 'GET',
        url: 'https://localhost:44392/api/Cliente/' + id,
        dataType: 'json',
        success: function (data) {
            detail = '<div><strong>ID</strong></div>' + '<div>' + data.CLIID + '</div>' +
                '<div><strong>Nombre</strong></div>' + '<div>' + data.NOMBRECLI + '</div>' +
                '<div><strong>Cédula</strong></div>' + '<div>' + data.CEDULACLI + '</div>' +
                '<div><strong>Email</strong></div>' + '<div>' + data.EMAILCLI + '</div>';
            $('#Cliente').html(detail);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}
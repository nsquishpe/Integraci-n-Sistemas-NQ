/// <reference path="jquery-3.6.0.slim.min.js" />

function TodosClientes() {
    $.ajax({
        type: 'GET',                                              
        url: 'https://localhost:44342/api/Cliente',                   
        dataType: 'json',                                                
        success: function (data, textStatus, jqXHR) {
            $.each(data, function (key, value) {
                $(
                    '<tr>' +
                    '<td>' + value.id + '</td>' +
                    '<td>' + value.nombre + '</td>' +
                    '<td>' + value.email +
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
        id: $("#clid").val(),
        nombre: $("#clinom").val(),
        email: $("#cliemail").val()
    };

    $.ajax({
        type: 'POST',
        url: 'https://localhost:44342/api/Cliente',
        data: JSON.stringify(clienteNuevo),
        contentType:"application/json;charset=utf-8",
        success: function (data, textStatus, jqXHR) {
            alert("Estudiante ingresado correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function ActualizarCliente() {

    var clienteNuevo = {
        id: $("#clid").val(),
        nombre: $("#clinom").val(),
        email: $("#cliemail").val()
    };

    $.ajax({
        type: 'PUT',
        url: 'https://localhost:44342/api/Cliente',
        data: JSON.stringify(clienteNuevo),
        contentType: "application/json;charset=utf-8",
        success: function (data, textStatus, jqXHR) {
            alert("Estudiante actualizado correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function EliminarClientes(id) {
    $.ajax({
        type: 'DELETE',
        url: 'https://localhost:44342/api/Cliente/' + id,
        dataType: 'json',
        success: function (data) {
            alert("Estudiante eliminado correctamente");
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alter('Estatus: ' + textStatus + '(' + errorThrown + ')');
        }
    });
}

function ClientesPorID(id) {

}

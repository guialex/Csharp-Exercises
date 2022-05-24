window.onload = function () {
    listarUsuarios();
    $.ajax(
        {
            url: '/Home/ApagarUsuario',
            type: 'POST',
            data: {
                id: 3
            },
            success: function () {
                listarUsuarios();
            }
        }
    )
    listarUsuarios();
    
}
function listarUsuarios() {
    $.get("/Home/ListarUsuarios", function (data, status) {
        console.log(data)
    })
}
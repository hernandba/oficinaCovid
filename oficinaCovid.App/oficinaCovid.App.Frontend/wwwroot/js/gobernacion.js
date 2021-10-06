
$(document).ready(function () {
    //var saludo = document.getElementById("action");
    $('#action').click(function (e) { 
        e.preventDefault();
        window.location.href = "/Modulos/Oficina/Oficina";
        return false;
    });

    $('#go-modulo').click(function (e) { 
        e.preventDefault();
        var modulo = $('#modulos').val();
        var principalContainer = $('#load-forms');
        var gobernacionid = $('#gobernacionid').val();
        if (modulo == 1) {
            window.location.href = "/Modulos/Oficina/Oficina?gobernacionid="+gobernacionid;
        } else if (modulo == 2){
            principalContainer.html("Hello");
        }
    });
});

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
            window.location.href = "/Modulos/Oficina/List?gobernacionid="+gobernacionid;
        } else if (modulo == 2){
            window.location.href = "/Modulos/Secretario/List?gobernacionid="+gobernacionid;
        } else if (modulo == 3){
            window.location.href = "/Modulos/PersonalAseo/List?gobernacionid="+gobernacionid;
        } else if (modulo == 4){
            window.location.href = "/Modulos/Gobernador/List?gobernacionid="+gobernacionid;
        }
    });
});
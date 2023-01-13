function mascara(i) {
    var v = i.value;

    if (isNaN(v[v.length - 1])) {
        i.value = v.substring(0, v.length - 1);
        return;
    }
    i.setAttribute("maxlength", "14");
    if (v.length == 3 || v.length == 7) i.value += ".";
    if (v.length == 11) i.value += "-";
}



let value_cpf = document.querySelector('#cpfcampo');

value_cpf.addEventListener("keydown", function (e) {
    if (e.key > "a" && e.key < "z") {
        e.preventDefault();
    }
});

value_cpf.addEventListener("blur", function (e) {
    //Remove tudo o que não é dígito
    let validar_cpf = this.value.replace(/\D/g, "");

    if (!validar_cpf ||
        validar_cpf.length != 11 ||
        validar_cpf == "00000000000" ||
        validar_cpf == "11111111111" ||
        validar_cpf == "22222222222" ||
        validar_cpf == "33333333333" ||
        validar_cpf == "44444444444" ||
        validar_cpf == "55555555555" ||
        validar_cpf == "66666666666" ||
        validar_cpf == "77777777777" ||
        validar_cpf == "88888888888" ||
        validar_cpf == "99999999999"
    ) {
        e.preventDefault();
        document.getElementById("cpfcampo").focus();
        document.getElementById("msgerro").style.display = '';
    }
    else {
        document.getElementById("msgerro").style.display = 'none';
    }

    //verificação da quantidade números
    if (validar_cpf.length == 11) {

        // verificação de CPF valido
        var Soma;
        var Resto;

        Soma = 0;
        for (i = 1; i <= 9; i++) Soma = Soma + parseInt(validar_cpf.substring(i - 1, i)) * (11 - i);
        Resto = (Soma * 10) % 11;

        if ((Resto == 10) || (Resto == 11)) Resto = 0;
        if (Resto != parseInt(validar_cpf.substring(9, 10))) {
            document.getElementById("cpfcampo").focus();
            e.preventDefault();
            document.getElementById("msgerro").style.display = '';
        }

        Soma = 0;
        for (i = 1; i <= 10; i++) Soma = Soma + parseInt(validar_cpf.substring(i - 1, i)) * (12 - i);
        Resto = (Soma * 10) % 11;

        if ((Resto == 10) || (Resto == 11)) Resto = 0;
        if (Resto != parseInt(validar_cpf.substring(10, 11))) {
            document.getElementById("cpfcampo").focus();
            e.preventDefault();
            document.getElementById("msgerro").style.display = '';
        }

        //formatação final
        cpf_final = validar_cpf.replace(/(\d{3})(\d)/, "$1.$2");
        cpf_final = cpf_final.replace(/(\d{3})(\d)/, "$1.$2");
        cpf_final = cpf_final.replace(/(\d{3})(\d{1,2})$/, "$1-$2");
        document.getElementById('campo_cpf').value = cpf_final;

    } else {
        e.preventDefault();
        document.getElementById("cpfcampo").focus();
        document.getElementById("msgerro").style.display = '';
    }
})

function mask(o, f) {
    setTimeout(function () {
        var v = mphone(o.value);
        if (v != o.value) {
            o.value = v;
        }
    }, 1);
}

function mphone(v) {
    var r = v.replace(/\D/g, "");
    r = r.replace(/^0/, "");
    if (r.length > 10) {
        r = r.replace(/^(\d\d)(\d{5})(\d{4}).*/, "($1) $2-$3");
    } else if (r.length > 5) {
        r = r.replace(/^(\d\d)(\d{4})(\d{0,4}).*/, "($1) $2-$3");
    } else if (r.length > 2) {
        r = r.replace(/^(\d\d)(\d{0,5})/, "($1) $2");
    } else {
        r = r.replace(/^(\d*)/, "($1");
    }
    return r;
}


//--Defini o valor max do campo nascimento, para previnir entrar com datas futuras.--//
var today = new Date();
var dd = String(today.getDate()).padStart(2, '0');
var mm = String(today.getMonth() + 1).padStart(2, '0');
var yyyy = today.getFullYear();

today = yyyy + '-' + mm + '-' + dd;
document.getElementById("nascimento").max = today;
//||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||//
$(document).ready(function () {
    loadCidades();
});

function loadCidades() {
    CidadeListaCidades('').then(function (data) {
        data.forEach(obj => {
            $('#cidadeId').append('<option value="' + obj.id + '">' + obj.NomeCidade + '</option>');
        });
        $('#cidadeId').select2();

    });
}

function salvar() {
    let obj = {
        nome: ($("[name='nome']").val() || ''),
        cidadeId: ($("[name='cidadeId']").val() || ''),
        peso: (parseInt($("[name='peso']").val()) || 0),
        dataNascimento: ($("[name='dataNascimento']").val() || '')
    };
    PessoaSalvar(obj).then(function () {
        window.location.href = '/pessoa';
    }, function (err) {
        alert(err);
    });
}
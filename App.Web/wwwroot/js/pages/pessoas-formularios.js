$(document).ready(function () {
    loadPessoas();
});

function loadCidades() {
    CidadeListaCidades('').then(function (data) {
        data.forEach(obj => {
            $('#cidadeId').append('<option value="' + obj.id + '">' + obj.nome +'</option>
        });
        $('#cidadeId').select2();

    });

}



function salvar() {
    let obj = {
        nome: ($("[name='nome']").val() || ''),
        cidadeId: ($("[name='cidadeId']").val() || ''),
        dataNascimento: ($("[name='dataNascimento']").val() || ''),
        peso: ($("[name='peso']").val() || ''),
    };
    PessoaSalvar(obj).then(function () {
        window.location.href = '/pessoas';
    }, function (err) {
        alert(err);
    });

}

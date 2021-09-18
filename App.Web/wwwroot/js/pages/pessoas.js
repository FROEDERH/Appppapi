$(document).ready(function () {
    load();
});

function load() {
    PessoaListaPessoas().then(function (data) {
        data.forEach(obj => {
            $(' #table tbody').append('' +
                '<tr id="obj-' + obj.id + '"> ' +
                '<td>' + (obj.nome || '--') + '</td>' +
                '<td>' + (obj.peso || '--') + '</td>' +
                '<td>' + (obj.dataNascimento || '--') + '</td>' +
                '<td>' + (obj.cidadeId || '--') + '</td>' +
                '</tr>');

        });

    });

}
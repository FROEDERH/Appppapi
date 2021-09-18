function salvar() {
    let obj = {
        cep: ($("[name='cep']").val() || ''),
        nomeCidade: ($("[name='nome']").val() || ''),
        uf: ($("[name='uf']").val() || ''),
    };
    CidadeSalvar(obj).then(function () {
        window.location.href = '/cidades';
    }, function (err) {
        alert(err);
    });

}
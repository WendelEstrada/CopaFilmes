$(".checkbox-input").change(function () {
    let quantidade = parseInt($("#spanQuantidadeFilmes").text());

    if (this.checked)
        quantidade = parseInt(quantidade) + 1;
    else
        quantidade = parseInt(quantidade) - 1;

    $("#spanQuantidadeFilmes").text(quantidade);

    if (quantidade == 16)
        $("#btnGerarCampeonato").removeAttr("disabled");
    else
        $("#btnGerarCampeonato").attr("disabled", "disabled");
})
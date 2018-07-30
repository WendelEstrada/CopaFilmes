$("#btnGerarCampeonato").click(function () {
    $(".checkbox-input:checked").each(function (index, element) {
        console.log(element);
        let dadosDoFilme = element.parentElement.children;
        console.log(dadosDoFilme);

        let filme = new Filme(
            dadosDoFilme[2].value,
            dadosDoFilme[3].value,
            dadosDoFilme[4].value,
            dadosDoFilme[5].value
        );

        adicionarFilmeNoHtml(filme, index);
    });

    $(".form").submit();
})
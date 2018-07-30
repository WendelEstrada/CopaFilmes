function adicionarFilmeNoHtml(filme, index) {
    $('<input>').attr({
        type: 'hidden',
        name: 'filmesViewModel[' + index + '].Id',
        value: filme.id
    }).appendTo("#divFilmesSelecionados");

    $('<input>').attr({
        type: 'hidden',
        name: 'filmesViewModel[' + index + '].PrimaryTitle',
        value: filme.primaryTitle
    }).appendTo("#divFilmesSelecionados");

    $('<input>').attr({
        type: 'hidden',
        name: 'filmesViewModel[' + index + '].Year',
        value: filme.year
    }).appendTo("#divFilmesSelecionados");

    $('<input>').attr({
        type: 'hidden',
        name: 'filmesViewModel[' + index + '].AverageRating',
        value: filme.averageRating
    }).appendTo("#divFilmesSelecionados");
}
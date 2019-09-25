﻿
$(function () {
    $idTituloReceber = $("#id").val();
    $idAlterar = -1;
    var radioButton = "ClientePessoaJuridica.RazaoSocial";



    $tabelaParcelas = $("#titulo-receber-parcelas-tabela").DataTable({      
        ajax: '/parcelasreceber/obtertodos?idTituloReceber=' + $idTituloReceber,
        serverSide: true,
        columns: [
            { data: "Id" },
            { data: 'NomeCliente' },
            { data: "ValorTotal" },
            { data: "QuantidadeParcela" },
            {
                render: function (data, type, row) {
                    let cor = "";
                    if (row.Status == "Pago") {
                        cor = "bg-success";
                    } else if (row.Status == "Pendente") {
                        cor = "bg-warning";
                    } else {
                        cor = "bg-danger";
                    }
                    return "<span class='" + cor + " pr-2 pl-2 b2-1 rounded'>" + row.Status + "</span>"

                }
            },
            {
                render: function (data, type, row) {
                    return moment(row.DataLancamento).format('DD/MM/YYYY')
                }
            },
            {
                render: function (data, type, row) {
                    return moment(row.DataRecebimento).format('DD/MM/YYYY')
                }
            },
            {
                render: function (data, type, row) {
                    return moment(row.DataVencimento).format('DD/MM/YYYY')
                }
            },
            {data: "Complemento"},
            { data: "Descricao" },
            {
                render: function (data, type, row) {
                    return "\
                    <button class='btn btn-primary botao-editar fa fa-edit'\
                        data-id=" + row.Id + "> Editar</button>\
                    <button class='btn btn-danger botao-apagar fa fa-trash'\
                     ml-2   data-id=" + row.Id + "> Apagar</button>";
                }
            }
        ]
    });

    $("#tituloReceber-tabela").on('click', '.botao-apagar', function () {
        confirma = confirm("Deseja Realmente Apagar?")
        if (confirma == true) {
            $id = $(this).data('id');
            $.ajax({
                url: '/tituloreceber/apagar?id=' + $id,
                method: "get",
                success: function (data) {
                    if ($('#tituloReceber-campo-tipo-pessoa-fisica').is(':checked')) {
                        radioButton = '"ClientePessoaFisica.Nome"';
                    } else {
                    }
                    $tabelaTituloReceber.ajax.reload();
                },
                error: function (err) {
                    alert('Não foi possível apagar');
                }
            });
        }
    });
    $("#gerar-parcelas").on("click", function () {
        $.ajax({
            url: '/parcelasreceber/GerarParcelas?idTituloReceber=' + $idTituloReceber,
            method: "get",
            success: function (data) {
                $tabelaParcelas.ajax.reload();
            },
            error: function (err) {
                alert('Não foi possível gerar parcelas');
            }
        });
    });

    function monstrarMensagem(texto, titulo, tipo) {       
        return false;
        new PNotify({
            title: titulo,
            text: texto,
            icon: 'icofont icofont-info-circle',
            type: tipo
        });
    }

});
document.addEventListener("DOMContentLoaded", function() {
  var botao = document.getElementById("novoFuncionario");

  listarFuncionariosDoServidor();

  botao.onclick = novoFuncionario;
});

function novoFuncionario() {
  var corpoTabela = document.querySelector('#funcionarios tbody');
  var linha = document.createElement("tr");

  corpoTabela.appendChild(linha);

  var c1 = document.createElement("td");
  c1.innerHTML = '<input type="checkbox" />';
  linha.appendChild(c1);

  var c2 = document.createElement("td");
  c2.innerHTML = "Karina Vasconcelos";
  linha.appendChild(c2);

  var c3 = document.createElement("td");
  c3.innerHTML = "Customer Success";
  linha.appendChild(c3);

  var c4 = document.createElement("td");
  c4.innerHTML = "a@iclips.com.br";
  linha.appendChild(c4);

  var c5 = document.createElement("td");
  c5.innerHTML = "(32) 1020-3040";
  linha.appendChild(c5);

  var c6 = document.createElement("td");
  linha.appendChild(c6);

  var c7 = document.createElement("td");
  linha.appendChild(c7);
}

function listarFuncionariosDoServidor() {
    fetch('/api/funcionarios')
        .then((res) => {
            return res.json();
        })
        .then((data) => {
            for (var i = 0; i < data.length; i++) {
                adicionaFuncionarioNaTabela(data[i]);
            }
        });
}

function adicionaFuncionarioNaTabela(funcionario) {
    var corpoTabela = document.querySelector('#funcionarios tbody');
    var linha = document.createElement("tr");

    corpoTabela.appendChild(linha);

    var c1 = document.createElement("td");
    c1.innerHTML = '<input type="checkbox" />';
    linha.appendChild(c1);

    var c2 = document.createElement("td");
    c2.innerHTML = funcionario.nome;
    linha.appendChild(c2);

    var c3 = document.createElement("td");
    c3.innerHTML = funcionario.departamento;
    linha.appendChild(c3);

    var c4 = document.createElement("td");
    c4.innerHTML = funcionario.email;
    linha.appendChild(c4);

    var c5 = document.createElement("td");
    c5.innerHTML = funcionario.telefonePrimario;
    linha.appendChild(c5);

    var c6 = document.createElement("td");
    linha.appendChild(c6);

    var c7 = document.createElement("td");
    linha.appendChild(c7);
}
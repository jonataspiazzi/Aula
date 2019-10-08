document.addEventListener("DOMContentLoaded", function() {
  document.getElementById("novoFuncionario").onclick = abrirModal;
  document.querySelector('.modal .modal-header .close').onclick = fecharModal;

  listarFuncionariosDoServidor();
});

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
    c6.style.textAlign = 'center';
    c6.innerHTML = '<input type="checkbox" class="input-toggle" checked disabled />';
    linha.appendChild(c6);

    var c7 = document.createElement("td");
    c7.innerHTML = `
      <div class="grid-button">
        <img src="/images/visualizar.png" />
        <img src="/images/editar.png" />
        <img src="/images/excluir.png" />
      </div>
    `;
    linha.appendChild(c7);
}

function fecharModal() {
  document.querySelector('.modal-bg').style.display = 'none';
  document.querySelector('.modal-wrapper').style.display = 'none';
}

function abrirModal() {
  document.querySelector('.modal-bg').style.display = 'block';
  document.querySelector('.modal-wrapper').style.display = 'flex';
}
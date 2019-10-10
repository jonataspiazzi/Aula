const funcionarios = [];

document.addEventListener("DOMContentLoaded", function() {
  document.getElementById("novoFuncionario").onclick = novo;
  document.querySelector('.modal .modal-header .close').onclick = fecharModal;
  document.querySelector('.modal .modal-footer #cancelar').onclick = fecharModal;
  document.querySelector('.modal .modal-footer #fechar').onclick = fecharModal;
  document.querySelector('.modal .modal-footer #salvar').onclick = salvar;

  listarFuncionariosDoServidor();
});

function listarFuncionariosDoServidor() {
    fetch('/api/funcionarios')
        .then((res) => {
            return res.json();
        })
        .then((data) => {
            funcionarios.push(...data);

            for (var i = 0; i < data.length; i++) {
                adicionaFuncionarioNaTabela(data[i]);
            }
        });
}

function adicionaFuncionarioNaTabela(funcionario) {
  var corpoTabela = document.querySelector('#funcionarios tbody');
  var linha = document.createElement("tr");
  linha.id = funcionario.idFuncionario;

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
  c6.innerHTML = `<input type="checkbox" class="input-toggle" ${funcionario.acessoAoIClips ? 'checked' : ''} disabled />`;
  linha.appendChild(c6);

  var c7 = document.createElement("td");
  c7.innerHTML = `
    <div class="grid-button">
      <img src="/images/visualizar.png" onclick="visualizar(${funcionario.idFuncionario})" />
      <img src="/images/editar.png" onclick="editar(${funcionario.idFuncionario})" />
      <img src="/images/excluir.png" onclick="excluir(${funcionario.idFuncionario})" />
    </div>
  `;
  linha.appendChild(c7);
}

function editaFuncionarioNaTabela(funcionario) {
  const linha = document.querySelector(`#funcionarios tbody tr[id='${funcionario.idFuncionario}']`);

  if (!linha) return;

  linha.querySelector('td:nth-child(2)').innerHTML = funcionario.nome;
  linha.querySelector('td:nth-child(3)').innerHTML = funcionario.departamento;
  linha.querySelector('td:nth-child(4)').innerHTML = funcionario.email;
  linha.querySelector('td:nth-child(5)').innerHTML = funcionario.telefonePrimario;
  linha.querySelector('td:nth-child(6) input[type=checkbox]').checked = funcionario.acessoAoIClips;
}

function novo() {
  const funcionario = {
    acessoAoIClips: false,
    ativoNaAgencia: false,
    dataNascimento: '',
    departamento: '',
    email: '',
    idFuncionario: '',
    login: '',
    nome: '',
    senha: '',
    telefonePrimario: '',
    telefoneSecundario: ''
  };

  carregarFuncionario(funcionario, false, 'Novo Funcionário', 'none', 'block', 'block');
}

function visualizar(id) {
  const funcionario = funcionarios.find(f => f.idFuncionario == id);

  carregarFuncionario(funcionario, true, 'Funcionário', 'block', 'none', 'none');
}

function editar(id) {
  const funcionario = funcionarios.find(f => f.idFuncionario == id);
  
  carregarFuncionario(funcionario, false, 'Editar Funcionário', 'none', 'block', 'block');
}

function excluir(id) {
  if (confirm('Deseja mesmo exclir este funcionário')) {
    const funcionario = funcionarios.find(f => f.idFuncionario == id);

    excluirNoServidor(id, function () {
      const index = funcionarios.indexOf(funcionario);
      funcionarios.splice(index, 1);
  
      const linha = document.querySelector(`table tr[id='${funcionario.idFuncionario}']`);
      linha.parentNode.removeChild(linha);
    });
  }
}

function salvar() {
  const funcionario = {};

  for (const input of document.querySelectorAll('.modal [name]')) {
    if (input.type == 'date') {
      if (input.value) {
        funcionario[input.name] = new Date(input.value);
      } else {
        funcionario[input.name] = undefined;
      }
    } else if (input.type == 'checkbox') {
      funcionario[input.name] = input.checked;
    } else {
      funcionario[input.name] = input.value || undefined;
    }
  }

  salvarNoServidor(funcionario, function (fun) {
    if (!funcionario.idFuncionario) {
      funcionarios.push(fun);
  
      adicionaFuncionarioNaTabela(fun);
    } else {
      const index = funcionarios.indexOf(funcionario);
      funcionarios.splice(index, 1, fun);

      editaFuncionarioNaTabela(fun);
    }
  
    fecharModal();
  });
}

function salvarNoServidor(funcionario, callback) {
  let url = '/api/funcionarios';
  let method = 'POST';

  if (funcionario.idFuncionario) {
    url = url + '/' + funcionario.idFuncionario;
    method = 'PUT';
  }
  
  fetch(url, { 
    method: method,
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(funcionario)
  })
    .then((res) => res.json())
    .then(callback);
}

function excluirNoServidor(id, callback) {
  let url = '/api/funcionarios/' + id;
  
  fetch(url, { method: 'DELETE' }).then(callback);
}

function carregarFuncionario(funcionario, desabilitado, titulo, botaoFechar, botaoSalvar, botaoCancelar) {
  document.querySelector('.modal #fechar').style.display = botaoFechar;
  document.querySelector('.modal #cancelar').style.display = botaoCancelar;
  document.querySelector('.modal #salvar').style.display = botaoSalvar;
  document.querySelector('.modal .modal-header h2').innerHTML = titulo;

  for (const tag of document.querySelectorAll('.modal [name]')) {
    tag.disabled = desabilitado;
  }

  for (const prop in funcionario) {
    const input = document.querySelector(`.modal [name=${prop}]`);
    
    if (input) {
      if (input.type == "date") {
        if (funcionario[prop]) {
          input.value = new Date(funcionario[prop]).toISOString().substr(0, 10);
        } else {
          input.value = '';
        }
      }
      else if (input.type == "checkbox") {
        input.checked = funcionario[prop];
      }
      else {
        input.value = funcionario[prop];
      }
    }
  }

  abrirModal();
}

function fecharModal() {
  document.querySelector('.modal-bg').style.display = 'none';
  document.querySelector('.modal-wrapper').style.display = 'none';
}

function abrirModal() {
  document.querySelector('.modal-bg').style.display = 'block';
  document.querySelector('.modal-wrapper').style.display = 'flex';
}
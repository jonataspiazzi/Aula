create database iclipsDB;
use iclipsdb;
create table Funcionarios (
  IdFuncionario int not null AUTO_INCREMENT primary key,
  Nome varchar(50),
  Email varchar(30),
  Departamento varchar(30),
  DataNascimento date,
  TelefonePrimario varchar(20),
  TelefoneSecundario varchar(20),
  Login varchar(20),
  Senha varchar(20), 
  AcessoAoIClips bit default 0,
  AtivoNaAgencia bit default 0
  );
  
# HandsOnWork04 - Sistema de Compra de Ingressos

Projeto Hands on Work do módulo 4 do curso de Análise e Desenvolvimento de Sistemas da Univali.
Alunos: Laíz Sayuri Moreira Goto, Deise Flaviana Andrade dos Santos, Enza Machado, Kelvin Ramon Rosa e Elias João do Nascimento Junior.
Gerenciador de compras de ingressos feito com Windows Form e Entity Framework, utilizando padrão MVC.

Como rodar a aplicação:

- Para rodar a aplicação, instale o banco de dados PostgreSQL no seu computador e crie um banco de dados com o nome "sci". Após criado, execute em seu SGBD:

```
CREATE TABLE Local (
    CodLocal int GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	Endereco varchar(100) not null,
    Cidade varchar(100) not null,
	Estado varchar(2) not null
);

CREATE TABLE Categoria (
    CodCategoria int GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    Nome varchar(100) not null
);

CREATE TABLE Funcionario (
	CodFuncionario int GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	Nome varchar(100) not null,
	Email varchar(100) not null,
	Senha varchar(32 ) not null,
	CPF varchar(11) not null,
	Admin boolean not null
);

CREATE TABLE Cliente (
	CodCliente int GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	Nome varchar(100) not null,
	CPF varchar(11) not null,
	DataNascimento date not null,
	Telefone varchar(11),
	Email varchar(100) not null,
	Senha varchar(32 ) not null	
);

CREATE TABLE Evento (
	CodEvento int GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	CodCategoria int  not null,
	CodLocal int  not null,	
	Nome varchar(100) not null,
	Artista varchar(100) not null,
	Data date not null,
	ValorIngresso decimal not null,
	NumeroIngressos int not null,
	Descricao varchar(500),
	Liberado boolean not null default(false)
);

ALTER TABLE Evento
ADD FOREIGN KEY (CodCategoria) REFERENCES Categoria(CodCategoria);

ALTER TABLE Evento
ADD FOREIGN KEY (CodLocal) REFERENCES Local(CodLocal);

CREATE TABLE Ingresso (
	CodIngresso int GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	CodEvento int  not null,
	CodCliente int  not null,
	ValorInteiro boolean not null
);

ALTER TABLE Ingresso
ADD FOREIGN KEY (CodEvento) REFERENCES Evento(CodEvento);

ALTER TABLE Ingresso
ADD FOREIGN KEY (CodCliente) REFERENCES Cliente(CodCliente);

CREATE TABLE PagamentoCartao (
	CodPagamento int GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	CodIngresso int  not null,
	ValorAPagar decimal not null,
	NomeTitular varchar(32) not null,
	NumeroCartao varchar(32) not null,
	DataValidade varchar(32) not null,
	CodSeguranca varchar(32) not null,
	TransacaoAprovada boolean not null
);

ALTER TABLE PagamentoCartao
ADD FOREIGN KEY (CodIngresso) REFERENCES Ingresso(CodIngresso);

CREATE TABLE PagamentoBoleto (
	CodPagamento int GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
	CodIngresso int  not null,
	ValorAPagar decimal not null,
	NumeroBoleto varchar(44) not null,
	DataVencimento date not null	
);

ALTER TABLE PagamentoBoleto
ADD FOREIGN KEY (CodIngresso) REFERENCES Ingresso(CodIngresso);

------------------------------------------------------------------------------

insert into funcionario (nome,email,senha,cpf,admin) values('Administrador','admin@sci.com','21232f297a57a5a743894a0e4a801fc3','31622563050',true)

insert into funcionario (nome,email,senha,cpf,admin) values('Funcionário','funcionario@sci.com','cc7a84634199040d54376793842fe035','45634391008',false)

insert into cliente (nome,cpf,datanascimento,telefone,email,senha) values ('Cliente','38209434047','1997-03-24','76999687811','cliente@sci.com','4983a0ab83ed86e0e7213c8783940193')

insert into categoria (nome) values ('Rock')
insert into categoria (nome) values ('Rap')

insert into local (endereco, cidade, estado) values ('Rua Buenos Aires, 1270','Curitiba','PR');
insert into local (endereco, cidade, estado) values ('Rua Machade de Carvalho, 543','São Paulo','SP');

```

- Dentro do projeto, em SCI,Model > Model > sciContext, altere se necessário as configurações de conexão com o banco. Agora basta compilar o projeto e executar. 

- As credenciais para logar como Admin são "admin@sci.com" e senha: "admin".

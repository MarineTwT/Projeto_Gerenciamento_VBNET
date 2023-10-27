create database Agenda_empresa

use Agenda_empresa

create table Empresa(
	ID_E int identity(1,1) primary key not null,
	Nome varchar (50) not null,
	Endereco varchar(100) not null,
	Data_fund date not null,
	Telefone int not null,
	Email varchar(50) not null,
)

insert into Empresa(Nome,Endereco,Data_fund,Telefone,Email)
	values
	('Telecom,LDA','Rua Serra de Bragança 13','1995-02-10',456123789,'telecomrh@hotmail.com'),
	('Maximum Games.Inc','Rua Frederico Moura 12','1980-10-24',794613285,'Maximumrh@gmail.com'),
	('Midialirics.Inc','Avenida Governador José Malcher 08','2003-01-01',999658742,'Midialiricsrh@outlook.com'),
	('PixelNova Studios','Rua 25 de Março 12','2006-12-10',123456789,'pixelnrh@gmail.com'),
	('NovaCore Interactive','Rua das Garças 13','2009-03-03',987654321,'novacoreinfo@gmail.com')
	
create table Jogo(
	Nome varchar(50) primary key not null,
	Genero varchar(50) not null,
	Subgenero varchar(50) not null,
	Classif varchar(10) not null,
	Descricao varchar(50) not null,
	Empresa int not null foreign key references Empresa(ID_E)
)

--ALTER TABLE Jogo
--ADD CONSTRAINT PK_jogo PRIMARY KEY (ID_J,Nome);

/*DBCC CHECKIDENT ('Jogo', RESEED, 0)  --> Tirei o ID porque estava dando muito problema
SET IDENTITY_INSERT dbo.Jogo ON   -- -> on para adicionar algo,off para voltar ao normal*/

insert into Jogo(Nome,Genero,Subgenero,Classif,Descricao,Empresa)
	values
	('Trelele Gaming','Quiz','Family','+3','Jogo de pergunta e resposta.',5),
	('Mamicum cooking','Arcade','Family','+3','Jogo de cozinhar para descontrair com a família.',2),
	('Letrelicus','Arcade','Family','+3','Jogo de cpergunta e respostas.',2),
	('Crosshire','Action','War','+16','Jogo de guerra moderna.',3),
	('Patapa','Rhythm','Arcade','+10','Jogo de ritmo com tambor.',4),
	('Kartcup','Racing','Arcade','+3','Jogo de corrida de kart.',1),
	('Rally Smash','Racing','Simulator','+7','Jogo de corrida rally realista.',1),
	('Pantaguá','Platform','Family','+3','Jogo plataforma em 2D.',2)

create table Cargo(
	ID_C int identity(1,1) primary key not null,
	Nome varchar(50) not null
)

insert into Cargo(Nome)
	values
	('Presidente'),
	('Programador'),
	('Marketing'),
	('Desenhista'),
	('Limpeza'),
	('Segurança')
	
create table Funcionario(
	Nome varchar (100) primary key not null,
	NIF int unique not null,
	Telefone int,
	Data_nasc date not null,
	Email varchar(50) not null,
	Empresa int not null foreign key references Empresa(ID_E),
	Cargo int not null foreign key references Cargo(ID_C),
	Data_contrato date not null,
	Salario int not null,
	Ativo bit not null
)

Create table Grupo(
	Funcionario varchar(100) not null foreign key references Funcionario(Nome),
	Jogo varchar(50) not null foreign key references Jogo(Nome),
	Data_inicio date not null,
	Data_final date not null,
	Estado int not null
)

/*select * from Funcionario*/

/*Select f.Nome,NIF,f.Telefone,Data_nasc,f.Email,e.Nome,c.Nome,Data_contrato,Salario,Ativo
from Funcionario f
inner join dbo.Cargo c on c.ID_C = f.Cargo 
inner join dbo.Empresa e on e.ID_E = f.Empresa*/

/*Select Funcionario,Jogo,Data_inicio,Data_final,Estado
from Grupo
where Funcionario = 'Pablo Jardim'*/

/*Select f.Empresa,f.Nome,Endereco,Data_fund,f.Telefone,f.Email
from Empresa e
inner join Funcionario f on f.Empresa = e.ID_E
where f.Empresa = 1*/
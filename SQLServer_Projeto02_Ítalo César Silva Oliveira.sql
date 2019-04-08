CREATE DATABASE DB_Projeto02
GO

USE DB_Projeto02
GO

-- USE master
-- DROP DATABASE DB_Projeto02

CREATE TABLE Diretor (
ID_Diretor INT IDENTITY(1,1) PRIMARY KEY,
Nome VARCHAR(80),
Idade INT,
Celular VARCHAR(11),
Email VARCHAR(100),
Senha VARCHAR(30)
)

CREATE TABLE Funcionario (
ID_Funcionario  INT IDENTITY(300,10) PRIMARY KEY,
Nome VARCHAR(80),
Celular VARCHAR(11),
Data_Nascimento VARCHAR(10),
Email VARCHAR(100),
Cargo VARCHAR(60),
Senha VARCHAR(30)
)

CREATE TABLE Curso (
ID_Curso INT IDENTITY(1000,5) PRIMARY KEY,
Nome VARCHAR(80),
Duracao VARCHAR(60),
Preco  FLOAT,
Data_Inicio VARCHAR(10),
Data_Fim VARCHAR(10),
Descricao VARCHAR(350)
)

CREATE TABLE Turma (
ID_Turma INT IDENTITY(10,10) PRIMARY KEY,
Nome VARCHAR(80),
Curso VARCHAR(60),
Numero_Sala  INT,
Localizacao VARCHAR(80)
)

CREATE TABLE Aluno (
ID_Aluno INT IDENTITY(3151120,1) PRIMARY KEY,
Nome VARCHAR(80),
RG VARCHAR(20),
CPF VARCHAR(20),
CEP  VARCHAR(10),
Celular VARCHAR(11),
Endereco VARCHAR(60),
Cidade VARCHAR(60),
Bairro VARCHAR(60),
Data_Nascimento VARCHAR(10),
Nome_Responsavel VARCHAR(100),
Email VARCHAR(100),
Turma_ID_Turma INT,
Nome_Turma VARCHAR(15),
FOREIGN KEY (Turma_ID_Turma) REFERENCES  Turma(ID_Turma)
)

CREATE TABLE Coordenador (
ID_Coordenador INT IDENTITY(1,1) PRIMARY KEY,
ID_Funcionario_Coordenador INT,
FOREIGN KEY(ID_Funcionario_Coordenador) REFERENCES Funcionario (ID_Funcionario)
)

CREATE TABLE Professor (
ID_Professor INT IDENTITY(1,1) PRIMARY KEY,
Nome VARCHAR(80),
Celular VARCHAR(11),
Data_Nascimento VARCHAR(10),
Email  VARCHAR(100),
Senha  VARCHAR(30),
ID_Coordenador_Professor INT,
FOREIGN KEY(ID_Coordenador_Professor) REFERENCES Coordenador (ID_Coordenador)
)

CREATE TABLE PlanoEnsino (
ID_Plano_Ensino INT IDENTITY(1,1) PRIMARY KEY,
Materia VARCHAR(60),
ObjetivoGeral  VARCHAR(200),
Avaliacoes  VARCHAR(200),
Metodologia  VARCHAR(200),
ID_Professor_Plano_Ensino INT,
ID_Curso_PlanoEnsino INT,
FOREIGN KEY(ID_Curso_PlanoEnsino) REFERENCES Curso (ID_Curso),
FOREIGN KEY(ID_Professor_Plano_Ensino) REFERENCES Professor (ID_Professor)
)


-- Inser��o dos valores da tabela Diretor
INSERT INTO Diretor (Nome, Idade, Celular, Email, Senha) VALUES ('�talo C�sar Silva Oliveira', 16, '31975706224', 'italo.s.oliveira@hotmail.com', 'italo123')
SELECT * FROM Diretor

-- Inser��o dos valores da tabela Funcionario
INSERT INTO Funcionario (Nome, Celular, Data_Nascimento, Email, Cargo, Senha) VALUES ('Arthur Jos� R. Carvalho', '31975706224', '1997/07/31', 'arthurjose3@hotmail.com', 'Professor', 'arthur123')
SELECT * FROM Funcionario

-- Inser��o dos valores da tabela Curso
INSERT INTO Curso (Nome, Duracao, Preco, Data_Inicio, Data_Fim,Descricao) VALUES ('Tecnico em Informatica', '640 horas', 6500.00, '05/02/2019', '30/06/2020','O curso de t�cnico em inform�tica tem dura��o m�dia de um ano e meio. Durante os m�dulos, o estudante participa de atividades pr�ticas, desde a montagem de computadores no in�cio do curso, bem como o desenvolvimento de sistemas ao final.')
INSERT INTO Curso (Nome, Duracao, Preco, Data_Inicio, Data_Fim,Descricao) VALUES ('Tecnico em Redes', '300 horas', 4300.00, '01/02/2019', '20/07/2020','O curso t�cnico em Redes de Computadores est� inserido no eixo tecnol�gico informa��o e comunica��o que compreende tecnologias relacionadas � comunica��o e ao processamento de dados e informa��es. Abrange os sistemas operacionais, protocolos de comunica��o, equipamentos e arquitetura de redes e sua seguran�a.')
SELECT * FROM Curso

-- Inser��o dos valores da tabela Turma
INSERT INTO Turma (Nome, Curso, Numero_Sala, Localizacao) VALUES ('TI21 T', 'Tecnico em Informatica', 1106, '11� Terceiro Andar')
INSERT INTO Turma (Nome, Curso, Numero_Sala, Localizacao) VALUES ('TI22 N', 'Tecnico em Desenvolvimento de Sistemas', 506, '5� Quinto Andar')
SELECT * FROM Turma

-- Inser��o dos valores da tabela Aluno
INSERT INTO Aluno (Nome, RG, CPF, Celular, CEP, Endereco, Bairro, Cidade, Data_Nascimento, Nome_Responsavel, Email,Turma_ID_Turma,Nome_Turma) VALUES ('Yasmin Assis Teixeira Oliveira', 'MG09876548', '09968595608','31976675889', 32655602, 'Rua Cascais', 'S�o Jo�o','Betim', '2019/02/08', 'Gustavo da Silva Ribeiro', 'yasminbr@hotmail.com',10,'TI21 T')
INSERT INTO Aluno (Nome, RG, CPF, Celular, CEP, Endereco, Bairro, Cidade, Data_Nascimento, Nome_Responsavel, Email,Turma_ID_Turma,Nome_Turma) VALUES ('Pedro Prevencie Wesley', 'MG15684359', '00355116984','315579652', 32655602, 'Rua Alameda dos Falcatas', 'Rio Novo','Contagem', '2018/09/04', 'Marta Prevencie Jhonson', 'pedroprevencie@hotmail.com',20,'TI22 N')
SELECT * FROM Aluno

-- Inser��o dos valores da tabela Coordenador
INSERT INTO Coordenador (ID_Funcionario_Coordenador) VALUES (300)
SELECT * FROM Coordenador

-- Inser��o dos valores da tabela Professor
INSERT INTO Professor (Nome, Celular, Data_Nascimento, Email, Senha, ID_Coordenador_Professor) VALUES ('Clara Assis Teixeira da Silva Oliveira', '31987766554', '2007/05/08', 'claraassis@hotmail.com', 'claraassis',1)
SELECT * FROM Professor

-- Inser��o dos valores da tabela PlanoEnsino
INSERT INTO PlanoEnsino (Materia, ObjetivoGeral, Avaliacoes, Metodologia, ID_Professor_Plano_Ensino, ID_Curso_PlanoEnsino) VALUES ('Classes e Parametros', 'Possuir o conhecimento para a cria��o de objetos em suas devidas classes.', '(10 pontos) - Participa��o, (50 pontos) - Avalia��o, (40 pontos) - projeto', 'Aulas Praticas, Aulas Teoricas', 1, 1000)
SELECT * FROM PlanoEnsino

-- Select Gerais
SELECT * FROM Diretor
SELECT * FROM Funcionario
SELECT * FROM Curso
SELECT * FROM Turma
SELECT * FROM Aluno
SELECT * FROM Coordenador
SELECT * FROM Professor
SELECT * FROM PlanoEnsino

SELECT*FROM  Aluno WHERE Cidade LIKE 'Contagem';


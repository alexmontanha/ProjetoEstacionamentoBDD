# Projeto para Estacionamento e estudo de BDD

## Descrição do Projeto

Sistema que será construído para o estacionamento de uma universidade que deseja facilitar e agilizar o controle de acesso de veículos aos seus cinco estacionamentos para prover mais segurança e comodidade para os seus usuários. 

O sistema deverá permitir que se cadastre todos os tipos de usuários (alunos, professores e funcionários), que receberão um cartão com um código de barras para sua identificação. Cada usuário poderá solicitar o cadastramento de vários veículos com os quais utiliza os estacionamentos da universidade. Além dissso, para todos os usuários precisamos ter armazenado o nome, sobrenome, sexo, cpf, cnh, telefone, celular, email e data de nascimento.

Ao chegar a qualquer portão de acesso à universidade, o vigilante irá informar a placa do veículo e o usuário deverá passar o cartão magnético em um leitor de código de barras, e com isso, o sistema irá identificar se o veículo está relacionado com a identificação do usuário. Ao sair, o usuário simplesmente passa o seu cartão em outra leitora de código de barras. Para cada veículo estacionado é importante saber as seguintes informações: placa, renavam, nome da marca, nome do modelo, cor, nome do proprietário, telefone do proprietário, data e hora da última entrada, data e hora da última saída e tempo de permanência no estacionamento.

O visitante (usuário não cadastrado) deverá pegar um cartão especial com os vigilantes. Através desses procedimentos, o sistema poderá fornecer dados de ocupação de cada estacionamento, além de permitir a consulta de quais os veículos estão, ou estiveram, dentro da universidade em um determinado dia e horário.

## Tecnologias utilizadas

- .NET Core 3.1
- C# Lib Project
- DataBase Mock Json

## Arquitetura

### Arquitetura DDD

#### Camadas

- Application
- Domain
- Infra
- Tests
- Shared

## BDD

Utilizaremos o Behavior Driven Development (BDD) para a criação de cenários de testes.

### Cenários

#### Gestão de Veículos

Como usuário administrador
Eu quero criar, modificar ou excluir os veículos dos usuários
Para que eu possa monitorar os veículos dos usuários dos estacionamentos

#### Gestão de Usuários

Como usuário administrador
Eu quero criar, modificar ou excluir: alunos, professores, funcionários e usuários visitantes
Para que eu possa gerenciar os tipos de usuários dos estacionamentos

#### Gestão de Estacionamentos

Como vigilante do estacionamento
Eu quero pesquisar e visualizar o período de estacionamento dos veículos
Para que eu possa monitorar a entrada e saída de veículos nos estacionamentos


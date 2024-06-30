# EstudosPooCsharp
Repositório para estudos de Poo/ Revisão

## Programação orientada a objetos
- Paradigma baseado no conceito de objetos(mundo real) para representar diferentes aspectos da aplicação. Exemplo: dados de um cliente numa aplicação de e-commerce.

## Seus 4 pilares:
-  Abstração
-  Encapsulamento
-  Herança
-  Polimorfismo

# - Abstração
- Na programação orientada a objetos a abstração seria pegar só o que é preciso para aquele caso. Por exemplo, se fomos abstrair uma pessoa para um site de e-commerce, só precisamos do nome, endereço e número do cartão, não precisamos saber o que ela faz, ou sua altura e etc. Abstraimos e usamos as informações necessárias. 

# - Encapsulamento
- O encapsulamento como o nome já diz, serve pra encapsular, esconder determinadas funcionalidades de um objeto. por exemplo na hora de fazer uma compra, as funcionalidades que são internas não são mostradas para o cliente, são ENCAPSULADAS, onde só o objeto(o sistema de compras) sabe como fazer.

# - Herança
- É um principio de POO que permite o compatilhamento de informações(atríbutos e métodos) entre classes(classe pai com suas classes filhas).

# - Polimorfismo
- Característica que permite que objetos respondam a mesma mensagem(um bom exemplo é os métodos) de maneiras diferentes.

# Classes e objetos

## Classe:
- A classe é um modelo/estrutura do que o objeto vai se tornar. Toda classe pode ser constituída de estado(atríbutos) ou comportamento.

## Objeto: 
- instância da classe

# Classes no C#
## O que tem?
## - Atributos
## - Propriedades - Get e Set
## - Métodos - comportamentos do objeto
## - Construtores - Chamado toda vez que faz a instância da classe
## - Todos os citados acima são membros
## - Também existe membros estáticos que são a nível de classe, não de instância
## - Membros estáticos são usados quando queremos fazer uma ação que não vai envolve o estado do objeto.
## - Existe também membros constantes. Não altera.
## Um objeto também pode ser composto de outros objetos, tornando ele muito mais complexo e bem dividido.

# Tipos por valor e por referência

## - Tipos por valor ocupam a Stack na memória(e o valor e fixo na memória) e os tipos por referência ocupam a Heap (as variáveis apontam para os valores na memória).

# Interfaces
## - Interface nada mais é do que um contrato. Com Interfaces conseguimos ter uma abstração maior e uma possibilidades maior de estender o código.

# Classes abstradas
## - Serve pra especializar o código.

# Classes seladas
## - Classes seladas não podem ser herdadas.

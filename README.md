# ExercicosCsharp

## Exercicio 01

✅ Atividade 1: Serialização e Desserialização Básica
Objetivo: Aprender a salvar e carregar dados de um arquivo JSON com System.Text.Json.

Desafio:
Crie uma classe Produto com os campos: Id, Nome, Preco.

Crie uma lista de produtos em memória.

Serialize essa lista e salve no arquivo produtos.json.

Depois, carregue os dados do arquivo e mostre no console.

Conceitos abordados:
JsonSerializer.Serialize

JsonSerializer.Deserialize

File.WriteAllText e File.ReadAllText

- [x] feita 


## Exercicio 02 

✅ Atividade 2: Criando uma Service para Lógica de Produto
Objetivo: Criar uma Service que encapsule regras de negócio para gerenciar produtos.

Desafio:
Crie uma pasta chamada Services.

Dentro dela, crie uma classe ProdutoService com os métodos:

AdicionarProduto(Produto p)

ListarProdutos()

SalvarNoJson()

CarregarDoJson()

Todos os métodos devem operar sobre a lista de produtos da classe.

A Service deve lidar com o JSON diretamente — encapsulando o acesso ao arquivo.

Conceitos abordados:
Regras de negócio dentro de Service

Responsabilidade única (SRP)

Uso de JSON isolado da lógica principal

## Exercicio 03


✅ Atividade 3: Criando Regras de Validação
Objetivo: Implementar regras de negócio reais (validações).

Desafio:
Adicione validação no método AdicionarProduto:

Não permitir nome vazio.

Não permitir preço menor que zero.

Faça o método retornar bool e imprimir mensagens de erro.

Crie um método BuscarPorId(int id) na ProdutoService.

Conceitos abordados:
Validação de dados

Regras de negócio puras

Boas práticas de retorno e mensagens

## Exercicio 04

✅ Atividade 4: Criando Múltiplos Services com Dependência
Objetivo: Criar serviços que se relacionam entre si.

Desafio:
Crie uma classe Categoria (Id, Nome).

Crie um CategoriaService com métodos parecidos com ProdutoService.

Adicione um campo CategoriaId no Produto.

A ProdutoService agora deve consultar o CategoriaService para verificar se o CategoriaId existe antes de adicionar o produto.

Conceitos abordados:
Serviços com dependência entre si

Integração entre dados relacionados

Relacionamento lógico entre entidades

## Exercicio 05

✅ Atividade 5: Interface Gráfica com Console + Persistência
Objetivo: Simular um mini-sistema no console com menus e persistência em JSON.

Desafio:
Crie um menu principal:

1 - Adicionar Produto

2 - Listar Produtos

3 - Adicionar Categoria

4 - Listar Categorias

0 - Sair

Utilize os Services criados anteriormente para executar as ações.

Todos os dados devem ser persistidos no JSON.

Conceitos abordados:
Organização completa de um projeto

Separação entre lógica de apresentação (console) e lógica de negócio (services)

Salvamento e carregamento automático do sistem
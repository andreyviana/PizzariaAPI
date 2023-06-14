# PizzariaAPI

para testar as opereções CRUD do programa: 
1. Abra um novo terminal e digite ``dotnet run`` para inicializar a API que está rodando no domínio **https://localhost:7000**
2. Abra um novo terminal e escreva: ``httprepl https://localhost:7000`` para rodar o projeto com **REPL**
3. No novo terminal aberto, use: ``cd Pizza`` para usar o endpoint **/Pizza**
4. É possível usar o comando ``ls`` para listar as operações desenvolvidas nesse projeto
5. Para testar o programa basta usar o comando ``get`` no console, a fim de mostrar as pizzas disponíveis.
6. Mostrando uma pizza específica, use ``get 1`` ou ``get {id}`` para exibir uma pizza específica a partir do id do objeto.
7. Adicionando um novo objeto usando o método **POST** exemplo: ``post -c "{"nome":"Havaí", "isGlutenFree":false}"`` ou ``post -c "{"nome":"{nome}", "isGlutenFree":{valor booleano}}"`` a fim de criar um novo objeto.
8. Atualizando um objeto através do método **PUT**: ``put 3 -c  "{"id": 3, "nome":"Havaiana", "isGlutenFree":false}"`` ou ``put {id} -c  "{"id": {id}, "nome":"{nome}", "isGlutenFree":{valor booleano}}"``.
9. Por fim, usando o método **DELETE** para deletar um objeto: ``delete 3`` ou ``delete {id}``.

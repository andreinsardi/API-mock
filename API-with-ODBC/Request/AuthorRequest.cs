using System;
/* A classe Request é uma classe simples sem herança
 *
 * Sua finalidade é servir de objeto para trafegar os dados que as chamadas da API irá receber,
 * nela só existirá os atributos necessários para a executar uma chamada (o atibutos devem ter o mesmo nome dos
 * campos do Banco de Dados por questão de organização)
 *
 * É comum tanto as Classes do Result quanto o Request espelharem quase que por completo os campos da tabela do
 * banco de dados
 *
 * Neste caso a tabela base para nossa classe é a tabela Author
 */
namespace API_with_ODBC.Request 
{
    public class AuthorRequest
    {
        public string Name { get; set; } // Em .NetCore conseguimos implemntar os metoddos get e set apenas com uma notaçao  { get; set; } 
    }
}

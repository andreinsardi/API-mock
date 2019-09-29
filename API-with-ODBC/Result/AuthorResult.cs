using System;
/* Assim como a classe Request a classe Result é bem simples e sem herança
 *
 * Sua finalidade é servir de objeto para trafegar os dados que a API irá retornar,
 *
 * Repare que diferente da classe Request a Classe Result apresenta o atributo AuthorID
 *
 * Isto acontece pois o Request é utilizado na entrada da requisição, logo no caso de um "POST" (criação de um
 * objeto), a chamada da API não sabe qual será o ID do novo registro, porém no retorno (Result) o sistema já
 * possui esta informação, sendo necessario o campo no objeto de Result
 */
namespace API_with_ODBC.Result
{
    public class AuthorResult
    {
        public int AuthorID { get; set; }

        public string Name { get; set; }

    }
}

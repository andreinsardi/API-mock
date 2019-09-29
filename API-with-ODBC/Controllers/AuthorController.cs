using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_with_ODBC.Request; //import do namespace com as classes de Request
using API_with_ODBC.Result; //import do namespace com as classes de Result

// Visual Studio cria a Controller da API com rotas e os 5 verbos já pré criados
/* Antes de criar todas as rotas da controle você deve criar os objetos de Request e Result
 * que serão utilizados na Controller.
 *
 * Tenha em mente que os objetos de Request são as informações nescessarias para que sua API execute o verbo proposto
 * Assim como o Result são as informações que a sua API irá retornar após a execução
 * Logo você deve modelar (escolher as informações) desta classe com atenção
 *
 * Os métoddos da Controller devem retornar um objeto IActionResult, esta classe faz parte do AspNetCore.Mvc e é
 * capaz de implementar varios tipos de retornos convenientes ao padrão REST como a classe OkObjectResult
 *
 * A classe OkObjectResult tem a capacidade de retornar um JSON que atenda o pardrão REST com a seguinte estrutura:
 * - Header
 * - Body
 * - Status code
 * - Message
 *
 * Ao criar um objeto (new OkObjectResult(result)) você pode passar uma classe populada e as informação deste objeto serão convertidas
 * em JSON na tag Body respeitando o padrão REST
 * 
 * Para visualizar melhor o exemplo execute https://localhost:5001/api/Author quando estiver rodando localmente
 * este projeto
*/
namespace API_with_ODBC.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //notation para criar as rotas dinamicamente 
    public class AuthorController : Controller // classe AuthorController herda Classe "Controller" do framework AspNetCore.MVC
    {


        [HttpGet]  //Definie o métoddo (verbo) da rota 
        public IActionResult Get() //nome do metoddo e nome dos parametros de entrada devem ser iguais aos da notação da rota
        {
            // aqui implementamos nossa regra de negócios
            // por hora iremos mokar os dados de retorno

            List<AuthorResult> result = new List<AuthorResult>(); //O métoddo Get sem parametros busca no banco toddos os Autores sendo assim criamos uma lista de AuthorResult para receber esta informação do Banco e ser repassada para o JSON de retorno 

            //aqui iremos mokar a informção do banco
            result.Add(new AuthorResult
            {
                AuthorID = 1,
                Name = "André Insardi"
            });

            result.Add(new AuthorResult
            {
                AuthorID = 2,
                Name = "Teste 1"
            });

            result.Add(new AuthorResult
            {
                AuthorID = 3,
                Name = "André"
            });
            //aqui iremos mokar a informção do banco

            return new OkObjectResult(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody]AuthorRequest request)//em um verbo POST ou PUT você pode passar os parametros da chamada pelo Body usando a notation [FromBody] isso permite passar objeto JSON complexos
        {

            AuthorResult result = new AuthorResult();

            //rotina de gravar dados no banco e selecionar Autor gravado para retornar (neste exemplo mokado)
            result.AuthorID = 1;
            result.Name = request.Name;
            //rotina de gravar dados no banco e selecionar Autor gravado para retornar (neste exemplo mokado)

            return new OkObjectResult(result);
        }

        [HttpGet("{AuthorID}")]
        public IActionResult Get(int AuthorID)
        {
            AuthorResult result = new AuthorResult();

            //aqui iremos mokar a informção do banco
            result.AuthorID = AuthorID;
            result.Name = "Teste 1";
            //aqui iremos mokar a informção do banco

            return new OkObjectResult(result);
        }

        [HttpPut("{AuthorID}")]
        public IActionResult Put(int AuthorID, [FromBody]AuthorRequest request)
        {

            AuthorResult result = new AuthorResult();

            //rotina de gravar dados no banco e selecionar Autor gravado para retornar (neste exemplo mokado)
            result.AuthorID = 6;
            result.Name = request.Name;
            //rotina de gravar dados no banco e selecionar Autor gravado para retornar (neste exemplo mokado)

            return new OkObjectResult(result);
        }

        [HttpDelete("{AuthorID}")]
        public IActionResult Delete(int AuthorID)
        {
            return new OkResult();
        }

     }
}

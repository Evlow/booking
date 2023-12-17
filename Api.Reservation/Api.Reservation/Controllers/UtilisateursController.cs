using Api.Reservation.Business.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Reservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateursController : ControllerBase
    {
        private readonly IUtilisateurService _utilisateurService;

        public UtilisateursController (IUtilisateurService utilisateurService )
        {
            _utilisateurService = utilisateurService;

        }
        // TODO

        // GET: api/<UtilisateursController>
        [HttpGet]
        [ProducesResponseType(typeof(Datas.Entities.Utilisateur), 200)]
        public async Task<IActionResult> GetAllUtilisateursAsync()
        {
            return Ok(await _utilisateurService.GetUtilisateursAsync());
        }

        // GET api/<UtilisateursController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UtilisateursController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UtilisateursController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UtilisateursController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

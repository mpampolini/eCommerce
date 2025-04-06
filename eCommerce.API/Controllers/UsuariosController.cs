using eCommerce.API.Repositories;
using eCommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuariosController(IUsuarioRepository repository)
        {
            this._repository = repository;
        }

        // {endereco-site/api/usuarios}
        [HttpGet]
        public IActionResult Get() {

            var listaUsuarios = _repository.Get();

            return Ok(listaUsuarios);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id) {
            var usuario = _repository.Get(id);
            if (usuario == null)
            {
                return NotFound("Usuário não encontrado");
            }
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Add([FromBody]Usuario usuario)
        {
            usuario.Id = 0;
            _repository.Add(usuario);

            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody]Usuario usuario, int id)
        {
            _repository.Update(usuario);
            
            return Ok(usuario);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);

            return Ok();
        }

    }
}

using technoMarket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace technoMarket.Controllers
{
    [Route("/[controller]")]//  https://User
    [ApiController]
    public class UserController : ControllerBase
    {
        private static List<User> usuarios = new List<User>(); //Creo una lista que va a contener los Usuarios

        [HttpGet("GetAll")]//   https://User/GetAll



        //IEnumerable es una interfaz en .NET que proporciona una forma de iterar sobre una colección de elementos
        public ActionResult<IEnumerable<User>> GetAll() //Darle el formato a un EndPoint, devuelve el un statuserror
        {
            var response = usuarios.Where(a => a.Active).ToList();

            if (response.Count () < 1)
            {
                return NotFound("No se Encontaron Datos en la DB");
            }

            return Ok(response);//Devuelve un StatusCOde 200 cona Lista de productos que estan Activos

        }

        [HttpGet("GetById/{id}")]
        
        public ActionResult<User?> GetById([FromRoute] int id) 
        { 
            User? user = usuarios.Where(p => p.Id == id && p.Active).FirstOrDefault(); //Este método devuelve el primer elemento de la secuencia que cumple con las condiciones especificadas en el Where.


        }

    }
}

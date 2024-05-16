using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechnoMarket.Application.Services;
using TechnoMarket.Domain.Models;



namespace technoMarket.Controllers
{
    [Route("/[controller]")]//  https://User
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("GetAll")]//   https://User/GetAll
        //IEnumerable es una interfaz en .NET que proporciona una forma de iterar sobre una colección de elementos
        public ActionResult<IEnumerable<User>> GetAll() //Darle el formato a un EndPoint, devuelve el un statuserror
        {

            UserServices userServices = new UserServices(); //

            var response = userServices.GetUserList();

            if (response.Count () < 1)
            {
                return NotFound("No se Encontaron Datos en la DB");
            }

            return Ok(response);//Devuelve un StatusCOde 200 cona Lista de productos que estan Activos

        }

        [HttpGet("GetById/{id}")]
        public ActionResult<User?> GetById([FromRoute] int id) 
        { 
        
            UserServices userServices = new UserServices();
            var user = userServices.GetUserById(id);

            if (user != null)
            {
                return NotFound("No se Encontaron Datos en la DB");

            }
            return Ok(user);
        }

        [HttpPost("Register")]
        public ActionResult Register([FromBody] User user)
        {
            UserServices userServices = new UserServices();
            var flag = userServices.RegisterUser(user);

           if (!flag)
           {
                return BadRequest("Usuario existente");
           }

            string baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            string apiAndEndpointUrl = $"api/User/GetById";
            string locationUrl = $"{baseUrl}/{apiAndEndpointUrl}/{user.Id}";

            return Created(locationUrl, user);
        }



    }
}

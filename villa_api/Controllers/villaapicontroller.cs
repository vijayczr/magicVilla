using Microsoft.AspNetCore.Mvc;
using System.Net;
using villa_api.daata;
using villa_api.models;
using villa_api.models.dto;

namespace villa_api.Controllers
{
    [Route("api/villaapi")]
    [ApiController]
    public class villaapicontroller : controllerbase
    {
        [HttpGet]
        public ActionResult GetVillas()
        {
            return Ok((villastore.villalist));
        }
        [HttpGet("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult GetVillas(int id)
        {
            if(id== 0)
            {
                return BadRequest();
            }
            var villa = villastore.villalist.FirstOrDefault(u => u.id == id);
            if(villa== null)
            {
                return NotFound();
            }
            return Ok(villa);
        }
    }
}

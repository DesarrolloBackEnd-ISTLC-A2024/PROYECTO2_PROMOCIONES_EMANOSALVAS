﻿using Microsoft.AspNetCore.Mvc;
using PROYECTO2_PROMOCIONES_EMANOSALVAS.Comunes;
using PROYECTO2_PROMOCIONES_EMANOSALVAS.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PROYECTO2_PROMOCIONES_EMANOSALVAS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromocionesController : ControllerBase
    {
        [HttpGet]
        public List<Promocion> Get()
        {
            return ConexionBD.GetPromociones();
        }

        [HttpGet("{id_promocion}")]
        public Promocion Get(int id_promocion)
        {
            return ConexionBD.GetPromocion(id_promocion);
        }


        [HttpPost]
        public void Post([FromBody] Promocion objPromocion)
        {
            ConexionBD.PostPromocion(objPromocion);
        }


        [HttpPut("{id_promocion}")]
        public void Put(int id_promocion, [FromBody] Promocion objPromocion)
        {
            ConexionBD.PutPromocion(id_promocion, objPromocion);
        }


        // DELETE api/<PromocionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
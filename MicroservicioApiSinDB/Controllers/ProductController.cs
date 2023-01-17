using System.Collections.Generic;
using System.Threading.Tasks;
using MicroservicioApiSinDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioApiSinDB
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public async Task<ActionResult<List<ProductModel>>> GetAllProduct()
        {
            return   Ok(ProductModels);
        }
       
        //CREANDO LA SIMILITUD DE UNA BASE DE DATOS 
        public static List<ProductModel> ProductModels = new List<ProductModel>
        {
            new ProductModel
            {
                Id = 1,
                Name = "Maracas",
                Price = 12000,
                Description = "Maracas de totumo"
            },
            new ProductModel
            {
                Id = 2,
                Name = "Guitarra Acustica",
                Price = 220000,
                Description = "La mejor Guitarra Acustica"
            },
            new ProductModel
            {
                Id = 3,
                Name = "Bateria",
                Price = 1200000,
                Description = "La mejor Bateria pequeña"
            }
        };
    }
}
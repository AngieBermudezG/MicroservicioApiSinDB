using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroservicioApiSinDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioApiSinDB
{
    [ApiController]
    [Route("Products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<ProductModel>>> GetAllProduct()
        {
            return   Ok(ProductModels);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductModel>> GetProductById(int id)
        {
            var product = ProductModels.Single(p => p.Id == id);
            return product;
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct(ProductModel product)
        {
            product.Id = ProductModels.Count() + 1;
            ProductModels.Add(product);

            return CreatedAtAction(
                "GetProductById",
                new { id = product.Id },
                product
            );
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
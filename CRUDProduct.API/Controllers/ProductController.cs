using CRUDProduct.Application.Dtos;
using CRUDProduct.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUDProduct.API.Controllers
{
    [Route("product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IApplicationServiceProduct applicationServiceProduct;

        public ProductController(IApplicationServiceProduct applicationServiceProduct)
        {
            this.applicationServiceProduct = applicationServiceProduct;
        }

        // GET api/values
        [Route("v1/products")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> Index()
        {
            return Ok(await applicationServiceProduct.List());
        }

        // GET api/values/5
        [Route("v1/products/{id}")]
        [HttpGet]
        public async Task<ActionResult<ProductDto>> Get(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var product = await applicationServiceProduct.GetEntityById((int)id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductDto productDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return NotFound();

                await applicationServiceProduct.Add(productDto);
                return Ok("Produto Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ProductDto productDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return NotFound();

                await applicationServiceProduct.Update(productDto);
                return Ok("Produto Atualizado com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET: Products/Delete/5
        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] ProductDto productDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return NotFound();

                await applicationServiceProduct.Delete(productDto);
                return Ok("Produto removido com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
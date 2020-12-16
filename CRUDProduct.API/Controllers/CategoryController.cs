using CRUDProduct.Application.Dtos;
using CRUDProduct.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUDProduct.API.Controllers
{
    [Route("category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IApplicationServiceCategory applicationServiceCategory;

        public CategoryController(IApplicationServiceCategory applicationServiceCategory)
        {
            this.applicationServiceCategory = applicationServiceCategory;
        }

        // GET api/values
        [Route("v1/categorys")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> Index()
        {
            return Ok(await applicationServiceCategory.List());
        }

        // GET api/values/5
        [Route("v1/categorys/{id}")]
        [HttpGet]
        public async Task<ActionResult<CategoryDto>> Get(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var category = await applicationServiceCategory.GetEntityById((int)id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoryDto categoryDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return NotFound();

                await applicationServiceCategory.Add(categoryDto);
                return Ok("Categoria Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] CategoryDto categoryDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return NotFound();

                await applicationServiceCategory.Update(categoryDto);
                return Ok("Categoria Atualizada com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET: Categorys/Delete/5
        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] CategoryDto categoryDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return NotFound();

                await applicationServiceCategory.Delete(categoryDto);
                return Ok("Categoria removida com sucesso!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
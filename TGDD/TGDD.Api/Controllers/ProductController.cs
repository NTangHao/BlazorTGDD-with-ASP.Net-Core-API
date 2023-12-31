﻿using Microsoft.AspNetCore.Mvc;
using TGDD.Api.Entities;
using TGDD.Api.Extensions;
using TGDD.Api.Repositories.Contracts;
using TGDD.Models.Dtos;

namespace TGDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize] 
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private readonly ILogger<ProductController> _logger;


        public ProductController(IProductRepository productRepository, ILogger<ProductController> logger)
        {
            this.productRepository = productRepository;
            _logger = logger;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
            _logger.LogInformation("Make call to product list");

            try
            {
                //test Serilog seq
                //throw new NotImplementedException("Error in GetItems");
                var products = await this.productRepository.GetItems();

                if (products == null)
                {
                    return NotFound();
                }
                else
                {
                    var productDtos = products.ConvertToDto();

                    return Ok(productDtos);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetItems test");
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }



        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductDto>> GetItem(int id)
        {
            try
            {
                if (id < 0)
                {
                    return BadRequest();
                }
                var product = await this.productRepository.GetItem(id);

                if (product == null)
                {
                    return NotFound();
                }
                else
                {

                    var productDto = product.ConvertToDto();

                    return Ok(productDto);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }

        [HttpGet]
        [Route(nameof(GetProductCategories))]
        public async Task<ActionResult<IEnumerable<ProductCategoryDto>>> GetProductCategories()
        {
            try
            {
                var productCategories = await productRepository.GetCategories();



                if (productCategories == null)
                {
                    return NotFound();
                }
                else
                {
                    var productCategoryDtos = productCategories.ConvertToDto();
                    return Ok(productCategoryDtos);
                }



            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }

        }

        [HttpGet]
        [Route("GetCategory/{categoryId}")]
        public async Task<ActionResult<ProductCategory>> GetCategory(int categoryId)
        {
            try
            {
                var categories = await productRepository.GetCategory(categoryId);

                if (categories == null)
                {
                    return NotFound();
                }
                else
                {
                    var productDtos = categories.ConvertToDto();

                    return Ok(productDtos);
                }



            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }

        [HttpGet]
        [Route("{categoryId}/GetItemsByCategory")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItemsByCategory(int categoryId)
        {
            try
            {
                var products = await productRepository.GetItemsByCategory(categoryId);

                var productDtos = products.ConvertToDto();

                return Ok(productDtos);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }

        [HttpGet]
        [Route("search/{key}")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> SearchProduct(string key)
        {
            try
            {

                var products = await productRepository.SearchProduct(key);
                var productDtos = products.ConvertToDto();
                return Ok(productDtos);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }
    }
}

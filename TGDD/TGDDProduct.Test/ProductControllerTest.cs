using AutoFixture;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using TGDD.Api.Controllers;
using TGDD.Api.Entities;
using TGDD.Api.Repositories.Contracts;
namespace TGDDProduct.Test
{
    public class ProductControllerTest



    {
        private readonly IFixture _fixture;
        private readonly Mock<IProductRepository> _productRepository;
        private readonly Mock<ILogger<ProductController>> _logger;
        private readonly ProductController _productController;

        public ProductControllerTest()
        {
            _fixture = new Fixture();
            //_productRepository = new Mock<IProductRepository>();
            _productRepository = _fixture.Freeze<Mock<IProductRepository>>();
            _logger = new Mock<ILogger<ProductController>>();
            _productController = new ProductController(_productRepository.Object, _logger.Object);
        }

        [Fact]
        public async Task GetProductItems_ShouldReturnOkResponse_WhenDataFound()
        {

            // Arrange

            var products = _fixture.Create<IEnumerable<Product>>();
            _productRepository.Setup(x => x.GetItems()).ReturnsAsync(products.AsEnumerable());

            // Act
            var result = await _productController.GetItems();

            // Assert

            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<OkObjectResult>();
            _productRepository.Verify(x => x.GetItems(), Times.Once);

        }

        [Fact]
        public async Task GetProductItems_ShouldReturnNotFoundResponse_WhenDataNotFound()
        {
            // Arrange
            _productRepository.Setup(x => x.GetItems()).ReturnsAsync((IEnumerable<Product>)null);

            // Act
            var result = await _productController.GetItems();

            // Assert
            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<NotFoundResult>();
            _productRepository.Verify(x => x.GetItems(), Times.Once);
        }

        [Fact]
        public async Task GetProductById_ShouldReturnOk_WhenValidInput()
        {
            // Arrange
            var product = _fixture.Create<Product>();
            var id = _fixture.Create<int>();

            _productRepository.Setup(x => x.GetItem(id)).ReturnsAsync(product);

            // Act
            var result = await _productController.GetItem(id);

            // Assert
            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<OkObjectResult>();
            _productRepository.Verify(x => x.GetItem(id), Times.Once);
        }

        [Fact]
        public async Task GetProductById_ShouldReturnBadRequest_WhenInputIsLessThanZero()
        {
            // Arrange
            var id = _fixture.Create<int>();
            id = -1;

            // Act
            var result = await _productController.GetItem(id);

            // Assert
            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<BadRequestResult>();
            _productRepository.Verify(x => x.GetItem(id), Times.Never);
        }


        [Fact]
        public async Task GetProductById_ShouldReturnNotFound_WhenDataNotFound()
        {
            // Arrange
            var id = _fixture.Create<int>();

            _productRepository.Setup(x => x.GetItem(id)).ReturnsAsync((Product)null);

            // Act
            var result = await _productController.GetItem(id);

            // Assert
            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<NotFoundResult>();
            _productRepository.Verify(x => x.GetItem(id), Times.Once);
        }

        [Fact]
        public async Task GetProductCategories_ShouldReturnOk_WhenDataFound()
        {
            // Arrange
            var productCategories = _fixture.Create<IEnumerable<ProductCategory>>();
            _productRepository.Setup(x => x.GetCategories()).ReturnsAsync(productCategories.AsEnumerable());

            // Act
            var result = await _productController.GetProductCategories();

            // Assert
            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<OkObjectResult>();
            _productRepository.Verify(x => x.GetCategories(), Times.Once);
        }

        [Fact]
        public async Task GetProductCategories_ShouldReturnNotFound_WhenDataNotFound()
        {
            // Arrange
            List<ProductCategory> productCategories = null;

            _productRepository.Setup(x => x.GetCategories()).ReturnsAsync(productCategories);

            // Act
            var result = await _productController.GetProductCategories();

            // Assert
            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<NotFoundResult>();
            _productRepository.Verify(x => x.GetCategories(), Times.Once);

        }

        [Fact]
        public async Task GetCategoryById_ShouldReturnOk_WhenDataFound()
        {
            // Arrange
            var productCategory = _fixture.Create<ProductCategory>();
            var id = _fixture.Create<int>();

            _productRepository.Setup(x => x.GetCategory(id)).ReturnsAsync(productCategory);

            // Act
            var result = await _productController.GetCategory(id);

            // Assert
            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<OkObjectResult>();
            _productRepository.Verify(x => x.GetCategory(id), Times.Once);
        }

        [Fact]
        public async Task GetCategoryById_ShouldReturnNotFound_WhenDataNotFound()
        {
            // Arrange
            var id = _fixture.Create<int>();

            _productRepository.Setup(x => x.GetCategory(id)).ReturnsAsync((ProductCategory)null);

            // Act
            var result = await _productController.GetCategory(id);

            // Assert
            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<NotFoundResult>();
            _productRepository.Verify(x => x.GetCategory(id), Times.Once);
        }

        [Fact]
        public async Task GetItemsByCategoryId_ShouldReturnOk_WhenDataFound()
        {
            // Arrange
            var products = _fixture.Create<IEnumerable<Product>>();
            var categoryId = _fixture.Create<int>();

            _productRepository.Setup(x => x.GetItemsByCategory(categoryId)).ReturnsAsync(products.AsEnumerable());

            // Act
            var result = await _productController.GetItemsByCategory(categoryId);

            // Assert
            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<OkObjectResult>();
            _productRepository.Verify(x => x.GetItemsByCategory(categoryId), Times.Once);
        }

        [Fact]
        public async Task GetItemsBySearchKey_ShouldReturnOk_WhenDataFound()
        {
            // Arrange
            var products = _fixture.Create<IEnumerable<Product>>();
            var key = _fixture.Create<string>();
            _productRepository.Setup(x => x.SearchProduct(key)).ReturnsAsync(products.AsEnumerable());

            // Act
            var result = await _productController.SearchProduct(key);

            // Assert
            result.Should().NotBeNull();
            result.Result.Should().BeAssignableTo<OkObjectResult>();
            _productRepository.Verify(x => x.SearchProduct(key), Times.Once);

        }
    }
}
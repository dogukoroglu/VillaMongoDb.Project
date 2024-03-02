using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.ProductDto;
using Villa.Entity.Entities;

namespace Villa.WebUI.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductService _productService;
		private readonly IMapper _mapper;
		public ProductController(IProductService productService, IMapper mapper)
		{
			_productService = productService;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _productService.TGetListAsync();
			var ProductList = _mapper.Map<List<ResultProductDto>>(values);
			return View(ProductList);
		}

		public async Task<IActionResult> DeleteProduct(ObjectId id)
		{
			await _productService.TDeleteAsync(id);
			return RedirectToAction("Index");
		}

		public IActionResult CreateProduct()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
		{
			var newProduct = _mapper.Map<Product>(createProductDto);
			await _productService.TCreateAsync(newProduct);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> UpdateProduct(ObjectId id)
		{
			var value = await _productService.TGetByIdAsync(id);
			var updataProduct = _mapper.Map<UpdateProductDto>(value);
			return View(updataProduct);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
		{
			var Product = _mapper.Map<Product>(updateProductDto);
			await _productService.TUpdateAsync(Product);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> ProductDetails(ObjectId id)
		{
			var value = await _productService.TGetByIdAsync(id);
			var productValue = _mapper.Map<ResultProductDto>(value);
			return View(productValue);
		}
	}
}

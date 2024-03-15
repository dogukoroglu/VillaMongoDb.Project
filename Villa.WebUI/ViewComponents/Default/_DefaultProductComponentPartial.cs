using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.ProductDto;

namespace Villa.WebUI.ViewComponents.Default
{
    public class _DefaultProductComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public _DefaultProductComponentPartial(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.TGetListAsync();
            var productList = _mapper.Map<List<ResultProductDto>>(values);
            return View(productList);
        }
    }
}

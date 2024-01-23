using AutoMapper;
using DotnetYuzuncuYil.Core.DTOs;
using DotnetYuzuncuYil.Core.Models;
using DotnetYuzuncuYil.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYil.API.Controllers
{
    public class CategoryController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        public CategoryController(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var category = await _categoryService.GetAllAsycnc();
            var categoryDto = _mapper.Map<List<CategoryDto>>(category.ToList());
            return CreateActionResult(GlobalResultDto<List<CategoryDto>>.Success(200, categoryDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetById(id);
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return CreateActionResult(GlobalResultDto<CategoryDto>.Success(200, categoryDto));
        }
        [HttpPost]
        public async Task<IActionResult> Save(Category categoryDto)
        {
            var category = await _categoryService.AddAsync(_mapper.Map<Category>(categoryDto));
            var categoryDtos = _mapper.Map<CategoryDto>(category);
            return CreateActionResult(GlobalResultDto<CategoryDto>.Success(201, categoryDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CategoryDto categoryDto)
        {
            await _categoryService.UpdateAsync(_mapper.Map<Category>(categoryDto));
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var user = await _categoryService.GetById(id);
            await _categoryService.RemoveAsync(user);

            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }

    }
}

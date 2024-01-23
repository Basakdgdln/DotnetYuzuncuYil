using AutoMapper;
using DotnetYuzuncuYil.Core.DTOs;
using DotnetYuzuncuYil.Core.Models;
using DotnetYuzuncuYil.Core.Services;
using DotnetYuzuncuYil.Service.Validations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYil.API.Controllers
{
  
    public class BlogController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IBlogService _blogService;
        public BlogController(IMapper mapper, IBlogService blogService)
        {
            _mapper = mapper;
            _blogService = blogService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var blog = await _blogService.GetAllAsycnc();
            var blogDto = _mapper.Map<List<BlogDto>>(blog.ToList());
            return CreateActionResult(GlobalResultDto<List<BlogDto>>.Success(200, blogDto));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var blog = await _blogService.GetById(id);
            var blogDto = _mapper.Map<BlogDto>(blog);
            return CreateActionResult(GlobalResultDto<BlogDto>.Success(200, blogDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(BlogDto blogDto)
        {
            var blog = await _blogService.AddAsync(_mapper.Map<Blog>(blogDto));
            var blogDtos = _mapper.Map<BlogDto>(blog);
            return CreateActionResult(GlobalResultDto<BlogDto>.Success(201, blogDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(BlogDto blogDto)
        {
            await _blogService.UpdateAsync(_mapper.Map<Blog>(blogDto));
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var team = await _blogService.GetById(id);
            await _blogService.RemoveAsync(team);

            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }
    }
}

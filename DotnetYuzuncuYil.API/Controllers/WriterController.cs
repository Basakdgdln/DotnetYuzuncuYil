﻿using AutoMapper;
using DotnetYuzuncuYil.Core.DTOs;
using DotnetYuzuncuYil.Core.DTOs.Authentication;
using DotnetYuzuncuYil.Core.Models;
using DotnetYuzuncuYil.Core.Services;
using DotnetYuzuncuYil.Service.Authorization.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetYuzuncuYil.API.Controllers
{
    public class WriterController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IWriterService _writerService;

        public WriterController(IMapper mapper, IWriterService writerService)
        {
            _mapper = mapper;
            _writerService = writerService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var writer = await _writerService.GetAllAsycnc();
            var writerDto = _mapper.Map<List<WriterDto>>(writer.ToList());
            return CreateActionResult(GlobalResultDto<List<WriterDto>>.Success(200, writerDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var writer = await _writerService.GetById(id);
            var writerDto = _mapper.Map<WriterDto>(writer);
            return CreateActionResult(GlobalResultDto<WriterDto>.Success(200, writerDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(WriterDto writerDto)
        {
            await _writerService.UpdateAsync(_mapper.Map<Writer>(writerDto));
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var writer = await _writerService.GetById(id);
            await _writerService.RemoveAsync(writer);
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }

        [HttpPost("Signup")]
        public async Task<IActionResult> SignUp(AuthRequestDto authDto)
        {
            var writer = _writerService.SignUp(authDto);
            var writerDto = _mapper.Map<WriterDto>(writer);
            return CreateActionResult(GlobalResultDto<WriterDto>.Success(201, writerDto));
        }

        [HttpPost("Login")]
        public IActionResult Login(AuthRequestDto authDto)
        {
            var result = _writerService.Login(authDto);
            if (result.Writer != null)
                return CreateActionResult(GlobalResultDto<AuthResponseDto>.Success(200, result));
            else
                return CreateActionResult(GlobalResultDto<AuthResponseDto>.Success(401, result));
        }
    }
}

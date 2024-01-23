using AutoMapper;
using DotnetYuzuncuYil.Core.DTOs;
using DotnetYuzuncuYil.Core.DTOs.Authentication;
using DotnetYuzuncuYil.Core.Models;
using DotnetYuzuncuYil.Core.Repositories;
using DotnetYuzuncuYil.Core.Services;
using DotnetYuzuncuYil.Core.UnitOfWorks;
using DotnetYuzuncuYil.Service.Authorization.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Services
{
    public class WriterService : Service<Writer>, IWriterService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Writer> _repository;
        private readonly IWriterRepository _writerRepository;
        private readonly IJwtAuthenticationManager _jwtAuthenticationManager;

        public WriterService(IGenericRepository<Writer> repository, IUnitOfWork unitOfWork, IMapper mapper, IJwtAuthenticationManager jwtAuthenticationManager,
            IWriterRepository writerRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _repository = repository;
            _jwtAuthenticationManager = jwtAuthenticationManager;
            _writerRepository = writerRepository;
        }
        public string GeneratePasswordHash(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentNullException(nameof(userName));
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException(nameof(userName));
            }

            byte[] userBytes = Encoding.UTF8.GetBytes(userName);
            string userByteString = Convert.ToBase64String(userBytes);
            string smallByteString = $"{userByteString.Take(2)}.{userByteString.Reverse().Take(2)}";
            byte[] smallBytes = Encoding.UTF8.GetBytes(smallByteString);
            byte[] passBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashed = this.GenerateSaltedHash(passBytes, smallBytes);
            return Convert.ToBase64String(hashed);
        }


        private byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }

        public WriterDto FindWriter(string userName, string password)
        {
            string passHashed = GeneratePasswordHash(userName, password);
            var writer = _repository.Where(x => x.UserName == userName && x.Password == passHashed).FirstOrDefault();
            var writerDto = _mapper.Map<WriterDto>(writer);
            return writerDto;
        }

        public AuthResponseDto Login(AuthRequestDto request)
        {
            AuthResponseDto responseDto = new AuthResponseDto();
            WriterDto writer = FindWriter(request.UserName, request.Password);
            responseDto = _jwtAuthenticationManager.Authenticate(request.UserName, request.Password);
            responseDto.Writer = writer;
            return responseDto;
        }
        public Writer SignUp(AuthRequestDto authdto)
        {
            var passwordHash = GeneratePasswordHash(authdto.UserName, authdto.Password);
            var writer = AddAsync(new Writer
            {
                Email = authdto.Email,
                Password = passwordHash,
                Name = "Ege",
                Surname = "Dumanlı",
                UserName = authdto.UserName
            });
            return writer.Result;
        }
    }
}
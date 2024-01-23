using DotnetYuzuncuYil.Core.DTOs;
using DotnetYuzuncuYil.Core.DTOs.Authentication;
using DotnetYuzuncuYil.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Services
{
    public interface IWriterService : IService<Writer>
    { 
        string GeneratePasswordHash(string userName, string password);
        WriterDto FindWriter(string userName, string password);
        AuthResponseDto Login(AuthRequestDto request);
        Writer SignUp(AuthRequestDto authDto);

    }
}

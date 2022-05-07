using MyOnionApi.Application.Interfaces;
using System;

namespace MyOnionApi.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
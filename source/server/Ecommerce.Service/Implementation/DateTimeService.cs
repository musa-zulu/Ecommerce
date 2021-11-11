using System;
using Ecommerce.Service.Contracts;

namespace Ecommerce.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
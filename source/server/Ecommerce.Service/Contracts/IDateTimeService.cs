using System;

namespace Ecommerce.Service.Contracts
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}

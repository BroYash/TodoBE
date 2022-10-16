using TodoBE.Application.Common.Interfaces;

namespace TodoBE.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}

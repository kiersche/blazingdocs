using blazingdocs.Domain;
using System;

namespace blazingdocs.ApplicationServices
{
    internal class DateTimeProvider : IDateTimeProvider
    {
        public DateTime Now => DateTime.Now;

        public DateOnly Today => DateOnly.FromDateTime(Now);
    }
}

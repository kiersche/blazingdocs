using System;

namespace blazingdocs.Domain;

public interface IDateTimeProvider
{
    DateTime Now { get; }

    DateOnly Today { get; }
}

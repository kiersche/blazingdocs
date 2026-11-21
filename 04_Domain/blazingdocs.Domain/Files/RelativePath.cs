using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace blazingdocs.Domain;

public sealed record RelativePath
{
    public string Value { get; }

    public RelativePath(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
        foreach (string segment in value.Split('/'))
        {
            if (segment.Length == 0 || segment.EndsWith('.') || segment.EndsWith(' ') ||
                WindowsDeviceName.IsMatch(segment) ||
                segment.Any(c => char.IsControl(c) || "\\:\"<>|?*".Contains(c)))
            {
                throw new ArgumentException("Expected a relative storage path with '/' between file or directory names.", nameof(value));
            }
        }

        Value = value;
    }

    private static readonly Regex WindowsDeviceName = new(
        @"^(CON|PRN|AUX|NUL|CONIN\$|CONOUT\$|(?:COM|LPT)[0-9¹²³]) *(?:\.|$)",
        RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
}

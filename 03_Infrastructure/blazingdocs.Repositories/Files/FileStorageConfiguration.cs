using System.IO;
using blazingdocs.Domain;

namespace blazingdocs.Repositories.Files;

public class FileStorageConfiguration
{
    public string StorageRootPath { get; set; } = string.Empty;

    internal string Resolve(RelativePath path)
    {
        // GetFullPath requires an absolute base. RelativePath allows only child segments.
        string destination = Path.GetFullPath(path.Value, StorageRootPath);
        string current = StorageRootPath;
        foreach (string segment in path.Value.Split('/'))
        {
            current = Path.Combine(current, segment);
            var attributes = new FileInfo(current).Attributes;
            if (attributes != (FileAttributes)(-1) && attributes.HasFlag(FileAttributes.ReparsePoint))
            {
                throw new IOException($"Storage path contains a filesystem link: {current}");
            }
        }

        return destination;
    }
}

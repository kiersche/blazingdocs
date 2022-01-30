using blazingdocs.Domain;
using blazingdocs.Domain.Files;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Threading.Tasks;

namespace blazingdocs.Repositories.Files
{
    internal class FileRepository : IFileRepository
    {
        private readonly string storageRootPath;
        private readonly IDateTimeProvider dateTimeProvider;

        public FileRepository(IOptions<FileStorageConfiguration> options, IDateTimeProvider dateTimeProvider)
        {
            storageRootPath = options.Value.StorageRootPath;
            this.dateTimeProvider = dateTimeProvider;
        }

        public async Task<RelativePath> StoreFile(IFormFile file)
        {
            string relativeDestinationDirectory = GetRelativeDestinationDirectory();
            string fullDestinationDirectory = Path.Combine(storageRootPath, relativeDestinationDirectory);

            string destinationFilename = GetDestinationFilename(relativeDestinationDirectory);
            string relativeDestinationPath = Path.Combine(relativeDestinationDirectory, destinationFilename);
            string fullDestinationPath = Path.Combine(storageRootPath, relativeDestinationPath);

            Directory.CreateDirectory(fullDestinationDirectory);
            await using FileStream fileStream = new(fullDestinationPath, FileMode.CreateNew);
            await fileStream.CopyToAsync(fileStream);

            return new RelativePath(relativeDestinationPath);
        }

        private string GetDestinationFilename(string relativeDirectory)
        {
            string filename = Path.GetRandomFileName();
            string relativeDestinationPath = Path.Combine(relativeDirectory, filename);

            while (System.IO.File.Exists(Path.Combine(storageRootPath, relativeDestinationPath)))
            {
                filename = Path.GetRandomFileName();
                relativeDestinationPath = Path.Combine(relativeDirectory, filename);
            }

            return filename;
        }

        private string GetRelativeDestinationDirectory()
        {
            DateOnly today = dateTimeProvider.Today;
            return Path.Combine(
                today.Year.ToString("D"),
                today.Month.ToString("D2"),
                today.Day.ToString("D2"));
        }
    }
}

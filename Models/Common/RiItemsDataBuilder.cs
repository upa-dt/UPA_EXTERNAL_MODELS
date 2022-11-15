using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA_EXTERNAL_MODELS.Models.Common
{
    public class RiItemsDataBuilder
    {
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".PNG" };

        public static RiItemsData Build(int ri, List<int> refusedItems, List<string> InvoiceImagePaths, List<string> RiImagePaths)
        {
            if (InvoiceImagePaths == null || RiImagePaths == null || InvoiceImagePaths.Count < 1 || RiImagePaths.Count < 1)
                return null;
            if (InvalidFileExtension(InvoiceImagePaths) || InvalidFileExtension(RiImagePaths))
                return null;
            List<FormFile> fileArray = new List<FormFile>();
            int c = 0;
            InvoiceImagePaths.ForEach(file =>
                fileArray.Add(BuildFormFileFromFilePath(file, $"inv_{(c++)}")));
            c = 0;
            RiImagePaths.ForEach(file =>
                fileArray.Add(BuildFormFileFromFilePath(file, $"doc_{(c++)}")));
            return new RiItemsData
            {
                InvoiceID = ri,
                Files = fileArray.ToArray(),
                RefusedItems = refusedItems,
            };
        }
        public static FormFile BuildFormFileFromFilePath(string FilePath, string FileName)
        {
            using (var stream = File.OpenRead(FilePath))
                return BuildFormFileFromStream(stream, FileName, "image/" + Path.GetExtension(FilePath).TrimStart('.').ToLower());
        }
        public static FormFile BuildFormFileFromStream(Stream stream, string FileName, string contentType)
        {
            return new FormFile(stream, 0, stream.Length, null, FileName)
            {
                Headers = new HeaderDictionary(),
                ContentType = contentType
            };
        }
        public static bool InvalidFileExtension(List<string> files)
        {
            foreach (var f in files)
                if (!ImageExtensions.Contains(Path.GetExtension(f).ToUpperInvariant()))
                    return true;
            return false;
        }
    }
}

/*
using (var stream = File.OpenRead("placeholder.pdf"))
{
    var file = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name))
    {
        Headers = new HeaderDictionary(),
        ContentType = "application/pdf"
    };
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using RecipesProject.Models;

namespace RecipesProject.Handler
{
    public class FileUploadHandler
    {
        private static string GetUniqueFileName(string origFileName)
            => string.Format($"{Guid.NewGuid()}{Path.GetExtension(origFileName)}");

        public static async void SaveUploadFileToDiskAsync(Recipe product)
        {
            PopulatePicturePath(product);
            using (var fileStream = new FileStream(WebRoot.WebRootPath + product.PhotoPath, FileMode.Create))
            {
                await product.Picture.CopyToAsync(fileStream);
            }
        }

        private static void PopulatePicturePath(Recipe product)
        {
            product.PhotoPath = "/images/" + GetUniqueFileName(product.Picture.FileName);
        }
    }
}

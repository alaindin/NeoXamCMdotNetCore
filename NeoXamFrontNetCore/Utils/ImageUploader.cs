using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Utils
{
    public static class ImageUploader
    {
        
        public static async Task<string> UploadAsync(IFormFile fichier,string path)
        {

            try
            {
                // si le fichier n'est pas vide
                if (fichier.Length > 0)
                {
                    // Nom de fichier
                    string FileName = Path.GetFileName(fichier.FileName);
                    // Chemin d'upload ( s'il n'existe pas , on le crée )
                   
                    // uploader le fichier dans le chemin
                    //fichier.SaveAs(path + FileName);
                    using (var fileStream = new FileStream(path + FileName, FileMode.Create))
                    {
                        await fichier.CopyToAsync(fileStream);
                    }
                    return path + FileName;
                }
                return null;

            }
            catch (Exception)
            {
                return null;
                throw;

            }

        }
    }
}

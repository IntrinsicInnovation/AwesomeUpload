using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeUpload.Models
{
    public class UploadViewModel
    {
      

        public string FirstName { get; set; }
        public string LastName { get; set; }
     
        public string UserName { get; set; }
        public IEnumerable<IFormFile> files { get; set; }
        public IFormFile File { get; set; }
        public byte[] Image { get; set; }
        public string Image64 { get { return Image != null ? Convert.ToBase64String(Image) : null; } }

        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public long FileSize { get; set; }
        public bool PerformDelete { get; set; }
       
    }



}

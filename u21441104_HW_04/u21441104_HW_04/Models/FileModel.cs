using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace myMedia.Models
{
    public class FileModel
    {
        [Display(Name = "File Name")]
        public string FileName { get; set; }
    }
}
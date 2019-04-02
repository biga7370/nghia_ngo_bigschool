using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        [Display (Name="Địa điểm")]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        [Display(Name = "Ngày")]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        [Display(Name = "Giờ")]
        public string Time { get; set; }
        [Required]
        [Display(Name = "Danh sách")]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(String.Format("{0} {1}", Date, Time));
        }
    }
}
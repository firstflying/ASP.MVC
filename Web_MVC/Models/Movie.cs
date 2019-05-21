using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
//using Microsoft.EntityFrameworkCore;



namespace Web_MVC.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name ="标题")]
        public string Title { get; set; }

        [Display(Name ="日期")]//自定义属性显示的名称
        [DataType(DataType.Date)]//只显示日期
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}",ApplyFormatInEditMode =true)]//显示的格式
        public DateTime ReleaseDate { get; set; }
        
        [Display(Name ="类型")]
        public string Genre { get; set; }

        [Display(Name ="价格")]
        public decimal Price { get; set; }
    }
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movie { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{

        //}
    }

     
}
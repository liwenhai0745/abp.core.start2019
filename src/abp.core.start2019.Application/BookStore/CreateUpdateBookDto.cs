using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.AutoMapper;

namespace abp.core.start2019.BookStore
{
    /// <summary>
    /// 
    /// 这个DTO类在创建和更新书籍的时候被使用,用来从页面获取图书信息.
    /// </summary>
    [AutoMapTo(typeof(Book))]
    [AutoMapFrom(typeof(BookDto))]
    public class CreateUpdateBookDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }


        [Required]
        public DateTime PublishDate { get; set; }

        [Required]
        public float Price { get; set; }
    }
}

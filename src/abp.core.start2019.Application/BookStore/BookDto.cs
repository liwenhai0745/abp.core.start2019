using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AutoMapper;

namespace abp.core.start2019.BookStore
{
    /// <summary>
    /// [AutoMapFrom(typeof(Book))]用来创建从Book类到BookDto的映射.使用这种方法.你可以将Book对象自动转换成BookDto对象(而不是手动复制所有的属性).
    /// 为了在页面上展示书籍信息,BookDto被用来将书籍数据传递到基础设施层.
    /// </summary>
    [AutoMapFrom(typeof(Book))]
    public class BookDto:AuditedEntityDto<int>
    {
        public string Name { get; set; }


        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}

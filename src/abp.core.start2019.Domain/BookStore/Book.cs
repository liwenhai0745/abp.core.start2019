using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace abp.core.start2019.BookStore
{
    
    /// <summary>
    /// 
    /// AuditedAggregateRoot类在AggregateRoot类的基础上添加了(CreationTime, CreatorId, LastModificationTime
    /// </summary>
    [Table("Books")]
    public class Book:AuditedAggregateRoot<int>
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }


        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}

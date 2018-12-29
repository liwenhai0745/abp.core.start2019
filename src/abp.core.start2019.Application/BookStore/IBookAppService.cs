using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace abp.core.start2019.BookStore
{
    /// <summary>
    /// 
    /// 为应用服务定义接口不是必须的,不过,我们推荐这么做.
    ///IAsyncCrudAppService中定义了基础的 CRUD方法:GetAsync, GetListAsync, CreateAsync, UpdateAsync 和 DeleteAsync.不需要扩展它.取而代之,你可以继承空的IApplicationService接口定义你自己的方法.
    ///IAsyncCrudAppService有一些变体,你可以为每一个方法使用单个或者多个的DTO.(译者注:意思是类似EntityDto和UpdateEntityDto可以用同一个,也可以分别单独指定 )
    /// </summary>
    public interface IBookAppService :
         IAsyncCrudAppService< //定义了CRUD方法
             BookDto, //用来展示书籍
             int, //Book实体的主键
             PagedAndSortedResultRequestDto, //获取书籍的时候用于分页和排序
             CreateUpdateBookDto, //用于创建书籍
             CreateUpdateBookDto> //用户更新书籍
    {
        
    }
}

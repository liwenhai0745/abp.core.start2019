using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace abp.core.start2019.BookStore
{
    public class BookAppService :
        AsyncCrudAppService<Book, BookDto, int, PagedAndSortedResultRequestDto,
                            CreateUpdateBookDto, CreateUpdateBookDto>,
        IBookAppService
    {
        public BookAppService(IRepository<Book, int> repository)
            : base(repository)
        {

        }
    }
}

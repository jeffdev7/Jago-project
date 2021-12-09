using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JagoSystem.Models
{
    public class Page<T>: List<T>
    {
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }

        public Page(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
        }
        public bool PreviousPage
        {
            get { return (PageIndex > 1); }
        }
        public bool NextPage
        {
            get { return (PageIndex < TotalPages); }
        }

        public static async Task<Page<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize) 
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex -1)* pageSize).Take(pageSize).ToListAsync();
            return new Page<T>(items, count, pageIndex, pageSize);
        }

    }
}

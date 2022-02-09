using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RetailStore.Shared.Domain;

namespace RetailStore.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Order> Creates { get; }
        IGenericRepository<Checkout> Checkouts { get; }
        IGenericRepository<Item> Items { get; }
        IGenericRepository<Customer> Customers { get; }
    }
}
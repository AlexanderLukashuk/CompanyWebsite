
using System;
using CompanyWebsiteLibrary.Data.Repositories.Abstract;
using CompanyWebsiteLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace CompanyWebsiteLibrary.Data.Repositories.EntityFramework
{
	public class EFServiceItemsRepository : IServiceItemsREpository
    {
        private readonly AppDbContext context;

		public EFServiceItemsRepository(AppDbContext ctx)
		{
            context = ctx;
		}

        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItems.Remove(new ServiceItem() { Id = id });
            context.SaveChanges();
        }

        public ServiceItem GetServiceItemById(Guid id)
        {
            return context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItems;
        }

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}


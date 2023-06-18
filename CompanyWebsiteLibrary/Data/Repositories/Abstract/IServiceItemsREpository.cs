using System;
using CompanyWebsiteLibrary.Entities;

namespace CompanyWebsiteLibrary.Data.Repositories.Abstract
{
	public interface IServiceItemsREpository
	{
		IQueryable<ServiceItem> GetServiceItems();
		ServiceItem GetServiceItemById(Guid id);
		void SaveServiceItem(ServiceItem entity);
		void DeleteServiceItem(Guid id);
	}
}


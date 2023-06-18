using System;
using CompanyWebsiteLibrary.Data.Repositories.Abstract;

namespace CompanyWebsiteLibrary.Data
{
	public class DataManager
	{
		public ITextFieldsRepository? TextFields { get; set; }
		public IServiceItemsREpository? ServiceItems { get; set; }

		public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsREpository serviceItemsREpository)
		{
			TextFields = textFieldsRepository;
			ServiceItems = serviceItemsREpository;
		}
	}
}


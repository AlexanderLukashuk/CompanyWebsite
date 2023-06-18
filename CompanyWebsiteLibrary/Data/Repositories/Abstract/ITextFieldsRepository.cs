using System;
using CompanyWebsiteLibrary.Entities;

namespace CompanyWebsiteLibrary.Data.Repositories.Abstract
{
	public interface ITextFieldsRepository
	{
		IQueryable<TextField> GetTextFields();
		TextField GetTextFieldById(Guid id);
		TextField GetTextFieldByCodeWord(string codeWord);
		void SaveTextField(TextField entity);
		void DeleteTextField(Guid id);
	}
}


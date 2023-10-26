using Resume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.RepositoryInterface
{
	public interface IContactUsRepository
	{
		Task AddContactUsToDB(ContactUs contactUs);
	}
}

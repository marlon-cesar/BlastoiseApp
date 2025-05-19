using BlastoiseApp.Domain.DTOs.Contacts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlastoiseApp.Web.Controllers
{
	public class ContactController : Controller
	{

		private readonly IContactService _contactService;

		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> SendContact(CreateContactDTO model)
		{
			await _contactService.CreateAsync(model);
			return RedirectToAction("Index");
		}

	}

}

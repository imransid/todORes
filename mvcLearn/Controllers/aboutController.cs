using System;
using Microsoft.AspNetCore.Mvc;
namespace mvcLearn.Controllers
{
	[Route("about")]
	public class aboutController
	{
		[Route("")]
        public string Phone()
        {
	        return "0131440551";        
        }


		[Route("address")]
		public string Address()
		{
            return "Agargaw";
        }

        public aboutController()
		{
			
		}

	}
}



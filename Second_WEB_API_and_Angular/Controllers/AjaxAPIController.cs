using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Second_WEB_API_and_Angular.Service;
using Second_WEB_API_and_Angular.Models;

namespace Second_WEB_API_and_Angular.Controllers
{
    public class AjaxAPIController : ApiController
    {
        [Route("api/AjaxAPI/AjaxMethod")]
        [HttpPost]
        public List<Customer>AjaxMethod(CustomerModel customer)
        {
            var service = new CustomerList();
            return service.GetCustomers(customer.Name);
        }
    }
}

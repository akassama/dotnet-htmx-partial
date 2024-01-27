using HtmxPartial.Models;
using Microsoft.AspNetCore.Mvc;

namespace HtmxPartial.Controllers
{
    public class HtmxController : Controller
    {
        [HttpPost("htmx/get-selected-partial")]
        public IActionResult GetPartial(FormModel formModel)
        {

            if (!string.IsNullOrEmpty(formModel.SelectInput))
            {
                var partialSelected = formModel.SelectInput.ToLower() == "one" ? "_InputOnePartial" : "_InputTwoPartial";

                return new PartialViewResult
                {
                    ViewName = $"Partials/{partialSelected}"
                };
            }

            return Ok();
        }
    }
}

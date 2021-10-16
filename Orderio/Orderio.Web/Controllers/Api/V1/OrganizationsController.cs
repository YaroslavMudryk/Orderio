using Microsoft.AspNetCore.Mvc;

namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    public class OrganizationsController : ApiBaseController
    {
        [HttpGet]
        public IActionResult GetOrganizations(string q)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetOrganizationById(int id)
        {
            return Ok();
        }

        [HttpGet("{id}/departments")]
        public IActionResult GetOrganizationDepartments(int id)
        {
            return Ok();
        }

        [HttpGet("{id}/departments/{departmentId}")]
        public IActionResult GetDepartmentById(int id, int departmentId)
        {
            return Ok();
        }

        [HttpGet("{id}/departments/{departmentId}/products")]
        public IActionResult GetDepartmentProducts(int id, int departmentId)
        {
            return Ok();
        }
    }
}
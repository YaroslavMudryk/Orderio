using Microsoft.AspNetCore.Mvc;

namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    public class OrganizationsController : ApiBaseController
    {
        #region Organizations

        [HttpGet]
        public IActionResult GetOrganizations(string q)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateOrganization()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateOrganization()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveOrganization()
        {
            return Ok();
        }

        [HttpGet("{organizationId}")]
        public IActionResult GetOrganizationByorganizationId(int organizationId)
        {
            return Ok();
        }

        #endregion

        #region Departments

        [HttpPost("{organizationId}/departments")]
        public IActionResult CreateDepartment(int organizationId)
        {
            return Ok();
        }

        [HttpPut("{organizationId}/departments/{departmentId}")]
        public IActionResult UpdateDepartment(int organizationId, int departmentId)
        {
            return Ok();
        }

        [HttpDelete("{organizationId}/departments/{departmentId}")]
        public IActionResult RemoveDepartment(int organizationId, int departmentId)
        {
            return Ok();
        }

        [HttpGet("{organizationId}/departments")]
        public IActionResult GetOrganizationDepartments(int organizationId)
        {
            return Ok();
        }

        [HttpGet("{organizationId}/departments/{departmentId}")]
        public IActionResult GetDepartmentByorganizationId(int organizationId, int departmentId)
        {
            return Ok();
        }

        #endregion

        #region Products

        [HttpPost("{organizationId}/departments/{departmentId}/products")]
        public IActionResult CreateProduct(int organizationId, int departmentId)
        {
            return Ok();
        }

        [HttpPut("{organizationId}/departments/{departmentId}/products")]
        public IActionResult UpdateProduct(int organizationId, int departmentId)
        {
            return Ok();
        }

        [HttpGet("{organizationId}/departments/{departmentId}/products")]
        public IActionResult GetDepartmentProducts(int organizationId, int departmentId, int page = 1)
        {
            return Ok();
        }

        [HttpGet("{organizationId}/departments/{departmentId}/products/{productId}")]
        public IActionResult GetProductByorganizationId(int organizationId, int departmentId, long productId)
        {
            return Ok();
        }

        #endregion
    }
}
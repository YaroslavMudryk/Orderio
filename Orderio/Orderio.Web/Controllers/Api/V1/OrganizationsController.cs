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

        [HttpGet("{organizationorganizationId}")]
        public IActionResult GetOrganizationByorganizationId(int organizationorganizationId)
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

        [HttpPut("{organizationId}/departments/{departmentorganizationId}")]
        public IActionResult UpdateDepartment(int organizationId, int departmentorganizationId)
        {
            return Ok();
        }

        [HttpDelete("{organizationId}/departments/{departmentorganizationId}")]
        public IActionResult RemoveDepartment(int organizationId, int departmentorganizationId)
        {
            return Ok();
        }

        [HttpGet("{organizationId}/departments")]
        public IActionResult GetOrganizationDepartments(int organizationId)
        {
            return Ok();
        }

        [HttpGet("{organizationId}/departments/{departmentorganizationId}")]
        public IActionResult GetDepartmentByorganizationId(int organizationId, int departmentorganizationId)
        {
            return Ok();
        }

        #endregion

        #region Products

        [HttpPost("{organizationId}/departments/{departmentorganizationId}/products")]
        public IActionResult CreateProduct(int organizationId, int departmentorganizationId)
        {
            return Ok();
        }

        [HttpPut("{organizationId}/departments/{departmentorganizationId}/products")]
        public IActionResult UpdateProduct(int organizationId, int departmentorganizationId)
        {
            return Ok();
        }

        [HttpGet("{organizationId}/departments/{departmentorganizationId}/products")]
        public IActionResult GetDepartmentProducts(int organizationId, int departmentorganizationId, int page = 1)
        {
            return Ok();
        }

        [HttpGet("{organizationId}/departments/{departmentorganizationId}/products/{productorganizationId}")]
        public IActionResult GetProductByorganizationId(int organizationId, int departmentorganizationId, long productorganizationId)
        {
            return Ok();
        }

        #endregion
    }
}
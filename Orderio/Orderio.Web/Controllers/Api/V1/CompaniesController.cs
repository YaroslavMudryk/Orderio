using Microsoft.AspNetCore.Mvc;

namespace Orderio.Web.Controllers.Api.V1
{
    [ApiVersion("1.0")]
    public class CompaniesController : ApiBaseController
    {
        #region Companies

        [HttpGet]
        public IActionResult GetCompanies(string q)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateCompany()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCompany()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveCompany()
        {
            return Ok();
        }

        [HttpGet("{CompanyId}")]
        public IActionResult GetCompanyById(int CompanyId)
        {
            return Ok();
        }

        #endregion

        #region Departments

        [HttpPost("{CompanyId}/departments")]
        public IActionResult CreateDepartment(int CompanyId)
        {
            return Ok();
        }

        [HttpPut("{CompanyId}/departments/{departmentId}")]
        public IActionResult UpdateDepartment(int CompanyId, int departmentId)
        {
            return Ok();
        }

        [HttpDelete("{CompanyId}/departments/{departmentId}")]
        public IActionResult RemoveDepartment(int CompanyId, int departmentId)
        {
            return Ok();
        }

        [HttpGet("{CompanyId}/departments")]
        public IActionResult GetCompanyDepartments(int CompanyId)
        {
            return Ok();
        }

        [HttpGet("{CompanyId}/departments/{departmentId}")]
        public IActionResult GetDepartmentByCompanyId(int CompanyId, int departmentId)
        {
            return Ok();
        }

        #endregion

        #region Products

        [HttpPost("{CompanyId}/departments/{departmentId}/products")]
        public IActionResult CreateProduct(int CompanyId, int departmentId)
        {
            return Ok();
        }

        [HttpPut("{CompanyId}/departments/{departmentId}/products")]
        public IActionResult UpdateProduct(int CompanyId, int departmentId)
        {
            return Ok();
        }

        [HttpGet("{CompanyId}/departments/{departmentId}/products")]
        public IActionResult GetDepartmentProducts(int CompanyId, int departmentId, int page = 1)
        {
            return Ok();
        }

        [HttpGet("{CompanyId}/departments/{departmentId}/products/{productId}")]
        public IActionResult GetProductByCompanyId(int CompanyId, int departmentId, long productId)
        {
            return Ok();
        }

        #endregion
    }
}
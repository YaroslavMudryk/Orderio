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

        [HttpGet("{companyId}")]
        public IActionResult GetCompanyById(int companyId)
        {
            return Ok();
        }

        #endregion

        #region Departments

        [HttpPost("{companyId}/departments")]
        public IActionResult CreateDepartment(int companyId)
        {
            return Ok();
        }

        [HttpPut("{companyId}/departments/{departmentId}")]
        public IActionResult UpdateDepartment(int companyId, int departmentId)
        {
            return Ok();
        }

        [HttpDelete("{companyId}/departments/{departmentId}")]
        public IActionResult RemoveDepartment(int companyId, int departmentId)
        {
            return Ok();
        }

        [HttpGet("{companyId}/departments")]
        public IActionResult GetCompanyDepartments(int companyId)
        {
            return Ok();
        }

        [HttpGet("{companyId}/departments/{departmentId}")]
        public IActionResult GetDepartmentByCompanyId(int companyId, int departmentId)
        {
            return Ok();
        }

        #endregion

        #region Products

        [HttpPost("{companyId}/departments/{departmentId}/products")]
        public IActionResult CreateProduct(int companyId, int departmentId)
        {
            return Ok();
        }

        [HttpPut("{companyId}/departments/{departmentId}/products")]
        public IActionResult UpdateProduct(int companyId, int departmentId)
        {
            return Ok();
        }

        [HttpGet("{companyId}/departments/{departmentId}/products")]
        public IActionResult GetDepartmentProducts(int companyId, int departmentId, int page = 1)
        {
            return Ok();
        }

        [HttpGet("{companyId}/departments/{departmentId}/products/{productId}")]
        public IActionResult GetProductByCompanyId(int companyId, int departmentId, long productId)
        {
            return Ok();
        }

        #endregion
    }
}
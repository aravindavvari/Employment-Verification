using Employment_Verification.Data;
using Microsoft.AspNetCore.Mvc;

namespace Employment_Verification.Controllers
{
    public class EmploymentVerificationController : ControllerBase
        {
            private readonly EmployeeRepository _repository;

            public EmploymentVerificationController()
            {
                _repository = new EmployeeRepository();
            }

            [HttpPost("api/verify-employment")]
            public IActionResult VerifyEmployment([FromBody] EmployeeVerificationRequest request)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid data.");
                }

                var employee = _repository.VerifyEmployment(request.EmployeeId, request.CompanyName, request.VerificationCode);

                if (employee != null)
                {
                    return Ok(new { message = "Verified" });
                }

                return Ok(new { message = "Not Verified" });
            }
        }

        public class EmployeeVerificationRequest
        {
            public int EmployeeId { get; set; }
            public string CompanyName { get; set; }
            public string VerificationCode { get; set; }
        }

    }

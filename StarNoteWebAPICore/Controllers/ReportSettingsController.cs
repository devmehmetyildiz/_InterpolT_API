using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarNoteWebAPICore.DataAccess;
using StarNoteWebAPICore.Models;
using System.Security.Claims;

namespace StarNoteWebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportSettingsController : ControllerBase
    {
        private readonly ILogger<ReportSettingsController> _logger;
        private readonly StarNoteEntity _context;
        UnitOfWork unitOfWork;
        public ReportSettingsController(ILogger<ReportSettingsController> logger, StarNoteEntity context)
        {
            _logger = logger;
            _context = context;
            unitOfWork = new UnitOfWork(context);
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult CheckReports()
        {
            return Ok(unitOfWork.ReportsettingsRepository.GetAll().Where(u => u.IsActive).ToList());
        }

        [Route("Add")]
        [HttpPost]
        public bool Add(ReportsettingModel model)
        {
            bool IsAdded = false;
            var username = (this.User.Identity as ClaimsIdentity).FindFirst(ClaimTypes.Name)?.Value;
            model.CreatedUser = username;
            model.Createtime = DateTime.Now;
            model.IsActive = true;
            model.ConcurrencyStamp = Guid.NewGuid().ToString();
            unitOfWork.ReportsettingsRepository.Add(model);
            if (unitOfWork.Complate() > 0)
                IsAdded = true;
            return IsAdded;
        }
        [Route("Update")]
        [HttpPost]
        public bool Update(ReportsettingModel model)
        {
            bool Isupdated = false;
            var username = (this.User.Identity as ClaimsIdentity).FindFirst(ClaimTypes.Name)?.Value;
            model.UpdatedUser = username;
            model.Updatetime = DateTime.Now;
            unitOfWork.ReportsettingsRepository.update(unitOfWork.ReportsettingsRepository.Getbyid(model.Id), model);
            if (unitOfWork.Complate() > 0)
                Isupdated = true;
            return Isupdated;
        }
        [Route("Delete")]
        [HttpPost]
        public bool Delete(ReportsettingModel model)
        {
            bool IsDeleted = false;
            var username = (this.User.Identity as ClaimsIdentity).FindFirst(ClaimTypes.Name)?.Value;
            model.DeleteUser = username;
            model.Deletetime = DateTime.Now;
            model.IsActive = false;
            unitOfWork.ReportsettingsRepository.update(unitOfWork.ReportsettingsRepository.Getbyid(model.Id), model);
            if (unitOfWork.Complate() > 0)
                IsDeleted = true;
            return IsDeleted;
        }

    }
}

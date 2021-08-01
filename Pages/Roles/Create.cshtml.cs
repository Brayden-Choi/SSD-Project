using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using MIST.Models;

namespace MIST.Pages.Roles
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly MIST.Data.MISTDbContext _context;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public CreateModel(RoleManager<ApplicationRole> roleManager, MIST.Data.MISTDbContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ApplicationRole ApplicationRole { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ApplicationRole.CreatedDate = DateTime.UtcNow;
            ApplicationRole.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();

            IdentityResult roleRuslt = await _roleManager.CreateAsync(ApplicationRole);

            // Create an auditrecord object
            var auditrecord = new AuditRecord();
            auditrecord.AuditActionType = "Created new role";
            auditrecord.DateTimeStamp = DateTime.Now;
            auditrecord.RoleID = ApplicationRole.Name;

            // Get current logged-in user
            var userID = User.Identity.Name.ToString();
            auditrecord.Username = userID;

            _context.AuditRecords.Add(auditrecord);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}


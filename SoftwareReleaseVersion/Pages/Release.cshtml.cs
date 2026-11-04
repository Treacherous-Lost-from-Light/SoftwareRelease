using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using SoftwareReleaseVersion.Data;
using SoftwareReleaseVersion.Models;

namespace SoftwareReleaseVersion.Pages
{
    public class ReleaseModel : PageModel
    {
        private readonly AppDbContext _context;

        [BindProperty]
        public Release Release { get; set; } = new();
        public List<Release> Releases { get; set; } = new();
        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; }
        public ReleaseModel(AppDbContext context)
        {
            _context = context;
        }

        //Create
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid)
                return Page();
            _context.Releases.Add(Release);

            await _context.SaveChangesAsync();  
            return RedirectToPage("/Release");
        }
        //Read
        public async Task OnGetAsync()
        {
            IQueryable<Release> query = _context.Releases;

            if (!string.IsNullOrEmpty(SearchTerm))
            {
                query = query.Where(r => r.Version.Contains(SearchTerm) ||
                r.Description.Contains(SearchTerm) 
                );
            }
            Releases = await query.ToListAsync();
        } 
        
        //Update
        public async Task<IActionResult> OnPostUpdateStatusAsync(int id, string status)
        {
            var release = await _context.Releases.FindAsync(id);

            if (release == null)
                return NotFound();

            release.Status = status;

            await _context.SaveChangesAsync();
            return RedirectToPage("/Release");
        }
        //Delete
        public async Task<IActionResult> OnPostDeleteReleaseAsync(int id) {
            var release = await _context.Releases.FindAsync(id);

            if(release == null)
                return NotFound();

            _context.Releases.Remove(release);  

            await _context.SaveChangesAsync();
            return RedirectToPage("/Release");
        }
    }
}

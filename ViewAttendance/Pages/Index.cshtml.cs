using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ViewAttendance.Models;


namespace ViewAttendance.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _adb;
        public IndexModel(ApplicationDbContext adb)
        {
            _adb = adb;
        }
        public IEnumerable<AttendanceRecords> results { get; set; }
        
        public void OnGet()
        {
            results = _adb.TRAttendanceDetails.ToList();
        }
        public void OnPost(DateTime startdate , DateTime enddate)
        {
            results = (from x in _adb.TRAttendanceDetails where (x.AttedanceDate >= startdate) && (x.AttedanceDate <= enddate) select x).ToList();
        }
    }
}

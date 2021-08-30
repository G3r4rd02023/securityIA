using Microsoft.AspNetCore.Mvc.Rendering;
using SecurityIA.Data;
using System.Collections.Generic;

namespace SecurityIA.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _context;

        public CombosHelper(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<SelectListItem> GetComboRoles()
        {
            var list = new List<SelectListItem>
            {
                new SelectListItem { Value = "0", Text = "(Selecciona un rol...)" },
                new SelectListItem { Value = "1", Text = "Admin" },
                new SelectListItem { Value = "2", Text = "User" }
            };

            return list;
        }

       

    }
}

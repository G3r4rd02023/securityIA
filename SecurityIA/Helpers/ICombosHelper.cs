using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SecurityIA.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboRoles();
    }
}

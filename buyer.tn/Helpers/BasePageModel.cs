using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace buyer.tn.Helpers
{
    public class BasePageModel : PageModel
    {
        private DynamicViewData _viewBag;

        public dynamic ViewBag
        {
            get
            {
                if (_viewBag == null)
                {
                    _viewBag = new DynamicViewData(() => ViewData);
                }
                return _viewBag;
            }
            set 
            {
                value = _viewBag;
            }
        }
    }
}

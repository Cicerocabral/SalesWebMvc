using System;

namespace SalesWebMvc.Models.ViewModels
{/*teste*/
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
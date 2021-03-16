using System;

namespace Nutrition.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        /// <summary>
        /// //////
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

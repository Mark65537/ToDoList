using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using ToDoList21.Models;

namespace ToDoList21.Helpers
{
    public static class HtmlHelpers
    {
        public static IEnumerable<SelectListItem> updateModelSelectListItem(
            this IHtmlHelper htmlHelper,
            ProblemUpdateViewModel model)
        {
            var statusList = new List<SelectListItem>();

            switch (model.Status)
            {
                case ProblemStatus.CREATED:
                    statusList.Add(new SelectListItem { Text = ProblemStatus.CREATED.ToString() });
                    statusList.Add(new SelectListItem { Text = ProblemStatus.PROCESSING.ToString() });
                    break;
                case ProblemStatus.PROCESSING:
                    statusList.Add(new SelectListItem { Text = ProblemStatus.PROCESSING.ToString() });
                    statusList.Add(new SelectListItem { Text = ProblemStatus.PAUSED.ToString() });
                    statusList.Add(new SelectListItem { Text = ProblemStatus.DONE.ToString() });
                    break;
                case ProblemStatus.PAUSED:
                    statusList.Add(new SelectListItem { Text = ProblemStatus.PROCESSING.ToString() });
                    statusList.Add(new SelectListItem { Text = ProblemStatus.PAUSED.ToString() });
                    break;
                case ProblemStatus.DONE:
                    statusList.Add(new SelectListItem { Text = ProblemStatus.DONE.ToString() });
                    break;
                default:
                    break;
            }

            return statusList;
        }
    }
}

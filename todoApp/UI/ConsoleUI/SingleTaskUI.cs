using Entities;
using todoApp.Common.Interfaces;
using todoApp.UI.ConsoleUI;
using todoApp.UI.Interfaces;

namespace todoApp.UI.ConsoleUi
{
    public class SingleTaskUI : BaseTaskUI, ISingleObjectUI<UserTask>
    {
        public SingleTaskUI(ITextFormatter textFormatter) : base(textFormatter)
        {
        }

        void ISingleObjectUI<UserTask>.Show(UserTask task)
        {
            base.Show(task);
        }
    }
}

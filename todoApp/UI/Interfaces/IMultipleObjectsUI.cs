using System.Collections.Generic;

namespace todoApp.UI.Interfaces
{
    public interface IMultipleObjectsUI<T>
    {
        public void Show(IEnumerable<T> obj);
    }
}

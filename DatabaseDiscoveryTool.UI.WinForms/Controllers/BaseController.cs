using DatabaseDiscoveryTool.UI.WinForms.Views;

namespace DatabaseDiscoveryTool.UI.WinForms.Controllers
{
    public abstract class BaseController<TView> : IController where TView : class, IView
    {
        protected readonly TView View;

        protected BaseController(TView view)
        {
            View = view;
            View.SetController(this);
        }

        public abstract void InitializeView();
    }
}
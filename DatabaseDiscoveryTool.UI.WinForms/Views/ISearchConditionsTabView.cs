using DatabaseDiscoveryTool.UI.WinForms.Controllers;

namespace DatabaseDiscoveryTool.UI.WinForms.Views
{
    public interface IView
    {
        void SetController(IController controller);
    }
    public interface ISearchConditionsTabView:IView
    {
        //void Clear();
        string Search1 { get; set; }
        string Search2 { get; set; }
        string SearchValue { get; set; }
        string PreferredConnectionStringName { get; set; }
        bool Search2Enabled { get; set; }
        string SearchQueryText { get; set; }
        bool SearchByValueEnabled { get; set; }

        void SetSelected();
    }
}
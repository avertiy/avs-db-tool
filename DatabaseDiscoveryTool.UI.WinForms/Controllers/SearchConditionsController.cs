using AV.WinForms.Common;
using DatabaseDiscoveryTool.UI.WinForms.Helpers;
using DatabaseDiscoveryTool.UI.WinForms.Models;
using DatabaseDiscoveryTool.UI.WinForms.Views;

namespace DatabaseDiscoveryTool.UI.WinForms.Controllers
{
    public class SearchConditionsController : BaseController<ISearchConditionsTabView>
    {
        public SearchConditionsController(ISearchConditionsTabView view) : base(view)
        {
        }

        public void LoadView()
        {
            
        }

        public void SearchConditionsUpdated()
        {
            var settings = ObjectStateManager.Get<UserSettings>();

            var condition = ObjectStateManager.Get<SearchConditions>();
            condition.Search1 = View.Search1;
            condition.Search2 = View.Search2;
            condition.SearchValue = View.SearchValue;

            condition.ConnectionString = View.PreferredConnectionStringName == "AX" ? settings.ConnectionString2 : settings.ConnectionString1;
            ObjectStateManager.Set(condition);
            View.SearchQueryText = condition.GetQueryAsDisplayText();
        }


        public override void InitializeView()
        {
            var settings = ObjectStateManager.Get<UserSettings>();
            var condition = ObjectStateManager.Get<SearchConditions>();
            View.Search1 = condition.Search1;
            View.Search2 = condition.Search2;
            //tbSearch2.Text = condition.SearchOnlyInColumnNames;
            //tbSearch2.Text = condition.SearchOnlyInTableNames;
            condition.ConnectionString = settings.ConnectionString1;

            View.PreferredConnectionStringName = "AX";
            
            View.Search2Enabled = !string.IsNullOrWhiteSpace(condition.Search2);
            View.SearchByValueEnabled = !string.IsNullOrWhiteSpace(condition.SearchValue);

            View.SearchQueryText = condition.GetQueryAsDisplayText();
            
        }
    }
}
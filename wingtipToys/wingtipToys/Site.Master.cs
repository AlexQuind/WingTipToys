using System;
using System.Linq;
using System.Web.UI;
using wingtipToys.Models;

namespace wingtipToys
{
	public partial class SiteMaster : MasterPage
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}	

        public IQueryable<Category> GetCategories()
        {
			var _db = new WingtipToys.Models.ProductContext();
			IQueryable<Category> query = _db.Categories;
			return query;
        }

    }
}
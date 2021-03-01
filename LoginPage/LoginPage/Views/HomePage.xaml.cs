using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : MasterDetailPage
    {
        public HomePage()
        {
            InitializeComponent();

        }

        private void OnTappedHome(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new DefaultDetail());
        }

        private void OnTappedCourses(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new CoursesPage());
        }

        private void OnTappedMore(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MorePage());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileTabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Veebruar : TabbedPage
    
    {


        public Veebruar()
      {
            InitializeComponent();
        Grid grd = new Grid
        {

        };
            for (int i = 0; i < 1; i++)
            {
                grd.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
            for (int i = 0; i < 1; i++)
            {
                grd.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
            {
                BackgroundColor = Color.LightBlue;
            }
            Image img = new Image { Source = "Snegovik.png" };
            grd.Children.Add(img, 0, 0);
        }

    }

}
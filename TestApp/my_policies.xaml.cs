using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.CommunityToolkit;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class my_policies : ContentPage
    {
        
        public my_policies()
        {
            InitializeComponent();
        }

        private void back_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Policy_Expander_Tapped(object sender, EventArgs e)
        {
            if (Policy_Expander.IsExpanded == true)
            {
                policydown.Source = ImageSource.FromFile("up.png");

                Policy_Changes_Expander.IsExpanded = false;
                policychanges.Source = ImageSource.FromFile("down.png");

                Lapsed_Expander.IsExpanded = false;
                Lapsed.Source = ImageSource.FromFile("down.png");

                Payments_Expander.IsExpanded = false;
                payments.Source = ImageSource.FromFile("down.png");
            }
            else if (Policy_Expander.IsExpanded == false)
            {
                policydown.Source = ImageSource.FromFile("down.png");
            }
        }

        private void Policy_Changes_Expander_Tapped(object sender, EventArgs e)
        {
            if (Policy_Changes_Expander.IsExpanded == true)
            {
                policychanges.Source = ImageSource.FromFile("up.png");

                Policy_Expander.IsExpanded = false;
                policydown.Source = ImageSource.FromFile("down.png");

                Lapsed_Expander.IsExpanded = false;
                Lapsed.Source = ImageSource.FromFile("down.png");

                Payments_Expander.IsExpanded = false;
                payments.Source = ImageSource.FromFile("down.png");
            }
            else if (Policy_Changes_Expander.IsExpanded == false)
            {
                policychanges.Source = ImageSource.FromFile("down.png");
            }
        }

        private void Lapsed_Expander_Tapped(object sender, EventArgs e)
        {
            if (Lapsed_Expander.IsExpanded == true)
            {
                Lapsed.Source = ImageSource.FromFile("up.png");

                Policy_Changes_Expander.IsExpanded = false;
                policychanges.Source = ImageSource.FromFile("down.png");

                Policy_Expander.IsExpanded = false;
                policydown.Source = ImageSource.FromFile("down.png");

                Payments_Expander.IsExpanded = false;
                payments.Source = ImageSource.FromFile("down.png");
            }
            else if (Lapsed_Expander.IsExpanded == false)
            {
                Lapsed.Source = ImageSource.FromFile("down.png");
            }
        }

        private void Payments_Expander_Tapped(object sender, EventArgs e)
        {
            if (Payments_Expander.IsExpanded == true)
            {
                payments.Source = ImageSource.FromFile("up.png");

                Policy_Expander.IsExpanded = false;
                policydown.Source = ImageSource.FromFile("down.png");

                Policy_Changes_Expander.IsExpanded = false;
                policychanges.Source = ImageSource.FromFile("down.png");

                Lapsed_Expander.IsExpanded = false;
                Lapsed.Source = ImageSource.FromFile("down.png");
            }
            else if (Payments_Expander.IsExpanded == false)
            {
                payments.Source = ImageSource.FromFile("down.png");
            }
        }
    }
}
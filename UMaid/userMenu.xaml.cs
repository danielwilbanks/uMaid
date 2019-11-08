using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UMaid
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class userMenu : Page
    {


        public userMenu()
        {
            this.InitializeComponent();
        }

        private void navViewUserMenu_Loaded(object sender, RoutedEventArgs e)
        {
            //Set the initial selected item to the home page
            foreach(NavigationViewItemBase item in navViewUserMenu.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "Home_Page")
                {
                    navViewUserMenu.SelectedItem = item;
                    break;
                }
            }

            contentFrame.Navigate(typeof(requestMaid));
        }

        private void navViewUserMenu_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            contentFrame.Navigate(typeof(requestMaid));
        }

        private void navViewUserMenu_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {

        }
    }
}

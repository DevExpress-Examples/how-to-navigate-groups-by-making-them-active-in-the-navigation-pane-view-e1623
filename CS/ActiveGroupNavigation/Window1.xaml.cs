using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Wpf.NavBar;

namespace ActiveGroupNavigation
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        #region #CodeBehind
        public Window1(){
            InitializeComponent();
            CheckButtonAvailability();
        }

        private void button_Click(object sender, RoutedEventArgs e){
            int activegroupIndex = navBarControl1.Groups.IndexOf(navBarControl1.ActiveGroup);
            if (sender == btnNext) navBarControl1.ActiveGroup = navBarControl1.Groups[activegroupIndex + 1];
            if (sender == btnPrev) navBarControl1.ActiveGroup = navBarControl1.Groups[activegroupIndex - 1];
        }

        private void CheckButtonAvailability(){
            btnNext.IsEnabled = !(navBarControl1.Groups.IndexOf(navBarControl1.ActiveGroup) == navBarControl1.Groups.Count - 1);
            btnPrev.IsEnabled = !(navBarControl1.Groups.IndexOf(navBarControl1.ActiveGroup) == 0);
        }

        private void NavigationPaneView_ActiveGroupChanged(object sender, NavBarActiveGroupChangedEventArgs e){
            CheckButtonAvailability();
        }
        #endregion #CodeBehind
    }
}

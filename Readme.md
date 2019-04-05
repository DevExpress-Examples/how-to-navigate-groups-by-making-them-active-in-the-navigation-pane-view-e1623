<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/ActiveGroupNavigation/Window1.xaml) (VB: [Window1.xaml](./VB/ActiveGroupNavigation/Window1.xaml))
* [Window1.xaml.cs](./CS/ActiveGroupNavigation/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/ActiveGroupNavigation/Window1.xaml.vb))
<!-- default file list end -->
# How to navigate groups by making them active in the Navigation Pane view


<p>In this example, a simple navigation interface is implemented using standard Button controls to activate groups within the NavBarControl. Note that navigation to the first and last groups is performed by executing specific commands of the NavbarControl. Navigation between previous and next groups is implemented by changing the <a href="http://documentation.devexpress.com/#WPF/DevExpressWpfNavBarNavBarControl_ActiveGrouptopic">ActiveGroup</a> property. The <a href="http://documentation.devexpress.com/#WPF/DevExpressWpfNavBarNavBarControl_ActiveGroupChangedtopic">ActiveGroupChanged</a> event is handled to determine the availability state of navigation buttons.</p>

<br/>



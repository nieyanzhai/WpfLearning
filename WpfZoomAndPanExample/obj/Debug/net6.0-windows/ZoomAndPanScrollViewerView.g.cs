#pragma checksum "..\..\..\ZoomAndPanScrollViewerView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0E89ED2476A6DE70D099DAD9353E6938855D77DF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfZoomAndPanExample;
using ZoomAndPan;


namespace WpfZoomAndPanExample {
    
    
    /// <summary>
    /// ZoomAndPanScrollViewerView
    /// </summary>
    public partial class ZoomAndPanScrollViewerView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\ZoomAndPanScrollViewerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CrosshairsCheckBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\ZoomAndPanScrollViewerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ViewBoxContent;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\ZoomAndPanScrollViewerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ZoomAndPan.ZoomAndPanScrollViewer ZoomAndPanControl;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\ZoomAndPanScrollViewerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid theGrid;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\ZoomAndPanScrollViewerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfZoomAndPanExample.ImageColorPicker actualContent;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\ZoomAndPanScrollViewerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox AnimationsCheckBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfZoomAndPanExample;component/zoomandpanscrollviewerview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ZoomAndPanScrollViewerView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CrosshairsCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.ViewBoxContent = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.ZoomAndPanControl = ((ZoomAndPan.ZoomAndPanScrollViewer)(target));
            return;
            case 4:
            this.theGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.actualContent = ((WpfZoomAndPanExample.ImageColorPicker)(target));
            return;
            case 6:
            this.AnimationsCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


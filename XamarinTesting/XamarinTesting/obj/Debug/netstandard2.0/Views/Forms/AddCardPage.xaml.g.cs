//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("XamarinTesting.Views.Forms.AddCardPage.xaml", "Views/Forms/AddCardPage.xaml", typeof(global::XamarinTesting.Views.Forms.AddCardPage))]

namespace XamarinTesting.Views.Forms {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Forms\\AddCardPage.xaml")]
    public partial class AddCardPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::XamarinTesting.Controls.BorderlessEntry cardNumberEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::XamarinTesting.Controls.CalenderDatePicker CustomDatePicker;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::XamarinTesting.Controls.BorderlessEntry cvvEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::XamarinTesting.Controls.BorderlessEntry nameEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(AddCardPage));
            cardNumberEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::XamarinTesting.Controls.BorderlessEntry>(this, "cardNumberEntry");
            CustomDatePicker = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::XamarinTesting.Controls.CalenderDatePicker>(this, "CustomDatePicker");
            cvvEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::XamarinTesting.Controls.BorderlessEntry>(this, "cvvEntry");
            nameEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::XamarinTesting.Controls.BorderlessEntry>(this, "nameEntry");
        }
    }
}
#pragma checksum "C:\Users\marryum\source\repos\testdevexp\testdevexp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aa57dc6b2f63aeb52c64cc3318c5c7542dcfda1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(testdevexp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace testdevexp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\marryum\source\repos\testdevexp\testdevexp\Pages\_ViewImports.cshtml"
using testdevexp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\marryum\source\repos\testdevexp\testdevexp\Pages\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marryum\source\repos\testdevexp\testdevexp\Pages\Index.cshtml"
using testdevexp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa57dc6b2f63aeb52c64cc3318c5c7542dcfda1", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5914f32a6c5be7d02ea587ac7dc0de38734a9dfd", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Home</h2>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\marryum\source\repos\testdevexp\testdevexp\Pages\Index.cshtml"
Write(Html.DevExtreme().DataGrid<SampleOrder>()
    .ShowBorders(true)
    .DataSource(d => d.Mvc().Controller("SampleData").LoadAction("Get").Key("OrderID"))
    .Columns(columns => {
        columns.AddFor(m => m.CustomField);
        columns.AddFor(m => m.OrderID);
        columns.AddFor(m => m.OrderDate);
        columns.AddFor(m => m.CustomerName);
        columns.AddFor(m => m.ShipCountry);
        columns.AddFor(m => m.ShipCity);
    })
    .Paging(p => p.PageSize(10))
    .FilterRow(f => f.Visible(true))
    .HeaderFilter(f => f.Visible(true))
    .GroupPanel(p => p.Visible(true))
    .Grouping(g => g.AutoExpandAll(false))
    .RemoteOperations(true)
    .Summary(s => s
        .TotalItems(totalItems => {
            totalItems.AddFor(m => m.ShipCity).SummaryType(SummaryType.Count);
        })
        .GroupItems(groupItems => {
            groupItems.Add().SummaryType(SummaryType.Count);
        })
    )
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\marryum\source\repos\testdevexp\testdevexp\Pages\Index.cshtml"
Write(Html.DevExtreme().DataGrid<SamplePerson>()
    .ShowBorders(true)
    .DataSource(ds => ds.Mvc().Controller("PersonData").LoadAction("Get").Key("PersonId"))
    .Columns(columns => {
        columns.AddFor(m => m.PersonId);
        columns.AddFor(m => m.Name);
        columns.AddFor(m => m.CNIC);
        columns.AddFor(m => m.CNICExpiryDate);
        columns.AddFor(m => m.City);
        columns.AddFor(m => m.Country);
    })
    .Paging(p => p.PageSize(10))
    .FilterRow(f => f.Visible(true))
    .HeaderFilter(f => f.Visible(true))
    .GroupPanel(p => p.Visible(true))
    .Grouping(g => g.AutoExpandAll(false))
    .RemoteOperations(true)
    .Summary(s => s
        .TotalItems(totalItems => {
            totalItems.AddFor(m => m.City).SummaryType(SummaryType.Count);
        })
        .GroupItems(groupItems => {
            groupItems.Add().SummaryType(SummaryType.Count);
        })
    )
);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Index> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index>)PageContext?.ViewData;
        public Pages_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\T\Desktop\ElectricityManagementMVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\Logistics\UptAddress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4bdd5d1c413a0ac8d6df60ec259b38f94a1fa84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logistics_UptAddress), @"mvc.1.0.view", @"/Views/Logistics/UptAddress.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\T\Desktop\ElectricityManagementMVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\_ViewImports.cshtml"
using ElectricityManagementMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T\Desktop\ElectricityManagementMVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\_ViewImports.cshtml"
using ElectricityManagementMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4bdd5d1c413a0ac8d6df60ec259b38f94a1fa84", @"/Views/Logistics/UptAddress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ad30cce6f27a2ee55be4c4bc42dedba8309b7c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Logistics_UptAddress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("resources library"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/area.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\T\Desktop\ElectricityManagementMVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\Logistics\UptAddress.cshtml"
  
    ViewData["Title"] = "UptAddress";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>编辑地址</h1>\r\n<input type=\"hidden\" id=\"Aid\"");
            BeginWriteAttribute("value", " value=\"", 94, "\"", 113, 1);
#nullable restore
#line 7 "C:\Users\T\Desktop\ElectricityManagementMVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\Logistics\UptAddress.cshtml"
WriteAttributeValue("", 102, ViewBag.id, 102, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
<link href=""https://cdn.bootcss.com/bootstrap-switch/3.3.4/css/bootstrap3/bootstrap-switch.min.css"" rel=""stylesheet"">
<script src=""https://cdn.bootcss.com/jquery/1.11.1/jquery.min.js""></script>
<script src=""https://cdn.bootcss.com/bootstrap-switch/3.3.4/js/bootstrap-switch.min.js""></script>

<table>
    <tr>
        <td>地址简称:</td>
        <td><input type=""text"" class=""form-control"" id=""Abbreviation""></td>
    </tr>
    <tr>
        <td>联系人:</td>
        <td><input type=""text"" class=""form-control"" id=""Aconsigner""></td>
    </tr>
    <tr>
        <td>手机号</td>
        <td> <input type=""text"" class=""form-control"" id=""Aphone""></td>
    </tr>
    <tr>
        <td>地址</td>
        <td>
            <select id=""s_province"" name=""s_province""></select>
            <select id=""s_city"" name=""s_city""></select>
            <select id=""s_county"" name=""s_county""></select>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4bdd5d1c413a0ac8d6df60ec259b38f94a1fa846031", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <script type=""text/javascript"">_init_area();</script>
        </td>
    </tr>
    <tr>
        <td>详情地址</td>
        <td><input type=""text"" class=""form-control"" id=""Adeltailedaddress""></td>
    </tr>
    <tr>
        <td>设为发货点</td>
        <td><input type=""checkbox"" id=""Adeliverypoint"" name=""my-checkbox"" checked></td>
    </tr>
    <tr>
        <td>设为收货点</td>
        <td><input type=""checkbox"" id=""Areceivingpoint"" name=""my-checkbox"" checked></td>
    </tr>
    <tr>
        <td><input type=""button"" value=""提交"" onclick=""Upt()"" /></td>
        <td></td>
    </tr>
</table>

<script>
    $(function () {
        Fantian();
    })
    $('input[name=""my-checkbox""]').bootstrapSwitch({
        ""onColor"": ""success"",
        ""offColor"": ""success"",
        ""onText"": true,
        ""offText"": false
    });
    var Gid = document.getElementById;
    var showArea = function () {
        var province = Gid('s_province').value;
        var city = Gid('s_city').value;
        var c");
            WriteLiteral(@"ounty = Gid('s_county').value;
        if (province == city) {
            city = """";
        }
        Gid(""txtAddress"").value = province + city + county;
    }
    function Fantian() {
        var id = $(""#Aid"").val();
        $.ajax({
            url: 'http://localhost:2789/api/FandAddressAsync?id=' + id,
            dataType: 'json',
            type: 'post',
            success: function (d) {
                for (var i = 0; i < d.length; i++) {
                    $(""#Aid"").val(d[i].Aid);
                    $(""#Abbreviation"").val(d[i].Abbreviation);
                    $(""#Aconsigner"").val(d[i].Aconsigner);
                    $(""#Aphone"").val(d[i].Aphone);
                    $(""#Abbreviation"").val(d[i].Abbreviation);
                    $(""#Adeltailedaddress"").val(d[i].Adeltailedaddress);
                    $(""#Adeliverypoint"").val(d[i].Adeliverypoint);
                    $(""#Areceivingpoint"").val(d[i].Areceivingpoint);
                }
            }
        })
    }
    ");
            WriteLiteral(@"function Upt() {
        if ($(""input[type='my-checkbox']"").is(':checked') == true) {
            var a = {
                ""Abbreviation"": $(""#Abbreviation"").val(),
                ""Aconsigner"": $(""#Aconsigner"").val(),
                ""Aphone"": $(""#Aphone"").val(),
                ""Address"": $(""#s_province"").val() + $(""#s_city"").val() + $(""#s_county"").val(),
                ""Adeltailedaddress"": $(""#Adeltailedaddress"").val(),
                ""Adeliverypoint"": true,
                ""Areceivingpoint"": true
            };

        } else {
            var a = {
                ""Abbreviation"": $(""#Abbreviation"").val(),
                ""Aconsigner"": $(""#Aconsigner"").val(),
                ""Aphone"": $(""#Aphone"").val(),
                ""Address"": $(""#s_province"").val() + $(""#s_city"").val() + $(""#s_county"").val(),
                ""Adeltailedaddress"": $(""#Adeltailedaddress"").val(),
                ""Adeliverypoint"": false,
                ""Areceivingpoint"": false
            };
        }
        v");
            WriteLiteral(@"ar josn = JSON.stringify(a);
        $.ajax({
            url: 'http://localhost:2789/api/AddAddressAsync',
            data: josn,
            type: 'post',
            dataType: ""json"",
            contentType: ""application/json"",
            success: function (data) {
                if (data > 0) {
                    alert(""修改成功"");
                    location.href = '/Logistics/Index';
                }
                else {
                    alert(""修改失败"");
                }
            }
        })
    }
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

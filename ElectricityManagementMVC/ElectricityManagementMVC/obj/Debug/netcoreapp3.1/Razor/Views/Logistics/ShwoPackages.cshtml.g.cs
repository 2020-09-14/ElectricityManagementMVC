#pragma checksum "C:\Users\guisu\Desktop\电商\mvc\ElectricityManagementMVC\ElectricityManagementMVC\Views\Logistics\ShwoPackages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bd4a9a8db0ec1145cc0e6eea81bd2b9df447b1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logistics_ShwoPackages), @"mvc.1.0.view", @"/Views/Logistics/ShwoPackages.cshtml")]
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
#line 1 "C:\Users\guisu\Desktop\电商\mvc\ElectricityManagementMVC\ElectricityManagementMVC\Views\_ViewImports.cshtml"
using ElectricityManagementMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\guisu\Desktop\电商\mvc\ElectricityManagementMVC\ElectricityManagementMVC\Views\_ViewImports.cshtml"
using ElectricityManagementMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bd4a9a8db0ec1145cc0e6eea81bd2b9df447b1e", @"/Views/Logistics/ShwoPackages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ad30cce6f27a2ee55be4c4bc42dedba8309b7c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Logistics_ShwoPackages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "已发货未揽收", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "已发货未中转", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "已发货未派件", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "已发货未签收", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "已签收", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\guisu\Desktop\电商\mvc\ElectricityManagementMVC\ElectricityManagementMVC\Views\Logistics\ShwoPackages.cshtml"
  
    ViewData["Title"] = "ShwoPackages";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdn.staticfile.org/twitter-bootstrap/4.3.1/css/bootstrap.min.css"">
<script src=""https://cdn.staticfile.org/jquery/3.2.1/jquery.min.js""></script>
<script src=""https://cdn.staticfile.org/popper.js/1.15.0/umd/popper.min.js""></script>
<script src=""https://cdn.staticfile.org/twitter-bootstrap/4.3.1/js/bootstrap.min.js""></script>
<input type=""hidden"" id=""hidden""");
            BeginWriteAttribute("value", " value=\"", 496, "\"", 515, 1);
#nullable restore
#line 10 "C:\Users\guisu\Desktop\电商\mvc\ElectricityManagementMVC\ElectricityManagementMVC\Views\Logistics\ShwoPackages.cshtml"
WriteAttributeValue("", 504, ViewBag.id, 504, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n<table>\r\n    <tr>\r\n        <th>\r\n            包裹状态<select id=\"Pstate\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bd4a9a8db0ec1145cc0e6eea81bd2b9df447b1e6226", async() => {
                WriteLiteral("请选择");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bd4a9a8db0ec1145cc0e6eea81bd2b9df447b1e7398", async() => {
                WriteLiteral("已发货未揽收");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bd4a9a8db0ec1145cc0e6eea81bd2b9df447b1e8573", async() => {
                WriteLiteral("已发货未中转");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bd4a9a8db0ec1145cc0e6eea81bd2b9df447b1e9748", async() => {
                WriteLiteral("已发货未派件");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bd4a9a8db0ec1145cc0e6eea81bd2b9df447b1e10923", async() => {
                WriteLiteral("已发货未签收");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bd4a9a8db0ec1145cc0e6eea81bd2b9df447b1e12099", async() => {
                WriteLiteral("已签收");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </select>
        </th>
        <th>
            快递公司<input type=""text"" id=""EName"" />
        </th>
        <th>订单号<input type=""text"" id=""Podd"" /></th>
        <th>快递单号<input type=""text"" id=""Pordernumber"" /></th>
        <th><input type=""button"" value=""搜索"" onclick=""Show()"" /></th>
    </tr>
</table>
<table>
    <tr>
        <td><a href=""#""");
            BeginWriteAttribute("id", " id=\"", 1277, "\"", 1282, 0);
            EndWriteAttribute();
            WriteLiteral(@" onclick=""Show()"">全部</a>&nbsp;&nbsp;&nbsp;</td>
        <td><a href=""#"" id=""Panomaly"" onclick=""Show()"">揽收异常</a>&nbsp;&nbsp;&nbsp;</td>
        <td><a href=""#"" id=""Panomaly"" onclick=""Show()"">运转异常</a>&nbsp;&nbsp;&nbsp;</td>
        <td><a href=""#"" id=""Panomaly"" onclick=""Show()"">派签异常</a>&nbsp;&nbsp;&nbsp;</td>
        <td><a href=""#"" id=""Panomaly"" onclick=""Show()"">无异常</a></td>
    </tr>
</table>
<div class=""modal fade"" id=""myModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">   
           <div class=""modal-header"">
                <h4 class=""modal-title"">处理异常</h4>
            </div>
            <div class=""modal-body"">
                <table id=""table1"">   
                </table>
                <table>
                    <tr>
                        <td>审批状态</td>
                        <td>
                            <input type=""radio"" name=""a"" value=""1"">再次投递
                            <input type=""radio"" name=""a"" value=""0"">拒绝退回
                            
");
            WriteLiteral(@"                        </td>
                    </tr>
                    <tr>
                        <td>审批意见</td>
                        <td><textarea id=""Pdescribe""></textarea></td>
                    </tr>
                    <tr>
                        <td><input type=""button"" value=""提交"" onclick=""Add()"" /></td>
                        <td><input type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" value=""取消"" /></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</div>
<table class=""table table-sm"">
    <thead>
        <tr>
            <th scope=""col"">快递公司</th>
            <th scope=""col"">快递单号</th>
            <th scope=""col"">发货时间</th>
            <th scope=""col"">订单号</th>
            <th scope=""col"">包裹状态</th>
            <th scope=""col"">异常状态</th>
            <th scope=""col"">异常时长</th>
            <th scope=""col"">处理状态</th>
            <th scope=""col"">操作</th>
        </tr>
    </thead>
    <tbody id=""tb"">
    </tbod");
            WriteLiteral(@"y>
</table>
<script>
    $(function () {
        Show();
    })
    function Show() {
        var Pstate = $(""#Pstate"").val();
        var EName = $(""#EName"").val();
        var Podd = $(""#Podd"").val();
        var Pordernumber = $(""#Pordernumber"").val();
        var Panomaly = $(""#Panomaly"").val();
        $.ajax({
            url: 'http://localhost:2789/api/PackagesAsync',
            data: { Pstate: Pstate, EName: EName, Podd: Podd, Pordernumber: Pordernumber, Panomaly: Panomaly },
            dataType: 'json',
            type: 'get',
            success: function (data) {
                $(""#tb"").empty();
                $(data).each(function () {
                    var html = '<tr>';
                    html += '<td>' + this.EName + '</td>';
                    html += '<td>' + this.Podd + '</td>';
                    html += '<td>' + this.Ptime + '</td>';
                    html += '<td><input type=""checkbox""/></td>';
                    html += '<td>' + this.OrderNumber + '<");
            WriteLiteral(@"/td>';
                    html += '<td>' + this.Pstate + '</td>';
                    html += '<td>' + this.Panomaly + '</td>';
                    html += '<td>' + this.Panomalytime + '</td>';
                    html += '<td>' + (this.PapprovalStatus = 1 ? ""已处理"" : ""未处理"") + '</td>';
                    html += '<td><button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModal"" onclick=""Upt(' + this.Pid + ')"">打开模态框</button></td>';
                    html += '</tr>';
                    $(""#tb"").append(html);
                })
            }
        })
    }
    function Upt(id)
    {
        $.ajax({
            url: 'http://localhost:2789/api/DetailsPackageAsync?id=' + id,
            dataType: 'json',
            type: 'post',
            success: function (data)
            {
                $(""#table1"").empty();
                $(data).each(function () {
                    var html = '<tr>';
                    html += '<td>订单号:' + this.EName + '</td>';");
            WriteLiteral(@"
                    html += '</tr>';
                    html += '<tr>';
                    html += '<td>运单号:' + this.Podd + '</td>';
                    html += '</tr>';
                    html += '<tr>';
                    html += '<td>申请时间' + this.Ptime + '</td>';
                    html += '</tr>';
                    $(""#table1"").append(html);
                })
            }
        })
    }
    function Add()
    {
        if ($(""input[type='radio']"").is(':checked') == true) {
            var p = {
                ""Pstatus"": true,
                ""Pdescribe"": $("".Pdescribe"").val()
            }
        }
        else {
            var p = {
                ""Pstatus"": false,
                ""Pdescribe"": $("".Pdescribe"").val()
            }
        }
        console.log(p);
        var json = JSON.stringify(p);
        $.ajax({
            url: 'http://localhost:2789/api/AddPackagesAsync',
            data: json,
            dataType: 'json',
            type: 'post',");
            WriteLiteral(@"
            success: function (data)
            {
                if (data > 0) {
                    alert(""处理成功"");
                    Show();
                }
                else {
                    alert(""处理失败"");
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

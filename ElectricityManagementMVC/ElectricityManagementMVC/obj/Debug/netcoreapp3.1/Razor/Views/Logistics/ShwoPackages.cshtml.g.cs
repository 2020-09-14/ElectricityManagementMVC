#pragma checksum "C:\Users\T\Desktop\ElectricityManagementMVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\Logistics\ShwoPackages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ff8ff56fba8195bdf93506382543a8d4c68c52f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff8ff56fba8195bdf93506382543a8d4c68c52f", @"/Views/Logistics/ShwoPackages.cshtml")]
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
#line 2 "C:\Users\T\Desktop\ElectricityManagementMVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\Logistics\ShwoPackages.cshtml"
  
    ViewData["Title"] = "ShwoPackages";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script src=\"https://cdn.staticfile.org/popper.js/1.15.0/umd/popper.min.js\"></script>\r\n<script src=\"https://cdn.staticfile.org/twitter-bootstrap/4.3.1/js/bootstrap.min.js\"></script>\r\n<input type=\"hidden\" id=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 314, "\"", 333, 1);
#nullable restore
#line 9 "C:\Users\T\Desktop\ElectricityManagementMVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\Logistics\ShwoPackages.cshtml"
WriteAttributeValue("", 322, ViewBag.id, 322, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n<table>\r\n    <tr>\r\n        <th>\r\n            包裹状态<select id=\"Pstate\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ff8ff56fba8195bdf93506382543a8d4c68c52f6112", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ff8ff56fba8195bdf93506382543a8d4c68c52f7284", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ff8ff56fba8195bdf93506382543a8d4c68c52f8459", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ff8ff56fba8195bdf93506382543a8d4c68c52f9634", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ff8ff56fba8195bdf93506382543a8d4c68c52f10809", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ff8ff56fba8195bdf93506382543a8d4c68c52f11985", async() => {
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
                            
                        </td>
                    </tr>
                   ");
            WriteLiteral(@" <tr>
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
            <th scope=""col""><input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 2341, "\"", 2349, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""ck"" /></th>
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
    <tbody id=""table"">
    </tbody>
</table>
<script>
    $(function () {
        Show();
        $(""#ck"").click(function () {
            $("".ck"").each(function () {

                $(this).attr(""checked"", !$(this).attr(""checked""))
            })

        })
    })
    function Show() {
        var Pstate = $(""#Pstate"").val();
        var EName = $(""#EName"").val();
        var Podd = $(""#Podd"").val();
        var Pordernumber = $(""#Pordernumber"").val();
        var Panomaly = $(""#Panomaly"").val();
        $.ajax({
            url: 'http://localhost:2789/api/PackagesAsync',
            data: { Pstat");
            WriteLiteral(@"e: Pstate, EName: EName, Podd: Podd, Pordernumber: Pordernumber, Panomaly: Panomaly },
            dataType: 'json',
            type: 'get',
            success: function (data) {
                $(""#table"").empty();
                $(data).each(function () {
                    var html = '<tr>';
                    html += '<td><input class=""ck"" type=""checkbox""   value=""' + this.Pid + '"" /></td>';
                    html += '<td>' + this.EName + '</td>';
                    html += '<td>' + this.Podd + '</td>';
                    html += '<td>' + this.Ptime + '</td>';
                    html += '<td>' + this.OrderNumber + '</td>';
                    html += '<td>' + this.Pstate + '</td>';
                    html += '<td>' + this.Panomaly + '</td>';
                    html += '<td>' + this.Panomalytime + '</td>';
                    html += '<td>' + (this.PapprovalStatus = 1 ? ""已处理"" : ""未处理"") + '</td>';
                    html += '<td><button type=""button"" class=""btn btn-primary"" data-");
            WriteLiteral(@"toggle=""modal"" data-target=""#myModal"" onclick=""Upt(' + this.Pid + ')"">处理异常</button></td>';
                    html += '</tr>';
                    $(""#table"").append(html);
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
                    html += '<td>订单号:' + this.EName + '</td>';
                    html += '</tr>';
                    html += '<tr>';
                    html += '<td>运单号:' + this.Podd + '</td>';
                    html += '</tr>';
                    html += '<tr>';
                    html += '<td>申请时间' + this.Ptime + '</td>';
                    html += '</tr>';
                    $(""#table1"").append(html);
         ");
            WriteLiteral(@"       })
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
            type: 'post',
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

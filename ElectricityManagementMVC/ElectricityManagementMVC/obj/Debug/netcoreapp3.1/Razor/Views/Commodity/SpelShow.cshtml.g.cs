#pragma checksum "C:\Users\guisu\Desktop\电商\mvc\ElectricityManagementMVC\ElectricityManagementMVC\Views\Commodity\SpelShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8314d6e8a449b6819c0c0956b5e152a1a0549f72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Commodity_SpelShow), @"mvc.1.0.view", @"/Views/Commodity/SpelShow.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8314d6e8a449b6819c0c0956b5e152a1a0549f72", @"/Views/Commodity/SpelShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ad30cce6f27a2ee55be4c4bc42dedba8309b7c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Commodity_SpelShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\guisu\Desktop\电商\mvc\ElectricityManagementMVC\ElectricityManagementMVC\Views\Commodity\SpelShow.cshtml"
  
    ViewData["Title"] = "SpelShow";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>SpelShow</h1>\r\n<div style=\"width: 1351px; height: 332px; margin-left: 170px;\">\r\n       \r\n        <table class=\"table table-hover\">\r\n            <tr>\r\n                <th>\r\n                    <input type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 313, "\"", 321, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""ck"" />
                </th>
                <th>
                    分类名称
                </th>
                <th>
                    分类编码
                </th>
               
                <th>
                    状态
                </th>
                <th>
                    操作
                </th>
               
            </tr>
            <tbody id=""tb""></tbody>
        </table>
    </div>
<input type=""button"" value=""ddd"" onclick=""Lphen()"" />
<input type=""hidden"" id=""hi"" value=""0"" />
<script>
    $(function () {
        Show();
    })
    function jia() {
        $(""#hi"").val(Number(Number($('#hi').val())+1))
    }
    function Lphen() {
        var line = '<tr><td>打打打</td><td>打打打</td><td>打打打</td><td>打打打</td><td>打打打</td></tr>'
        $(""#tb tr:eq(2)"").after(line)
    }
    function Show() {
        $.ajax({
            url: 'http://localhost:2789/api/Claf',
            type: 'get',
            dataType: 'json',
            success: function (d) {
");
            WriteLiteral(@"                $(""#tb"").empty();
                $(d).each(function () {
                    var line = '<tr>'
                        + '<td><input class=""ck"" type=""checkbox""   value=""' + this.classifyId + '"" /> </td>'
                        + '<td><a href=""#"" onclick = ""Chuan(' + Number($(""#hi"").val()) + ',' + this.classifyId + ')""><p>﹀</p><a>' + this.cname+'</td>'
                        + '<td >' + this.coding + '</td>'
                        + '<td>' + this.state + '</td>'
                        + '<td><a><p>删除</p></a></td>'
                        + '</tr>';
                    $('#tb').append(line);
                    jia();
                })
            }
        })
    } 
    //加载二级联动
    function Chuan(ids, id) {
        $(""#hi"").val('0')
        Show();
        $.ajax({
            url: 'http://localhost:2789/api/GetClaf',
            type: 'get',
            data: { ids: id },
            dataType: 'json',
            success: function (d) {
                
       ");
            WriteLiteral(@"         $(d).each(function () {
                    var line = '<tr>'
                        + '<td><input class=""ck"" type=""checkbox""   value=""' + this.classifyIdd + '"" /></td>'
                        + '<td> &nbsp &nbsp&nbsp&nbsp&nbsp&nbsp  <a href=""#"" onclick = ""Chuan1(' + Number($(""#hi"").val()) + ',' + this.classifyId + ')"" >﹀</a> ' + this.cname + '</td>'
                        + '<td >' + this.coding + '</td>'
                        + '<td>' + this.state + '</td>'
                        + '<td><a><p>删除</p></a></td>'
                        + '</tr>';
                    $(""#tb tr:eq("" + ids + "")"").after(line)
                    jia();
                })
            }
        })
    }
    function Chuan1(ids, id) {
        Show();
        $.ajax({
            url: 'http://localhost:2789/api/GetClaf',
            type: 'get',
            data: { ids: id },
            dataType: 'json',
            success: function (d) {

                $(d).each(function () {
               ");
            WriteLiteral(@"     var line = '<tr>'
                        + '<td><input class=""ck"" type=""checkbox""   value=""' + this.classifyIdd + '"" /></td>'
                        + '<td> &nbsp &nbsp&nbsp&nbsp&nbsp&nbsp  <a href=""#"">﹀</a> ' + this.cname + '</td>'
                        + '<td >' + this.coding + '</td>'
                        + '<td>' + this.state + '</td>'
                        + '<td><a><p>删除</p></a></td>'
                        + '</tr>';
                    $(""#tb tr:eq("" + ids + "")"").after(line)
                })
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
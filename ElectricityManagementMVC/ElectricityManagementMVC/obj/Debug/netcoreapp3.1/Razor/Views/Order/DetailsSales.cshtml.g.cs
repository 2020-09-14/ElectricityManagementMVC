#pragma checksum "C:\Users\86176\Desktop\电商后台管理MVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\Order\DetailsSales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0abb86df71181e64234b09b3b6eb733eeff5a1ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_DetailsSales), @"mvc.1.0.view", @"/Views/Order/DetailsSales.cshtml")]
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
#line 1 "C:\Users\86176\Desktop\电商后台管理MVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\_ViewImports.cshtml"
using ElectricityManagementMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\86176\Desktop\电商后台管理MVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\_ViewImports.cshtml"
using ElectricityManagementMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0abb86df71181e64234b09b3b6eb733eeff5a1ce", @"/Views/Order/DetailsSales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ad30cce6f27a2ee55be4c4bc42dedba8309b7c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_DetailsSales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "用户重复下单", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "用户不想买了", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "用户买错了/信息填错了，重新下单", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "联系不上用户", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "商品无货", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "商品信息填写错误", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "用户收货地址填写错误", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\86176\Desktop\电商后台管理MVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\Order\DetailsSales.cshtml"
  
    ViewData["Title"] = "DetailsSales";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link href=\"https://cdn.bootcss.com/bootstrap/3.3.7/css/bootstrap.min.css\" rel=\"stylesheet\">\r\n<script src=\"https://cdn.bootcss.com/bootstrap/3.3.7/js/bootstrap.min.js\"></script>\r\n<script src=\"https://cdn.bootcss.com/jquery/3.3.1/jquery.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0abb86df71181e64234b09b3b6eb733eeff5a1ce6655", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div style=\"  width: 100%;height: 800px;background-color: darkgrey\" id=\"div1\">\r\n    <input type=\"hidden\" id=\"ss\"");
            BeginWriteAttribute("value", " value=\"", 470, "\"", 489, 1);
#nullable restore
#line 12 "C:\Users\86176\Desktop\电商后台管理MVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\Order\DetailsSales.cshtml"
WriteAttributeValue("", 478, ViewBag.Is, 478, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

</div>
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                    &times;
                </button>
                <h4 class=""modal-title"" id=""myModalLabel"">
                    取消订单
                </h4>
            </div>
            <div class=""modal-body"">
                <span>取消原因</span>&emsp;<select id=""Select1"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0abb86df71181e64234b09b3b6eb733eeff5a1ce8890", async() => {
                WriteLiteral("请选择取消原因");
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0abb86df71181e64234b09b3b6eb733eeff5a1ce10070", async() => {
                WriteLiteral("取消原因A");
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0abb86df71181e64234b09b3b6eb733eeff5a1ce11249", async() => {
                WriteLiteral("取消原因B");
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0abb86df71181e64234b09b3b6eb733eeff5a1ce12428", async() => {
                WriteLiteral("取消原因C");
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0abb86df71181e64234b09b3b6eb733eeff5a1ce13607", async() => {
                WriteLiteral("取消原因D");
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0abb86df71181e64234b09b3b6eb733eeff5a1ce14786", async() => {
                WriteLiteral("取消原因E");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0abb86df71181e64234b09b3b6eb733eeff5a1ce15965", async() => {
                WriteLiteral("取消原因F");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0abb86df71181e64234b09b3b6eb733eeff5a1ce17144", async() => {
                WriteLiteral("取消原因G");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </select>\r\n                <br />\r\n                <span>取消原因</span>&emsp;\r\n                <textarea id=\"Recommend\"");
            BeginWriteAttribute("class", " class=\"", 1724, "\"", 1732, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width:300px;height:100px;margin-top:30px"" rows=""3""></textarea> 
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">
                    关闭
                </button>
                <button type=""button"" class=""btn btn-primary"" onclick=""Add()"">
                    提交更改
                </button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal -->
</div>
");
            WriteLiteral(@"<script>
    Show()
    function Show() {
        $.ajax({
            url: ""http://localhost:2789/api/DetailsSales?id="" + $(""#ss"").val(),
            type: ""get"",
            dataType: ""json"",
            success: function (date) {
                $(""#div1"").empty();
                $.each(date, function (index, item) {
                    var str = '<div style=""width: 80%; height: 100px;  background-color: white; margin-right: 135px; margin-left: 150px; "">' +
                        '<br />' +
                        ' <br />' +
                        ' &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;' + '<span style=""font-size:16px;color:black"">退货单号</span>&nbsp;  &nbsp;' + '<span style=""font-size:20px;color:black"">' + item.orderNumber + '</span>' +
                        '&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;  &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp; ' + '<button class=""btn btn-info"" data-toggle=""modal"" data-target=""#myModal"" onclick=""motai(' + ");
            WriteLiteral(@"item.orderId + ')"">拒绝退货</button>' +
                        ' &emsp; &emsp; <button class=""btn btn-info"" data-toggle=""modal"" data-target=""#myModal"" onclick=""motai(' + item.orderId + ')"">同意退货</button>' +
                        ' </div>' +
                        '  <br />' +
                        ' <div style=""width: 80%; height: 240px;  background-color: white; margin-right: 135px; margin-left: 150px; "">' +
                        '<div style="" width: 25%; height: 240px; float: left; margin-right: 20px; margin-left: 20px"">' +
                        ' <br />' +
                        ' <p style=""font-size:21px;color:black"">&emsp;退货商品</p>' +
                        ' <span style=""font-size:14px;color:black""> &emsp;商品信息:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">' + item.GoodsName + '</span>' +
                        '<span style=""font-size:14px;color:black""> &emsp;单价:</span>&nbsp;<span style=""font-size:14px;color:black"">' + item.GoodsPrice + '</span>' +
                        ");
            WriteLiteral(@"' <span style=""font-size:14px;color:black""> &emsp;数量:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">' + item.GoodsNum + '</span>' +
                        ' <span style=""font-size:14px;color:black""> &emsp;小计:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">' + (item.goodsNum * item.goodsPrice) + '</span>' +
                        '<span style=""font-size:14px;color:black""> &emsp;实付金额:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">' + item.GoodsPrice + '</span>' +
                        '<span style=""font-size:14px;color:black""> &emsp;应退金额:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">' + item.GoodsPrice + '</span>' +
                        ' </div>' +
                        ' <div style=""width: 25%; height: 240px; float: left; margin-right: 20px; margin-left: 20px"">' +
                        '<br />' +
                        ' <p style=""font-size:21px;color:black"">&emsp;退货原因</p>' +
                        '<span style=""font-size:14px;color:b");
            WriteLiteral(@"lack""> &emsp;退货描述:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">' + item.SalesExchangeCause+ '</span><br /><br />' +
                        ' <span style=""font-size:14px;color:black""> &emsp;退货图片:</span>&emsp;<span style=""font-size:14px;color:black"">' + (item.goodsNum * item.goodsPrice) + '</span><br /><br />' +
                        '  <br />' +
                        ' <p style=""font-size:21px;color:black"">&emsp;退货单信息</p>' +
                        '  <table class=""table"">' +
                        ' <tr>' +
                        '  <td>商品返回方式</td>' +
                        ' <td>上门取件</td>' +
                        '</tr>' +
                        '<tr>'+
                        ' <td>退货原因</td>' +
                        ' <td>' + item.SalesExchangeCause + '</td>' +
                        '</tr>' +
                        '<tr>'+
                        ' <td>收货地址</td>' +
                        ' <td>' + item.BuyerAddressInfo + '</td>' +
                        ' </");
            WriteLiteral(@"tr>' +
                        '<tr>' +
                        ' <td>取货地址</td>' +
                        ' <td>' + (item.Address + item.Adeltailedaddress) + '</td>' +
                        ' </tr>' +
                        '<tr>' +
                        ' <td>联系人</td>' +
                        ' <td>' + (item.BuyerAddressName) + '</td>' +
                        ' </tr>' +
                        '<tr>' +
                        ' <td>手机号</td>' +
                        ' <td>' + (item.BuyerAddressTel) + '</td>' +
                        ' </tr>' +
                        '<tr>' +
                        ' <td>申请时间</td>' +
                        ' <td>' + (item.SalesTime) + '</td>' +
                        ' </tr>' +
                        '<tr>' +
                        ' <td>退款方式</td>' +
                        ' <td>' + (item.orderPay == 1 ? ""支付宝"" : ""微信"") + '</td>' +
                        ' </tr>' +
                        '<tr>' +
                        ' <td>订单号</td>'");
            WriteLiteral(@" +
                        ' <td>' + (item.OrderNumber) + '</td>' +
                        ' </tr>' +
                        ' <tbody >' +
                        ' <tr>' +
                        '<td>' + '<img src=""http://localhost:2789' + item.goodsImg + '"" alt="""" width=""40"" height=""40"" />' + item.goodsName + '&nbsp;' + item.goodsIntroduce + '</td>' +
                        ' <td>' + item.goodsPrice + '</td>' +
                        '   <td>' + item.goodsNum + '</td>' +
                        '  <td>' + (item.goodsNum * item.goodsPrice) + '</td>' +
                        '  <td>0.00</td>' +
                        '  <td>' + (item.goodsNum * item.goodsPrice) + '</td>' +
                        ' </tr>' +
                        '</tbody>' +
                        ' </table>' +
                        '<div style=""float:right"">' +
                        '  <span style=""font-size:14px;color:black""> &emsp;商品总额:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">' + (item.goods");
            WriteLiteral(@"Num * item.goodsPrice) + '</span><br /><br />' +
                        '  <span style=""font-size:14px;color:black""> &emsp;优惠金额:</span>&emsp;&emsp;<span style=""font-size:14px;color:black"">￥0.00</span><br /><br />' +
                        ' <span style=""font-size:14px;color:black""> &emsp;运费:</span>&emsp;&emsp; &emsp;&emsp;<span style=""font-size:14px;color:black"">￥8</span><br /><br />' +
                        '  <span style=""font-size:14px;color:red""> &emsp;  应付总额:</span>&emsp; &emsp;<span style=""font-size:20px;color:red"">' + (item.goodsNum * item.goodsPrice) + '</span><br />' +
                        '</div>' +
                        '<table>' +
                        '<tr>' +
                        ' <td>商品应退金额</td>' +
                        ' <td>' + (item.goodsNum * item.goodsPrice) + '</td>' +
                        ' </tr>' +
                        '<tr>' +
                        ' <td>是否退运费</td>' +
                        ' <td><input id=""Radio1"" type=""radio"" value=""不退运费"" /><inpu");
            WriteLiteral(@"t id=""Radio1"" type=""radio"" value=""退运费"" /></td>' +
                        ' </tr>' +
                        '<tr>' +
                        ' <td>退款金额</td>' +
                        ' <td>' + (item.goodsNum * item.goodsPrice) + '</td>' +
                        ' </tr>' +
                        '<tr>' +
                        ' <td>选择收货点</td>' +
                        ' <td></td>' +
                        ' </tr>' +
                        '<tr>' +
                        ' <td>收货人姓名</td>' +
                        ' <td>' + (BuyerAddressName) + '</td>' +
                        ' </tr>' +
                        '<tr>' +
                        ' <td>收货人手机号</td>' +
                        ' <td>' + (BuyerAddressTel) + '</td>' +
                        ' </tr>' +
                        '<tr>' +
                        ' <td>收货地址</td>' +
                        ' <td>' + (BuyerAddressInfo) + '</td>' +
                        ' </tr>' +
                        '<tr>' +
           ");
            WriteLiteral(@"             ' <td>详细地址</td>' +
                        ' <td>' + (BuyerAddressInfo) + '</td>' +
                        ' </tr>' +
                        '<tr>' +
                        ' <td>邮政编码</td>' +
                        ' <td>' + (item.goodsNum * item.goodsPrice) + '</td>' +
                        ' </tr>' +
                        '<tr>' +
                        ' <td>备注信息</td>' +
                        ' <td>' + item.SalesExchangeInfo + '</td>' +
                        ' </tr>' +
                        '</table>'
                        '  </div>';
                    $(""#div1"").append(str);
                })

            }
        })
    }

    function motai(aa) {
        sessionStorage.setItem(""aa"", aa);
    }
    function Add() {
        var obj = {
            ""OrdeCancelCause"": $(""#Select1"").val(),
            ""OrdeCancelStateId"": parseInt(sessionStorage.getItem(""aa"")),
            ""OrdeCancelInfo"": $(""#Recommend"").val()
        }
        var cc = JSON.st");
            WriteLiteral(@"ringify(obj);
        console.log(obj);
        $.ajax({
            url: ""http://localhost:2789/api/UptAll"",
            type:""post"",
            data: cc,
            dataType: ""json"",
            contentType: ""application/json"",
            success: function (d) {
                if (d > 0) {
                    alert(""取消成功！"");
                    Show();
                }
            }
        })
    }
</script>");
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

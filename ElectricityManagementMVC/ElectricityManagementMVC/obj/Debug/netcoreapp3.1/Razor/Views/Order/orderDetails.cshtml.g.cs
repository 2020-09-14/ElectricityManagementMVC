#pragma checksum "C:\Users\T\Desktop\ElectricityManagementMVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\Order\orderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c90e2f072c7a109daf1eb6c75590d05489512ed1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_orderDetails), @"mvc.1.0.view", @"/Views/Order/orderDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c90e2f072c7a109daf1eb6c75590d05489512ed1", @"/Views/Order/orderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ad30cce6f27a2ee55be4c4bc42dedba8309b7c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_orderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\T\Desktop\ElectricityManagementMVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\Order\orderDetails.cshtml"
  
    ViewData["Title"] = "orderDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<link href=""https://cdn.bootcss.com/bootstrap/3.3.7/css/bootstrap.min.css"" rel=""stylesheet"">

<script src=""https://cdn.bootcss.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>
<script src=""https://cdn.bootcss.com/jquery/3.3.1/jquery.js""></script>




");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c90e2f072c7a109daf1eb6c75590d05489512ed16704", async() => {
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
            BeginWriteAttribute("value", " value=\"", 482, "\"", 501, 1);
#nullable restore
#line 18 "C:\Users\T\Desktop\ElectricityManagementMVC\ElectricityManagementMVC\ElectricityManagementMVC\Views\Order\orderDetails.cshtml"
WriteAttributeValue("", 490, ViewBag.Is, 490, 11, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c90e2f072c7a109daf1eb6c75590d05489512ed18948", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c90e2f072c7a109daf1eb6c75590d05489512ed110128", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c90e2f072c7a109daf1eb6c75590d05489512ed111307", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c90e2f072c7a109daf1eb6c75590d05489512ed112486", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c90e2f072c7a109daf1eb6c75590d05489512ed113665", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c90e2f072c7a109daf1eb6c75590d05489512ed114844", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c90e2f072c7a109daf1eb6c75590d05489512ed116023", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c90e2f072c7a109daf1eb6c75590d05489512ed117202", async() => {
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
            BeginWriteAttribute("class", " class=\"", 1734, "\"", 1742, 0);
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
            url: ""http://localhost:2789/api/GetOderDetil?ids="" + $(""#ss"").val(),
            type: ""get"",
            dataType: ""json"",
            success: function (date) {
                $(""#div1"").empty();
                $.each(date, function (index, item) {
                    var str = '<div style=""width: 80%; height: 100px;  background-color: white; margin-right: 135px; margin-left: 150px; "">' +
                        '<br />' +
                        ' <br />' +
                        ' &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  &nbsp;' + '<span style=""font-size:16px;color:black"">订单号</span>&nbsp;  &nbsp;' + '<span style=""font-size:20px;color:black"">' + item.orderNumber + '</span>' +
                        '&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;  &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp; &emsp;&emsp;&emsp;&emsp; ' + '<button class=""btn btn-info"" data-toggle=""modal"" data-target=""#myModal"" onclick=""motai(' + ");
            WriteLiteral(@"item.orderId + ')"">取消订单</button>' +
                        ' &emsp; &emsp; <input id=""Button1"" type=""button"" value=""备注信息"" class=""btn btn-info"" />' +
                        ' </div>' +
                        '  <br />' +
                        ' <div style=""width: 80%; height: 240px;  background-color: white; margin-right: 135px; margin-left: 150px; "">' +
                        '<div style="" width: 25%; height: 240px; float: left; margin-right: 20px; margin-left: 20px"">' +
                        ' <br />' +
                        ' <p style=""font-size:21px;color:black"">&emsp;收货人信息</p>' +
                        ' <span style=""font-size:14px;color:black""> &emsp;收货人:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">' + item.buyerAddressName + '</span><br /><br />' +
                        '<span style=""font-size:14px;color:black""> &emsp;收货地址:</span>&nbsp;<span style=""font-size:14px;color:black"">' + item.buyerAddressInfo + '</span><br /><br />' +
                        ' <span style=");
            WriteLiteral(@"""font-size:14px;color:black""> &emsp;手机号:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">' + item.buyerAddressTel + '</span><br /><br />' +
                        ' <span style=""font-size:14px;color:black""> &emsp;用户留言:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">' + item.buyerInfoMess + '</span><br />' +

                        ' </div>' +
                        ' <div style=""width: 25%; height: 240px; float: left; margin-right: 20px; margin-left: 20px"">' +
                        '<br />' +
                        ' <p style=""font-size:21px;color:black"">&emsp;付款信息</p>' +
                        '<span style=""font-size:14px;color:black""> &emsp;付款方式:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">' + (item.orderPay == 1 ? ""线上支付"" : ""线下支付"") + '</span><br /><br />' +
                        ' <span style=""font-size:14px;color:black""> &emsp;商品总金额:</span>&emsp;<span style=""font-size:14px;color:black"">' + (item.goodsNum * item.goodsPrice) + '</span><br /><br />' +");
            WriteLiteral(@"
                        '<span style=""font-size:14px;color:black""> &emsp;运费金额:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">￥8</span><br /><br />' +
                        ' <span style=""font-size:14px;color:black""> &emsp;应支付金额:</span>&emsp; <span style=""font-size:14px;color:black"">' + (item.goodsNum * item.goodsPrice) + '</span><br />' +
                        '  </div>' +
                        ' <div style=""width: 25%; height: 240px; float: left; margin-right: 20px; margin-left: 20px"">' +
                        '  <br />' +
                        ' <p style=""font-size:21px;color:black"">&emsp;发票信息</p>' +
                        ' <span style=""font-size:14px;color:black""> &emsp;是否需要发票:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">是</span><br /><br />' +
                        '  <span style=""font-size:14px;color:black""> &emsp;发票抬头:</span>&emsp; &emsp; &emsp; &nbsp;<span style=""font-size:14px;color:black"">个人</span><br /><br />' +
                        ' <span sty");
            WriteLiteral(@"le=""font-size:14px;color:black""> &emsp;发票类型:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">电子发票</span><br /><br />' +
                        ' </div>' +
                        ' </div>' +
                        ' <br />' +
                        '  <div style=""width: 80%; height: 400px;  background-color: white; margin-right: 135px; margin-left: 150px; "">' +
                        ' <p style=""font-size:21px;color:black"">&emsp;商品信息</p>' +
                        '  <table class=""table"">' +
                        ' <tr>' +
                        '  <th>商品信息</th>' +
                        ' <th>单价</th>' +
                        ' <th>数量</th>' +
                        ' <th>小计</th>' +
                        ' <th>优惠信息</th>' +
                        ' <th>实付款</th>' +
                        ' </tr>' +
                        ' <tbody >' +
                        ' <tr>' +
                        '<td>' + '<img src=""http://localhost:2789' + item.goodsImg + '"" alt="""" width=");
            WriteLiteral(@"""40"" height=""40"" />' + item.goodsName + '&nbsp;' + item.goodsIntroduce + '</td>' +
                        ' <td>' + item.goodsPrice + '</td>' +
                        '   <td>' + item.goodsNum + '</td>' +
                        '  <td>' + (item.goodsNum * item.goodsPrice) + '</td>' +
                        '  <td>0.00</td>' +
                        '  <td>' + (item.goodsNum * item.goodsPrice) + '</td>' +
                        ' </tr>' +
                        '</tbody>' +
                        ' </table>' +
                        '<div style=""float:right"">' +
                        '  <span style=""font-size:14px;color:black""> &emsp;商品总额:</span>&emsp; &emsp;<span style=""font-size:14px;color:black"">' + (item.goodsNum * item.goodsPrice) + '</span><br /><br />' +
                        '  <span style=""font-size:14px;color:black""> &emsp;优惠金额:</span>&emsp;&emsp;<span style=""font-size:14px;color:black"">￥0.00</span><br /><br />' +
                        ' <span style=""font-size:14px;color:bl");
            WriteLiteral(@"ack""> &emsp;运费:</span>&emsp;&emsp; &emsp;&emsp;<span style=""font-size:14px;color:black"">￥8</span><br /><br />' +
                        '  <span style=""font-size:14px;color:red""> &emsp;  应付总额:</span>&emsp; &emsp;<span style=""font-size:20px;color:red"">' + (item.goodsNum * item.goodsPrice) + '</span><br />' +

                        '</div>' +
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
        var cc = JSON.stringify(obj);
        console.log(obj);
        $.ajax({
            url: ""http://localhost:2789/api/UptAll"",
            type:""post"",
            data: cc,
            dataType: ""json"",
  ");
            WriteLiteral("          contentType: \"application/json\",\r\n            success: function (d) {\r\n                if (d > 0) {\r\n                    alert(\"取消成功！\");\r\n                    Show();\r\n                }\r\n            }\r\n        })\r\n    }\r\n</script>\r\n");
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

#pragma checksum "E:\大一项目\MVC1\ElectricityManagementMVC\ElectricityManagementMVC\Views\Logistics\AddAddress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aee1043a1b60bd6b6dccab563fbd3b0310aa156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logistics_AddAddress), @"mvc.1.0.view", @"/Views/Logistics/AddAddress.cshtml")]
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
#line 1 "E:\大一项目\MVC1\ElectricityManagementMVC\ElectricityManagementMVC\Views\_ViewImports.cshtml"
using ElectricityManagementMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\大一项目\MVC1\ElectricityManagementMVC\ElectricityManagementMVC\Views\_ViewImports.cshtml"
using ElectricityManagementMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aee1043a1b60bd6b6dccab563fbd3b0310aa156", @"/Views/Logistics/AddAddress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ad30cce6f27a2ee55be4c4bc42dedba8309b7c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Logistics_AddAddress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/layui-v2.5.6/layui/css/layui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/201712091431/dist/checkbox.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("resources library"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/area.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layui-v2.5.6/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\大一项目\MVC1\ElectricityManagementMVC\ElectricityManagementMVC\Views\Logistics\AddAddress.cshtml"
  
    ViewData["Title"] = "AddAddress";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color:white\">新增地址</h1>\r\n<link href=\"https://cdn.bootcss.com/bootstrap-switch/3.3.4/css/bootstrap3/bootstrap-switch.min.css\" rel=\"stylesheet\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3aee1043a1b60bd6b6dccab563fbd3b0310aa1566410", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"https://cdn.bootcss.com/jquery/1.11.1/jquery.min.js\"></script>\r\n<script src=\"https://cdn.bootcss.com/bootstrap-switch/3.3.4/js/bootstrap-switch.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3aee1043a1b60bd6b6dccab563fbd3b0310aa1567708", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aee1043a1b60bd6b6dccab563fbd3b0310aa1568822", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""exampleInputEmail1"">地址简称</label>
        <input type=""text"" class=""form-control"" id=""Abbreviation"" placeholder=""地址简称"">
    </div>
    <div class=""form-group"">
        <label for=""exampleInputPassword1"">联系人</label>
        <input type=""text"" class=""form-control"" id=""Aconsigner"" placeholder=""联系人"">
    </div>
    <div class=""form-group"">
        <label for=""exampleInputPassword1"">手机号</label>
        <input type=""text"" class=""form-control"" id=""Aphone"" placeholder=""11位手机号"">
    </div>
    <div class=""form-group"">
        <label for=""exampleInputPassword1"">地址</label>
        <div class=""layui-input-inline"">
            <select id=""s_province"" name=""s_province""></select>
            <select id=""s_city"" name=""s_city""></select>
            <select id=""s_county"" name=""s_county""></select>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aee1043a1b60bd6b6dccab563fbd3b0310aa15610001", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <script type=""text/javascript"">_init_area();</script>
        </div>
        <div id=""show""></div>
    </div>
    <div class=""form-group"">
        <label for=""exampleInputPassword1"">详情地址</label>
        <input type=""text"" class=""form-control"" id=""Adeltailedaddress"" placeholder=""请输入详情地址"">
    </div>
    <div class=""form-group"">
        <label for=""exampleInputPassword1"">设为收货点</label>
        <input type=""checkbox"" id=""Adeliverypoint"" name=""my-checkbox"" checked>
    </div>
    <div class=""form-group"">
        <label for=""exampleInputPassword1"">设为发货点</label>
        <input type=""checkbox"" id=""Areceivingpoint"" name=""my-checkbox"" checked>
    </div>
    <input type=""button"" class=""btn btn-default"" style=""background-color:blue"" onclick=""Addc()"" value=""提交"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aee1043a1b60bd6b6dccab563fbd3b0310aa15613081", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>

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
        var county = Gid('s_county').value;
        if (province == city) {
            city = """";
        }
        Gid(""txtAddress"").value = province + city + county;
    }
    function Addc() {
        if (!(/^1[3456789]\d{9}$/.test($(""#Aphone"").val()))) {
            alert(""手机号码有误，请重填"");
            return;
        }
        else {
            if ($(""input[type='my-checkbox']"").is(':checked') == true) {
                var a = {
                    ""Abbreviation"": $(""#Abbreviation"").val(),
                    ""Aconsigner"": $(""#Aconsigner"").val(),
                    ""Aphone"": $(""#Aphone"").val(),
                    ""Address"": $(""#s_province");
            WriteLiteral(@""").val() + $(""#s_city"").val() + $(""#s_county"").val(),
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
        }
        var json1 = JSON.stringify(a);
        $.ajax({
            url: 'http://localhost:2789/api/AddAddressAsync',
            data: json1,
            type: 'post',
            dataType: ""json"",
            contentType: ""application/json"",");
            WriteLiteral(@"
            success: function (data) {
                if (data > 0) {
                    alert(""添加成功"");
                    location.href = '/Logistics/Index';
                }
                else {
                    alert(""添加失败"");
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

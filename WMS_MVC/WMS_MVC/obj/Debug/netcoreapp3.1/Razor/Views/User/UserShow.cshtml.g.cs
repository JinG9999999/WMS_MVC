#pragma checksum "D:\大实训2  仓库管理系统\WMS_MVC\WMS_MVC\WMS_MVC\Views\User\UserShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4b650be25fd508ddf96bed0da13eae21d61eb65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserShow), @"mvc.1.0.view", @"/Views/User/UserShow.cshtml")]
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
#line 1 "D:\大实训2  仓库管理系统\WMS_MVC\WMS_MVC\WMS_MVC\Views\_ViewImports.cshtml"
using WMS_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\大实训2  仓库管理系统\WMS_MVC\WMS_MVC\WMS_MVC\Views\_ViewImports.cshtml"
using WMS_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4b650be25fd508ddf96bed0da13eae21d61eb65", @"/Views/User/UserShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2675e3018d93bc97dc009e4184a70cdd1dc5a7", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
            <th>用户编号</th>
            <th>用户名</th>
            <th>用户昵称</th>
            <th>邮箱</th>
            <th>电话</th>
            <th>性别</th>
            <th>部门</th>
            <th>是否禁用</th>
            <th>创建时间</th>
            <th>修改时间</th>
            <th>角色</th>
            <th>操作</th>
        </tr>
    </thead>
    <tbody id=""tb"">
    </tbody>
</table>

<table class=""table"">
    <tr>
        <td style=""text-align: center; vertical-align: middle; color: #ff006e; font-family: STXingkai; font-weight: bolder; font-size: larger"">总记录数<span id=""TotalCount""></span>条</td>
        <td style=""text-align: center; vertical-align: middle; color: #ff006e; font-family: STXingkai; font-weight: bolder; font-size: larger"">总共<span id=""TotalPage""></span>页</td>
        <td style=""text-align: center; vertical-align: middle; color: #ff006e; font-family: STXingkai; font-weight: bolder; font-size: larger"">当前第<span id=""CurrentPage""></span>页</td>
 ");
            WriteLiteral(@"       <td style=""text-align: center; color: black; font-family: STXingkai; font-weight: bolder; font-size: larger"">
            <input id=""Button1"" type=""button"" value=""首页"" onclick=""Show(1)"" class=""btn btn-primary"" />
        </td>
        <td style=""text-align: center; color: black; font-family: STXingkai; font-weight: bolder; font-size: larger"">
            <input type=""button"" value=""◀"" onclick=""Show(currentPage - 1)"" class=""btn btn-primary"" />
        </td>
        <td style=""text-align: center; color: black; font-family: STXingkai; font-weight: bolder; font-size: larger"">
            <input type=""button"" value=""▶"" onclick=""Show(currentPage + 1)"" class=""btn btn-primary"" />
        </td>
        <td style=""text-align: center; color: black; font-family: STXingkai; font-weight: bolder; font-size: larger"">
            <input type=""button"" value=""尾页"" onclick=""Show(totalPage)"" class=""btn btn-primary"" />
        </td>
    </tr>
</table>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        var pageSize = 5;
        var currentPage = 1;
        var totalPage = 1;

        $(function () {
            Show(1);
        })

        function Show(page) {

            var obj = {};
            obj.currentPage = page;
            obj.pageSize = pageSize;

            $.ajax({
                url: 'http://localhost:63209/api/User/Get',
                type: 'get',
                dataType: 'json',
                data: obj,
                success: function (d) {

                    $(""#TotalCount"").text(d.totalCount)
                    $(""#TotalPage"").text(d.totalPage)
                    $(""#CurrentPage"").text(d.currentPage)
                    //最大页
                    totalPage = d.totalPage;
                    //当前页
                    currentPage = d.currentPage;

                    $(""#tb"").empty();
                    $(d.users).each(function () {
                        var line = '<tr>'
                            + '<td style=""text");
                WriteLiteral(@"-align: center;vertical-align:middle;color: #011b0a; font-family: STXingkai;font-size: larger;"">' + this.userId + '</td>'
                            + '<td style=""text-align: center;vertical-align:middle;color: #011b0a; font-family: STXingkai;font-size: larger;"">' + this.userName + '</td>'
                            + '<td style=""text-align: center;vertical-align:middle;color: #011b0a; font-family: STXingkai;font-size: larger;"">' + this.userNickname + '</td>'
                            + '<td style=""text-align: center;vertical-align:middle;color: #011b0a; font-family: STXingkai;font-size: larger;"">' + this.email + '</td>'
                            + '<td style=""text-align: center;vertical-align:middle;color: #011b0a; font-family: STXingkai;font-size: larger;"">' + this.tel + '</td>'
                            + '<td style=""text-align: center;vertical-align:middle;color: #011b0a; font-family: STXingkai;font-size: larger;"">' + (this.sex == true ? ""男"" : ""女"") + '</td>'
                            + '<t");
                WriteLiteral(@"d style=""text-align: center;vertical-align:middle;color: #011b0a; font-family: STXingkai;font-size: larger;"">' + this.deptName + '</td>'
                            + '<td style=""text-align: center;vertical-align:middle;color: #011b0a; font-family: STXingkai;font-size: larger;"">' + (this.isOK == true ? ""启用"" : ""禁用"") + '</td>'
                            + '<td style=""text-align: center;vertical-align:middle;color: #011b0a; font-family: STXingkai;font-size: larger;"">' + this.createDate + '</td>'
                            + '<td style=""text-align: center;vertical-align:middle;color: #011b0a; font-family: STXingkai;font-size: larger;"">' + this.modifiedDate + '</td>'
                            + '<td style=""text-align: center;vertical-align:middle;color: #011b0a; font-family: STXingkai;font-size: larger;"">' + this.roleName + '</td>'
                            + '<td style=""text-align: center;vertical-align:middle;color: #011b0a; font-family: STXingkai;font-size: larger;"">' + (this.isOK == true ? ""<input i");
                WriteLiteral(@"d='Button1' type='button' value='禁用' class='btn btn-danger' onclick=UptUser("" + this.userId + "") />"" : ""<input id='Button1' type='button' value='启用' class='btn btn-danger' onclick=UptUser1("" + this.userId + "") />"")
                            
                            + '</td>'
                            + '</tr>';
                        $(""#tb"").append(line);
                    })
                }


            })
        }

        //修改状态（是否启用）
        function UptUser(id) {
            $.ajax({
                url: 'http://localhost:63209/api/User/PutUser/' + id,
                type: 'put',
                dataType: 'json',
                data: JSON.stringify({ UserId: id }),
                contentType: ""application/json"",
                success: function (d) {
                    if (d > 0) {
                        Show();
                    }
                    else {
                        alert('操作失败！');
                    }
                }
            })
");
                WriteLiteral(@"        }
        function UptUser1(id) {
            $.ajax({
                url: 'http://localhost:63209/api/User/PutUser1/' + id,
                type: 'put',
                dataType: 'json',
                data: JSON.stringify({ UserId: id }),
                contentType: ""application/json"",
                success: function (d) {
                    if (d > 0) {
                        Show();
                    }
                    else {
                        alert('操作失败！');
                    }
                }
            })
        }
    </script>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4b650be25fd508ddf96bed0da13eae21d61eb6511205", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4b650be25fd508ddf96bed0da13eae21d61eb6512384", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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

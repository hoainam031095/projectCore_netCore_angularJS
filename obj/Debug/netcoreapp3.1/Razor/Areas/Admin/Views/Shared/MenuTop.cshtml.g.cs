#pragma checksum "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\Shared\MenuTop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "311dfe7060c42a5fef29582a4b3fe476f961ec5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_MenuTop), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/MenuTop.cshtml")]
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
#line 1 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\Shared\MenuTop.cshtml"
using CongThongTin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\Shared\MenuTop.cshtml"
using CongThongTin.App_Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\Shared\MenuTop.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\Shared\MenuTop.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\Shared\MenuTop.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"311dfe7060c42a5fef29582a4b3fe476f961ec5d", @"/Areas/Admin/Views/Shared/MenuTop.cshtml")]
    public class Areas_Admin_Views_Shared_MenuTop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"sidebar-nav\">\r\n    <li>\r\n        <a href=\"/admin\"><i class=\"fa fa-home\"></i><span class=\"sidebar-nav-mini-hide\"> Trang chủ</span></a>\r\n    </li>\r\n");
#nullable restore
#line 10 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\Shared\MenuTop.cshtml"
      
        var acSession = Context.Session.GetString("AccountSession");
        AccountSession sessionAccount = acSession == null ? default(AccountSession) : JsonConvert.DeserializeObject<AccountSession>(acSession);

        congthongtinContext db = new congthongtinContext();
        var menuTop = db.TbController.Where(a => a.IsActive == true && a.ParentId == null && a.Level != 0 && a.IsDelete == false).ToList().OrderBy(a => a.SortValue);
        foreach (var menu in menuTop)
        {
            if (checkIsPermissionMenu(menu))
            {
                string itemtext = "";
                if (Context.Request.GetEncodedUrl().Contains(menu.Controller))
                {
                    itemtext = (string.Format("<li class='active'><a href='#' class='sidebar-nav-menu'><i class='fa fa-angle-left sidebar-nav-indicator sidebar-nav-mini-hide'></i><span class='sidebar-nav-mini-hide'>{0}</span></a>", menu.Display == null ? menu.Controller : menu.Display));
                }
                else
                {
                    itemtext = (string.Format("<li><a href='#' class='sidebar-nav-menu'><i class='fa fa-angle-left sidebar-nav-indicator sidebar-nav-mini-hide'></i><i class='fa fa-star-o'></i><span class='sidebar-nav-mini-hide'> {0}</span></a>", menu.Display == null ? menu.Controller : menu.Display));
                }
                itemtext += GetMenuItem(menu);
                itemtext += "</li>";
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\Shared\MenuTop.cshtml"
           Write(Html.Raw(itemtext));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\Shared\MenuTop.cshtml"
                                   ;
            }

        }
        bool checkIsPermissionMenu(TbController menu)
        {
            bool isPermission = false;
            using (congthongtinContext db = new congthongtinContext())
            {
                if (db.TbAction.Any(a => a.ControllerId == menu.Id && a.IsActive == true && a.IsDelete == false
                && (a.TbRoleGroupAction.Any(b => b.IsActive == true && (b.Id == sessionAccount.RoleGroupId) && b.RoleGroup.IsActive == true) 
                || sessionAccount.UserName == "admin1234$#@!")) || (menu.ParentId == null && menu.Level == 1))
                {
                    isPermission = true;
                }

                if (isPermission == false)
                {
                    var menus = db.TbController.Where(a => a.IsActive == true && a.ParentId == menu.Id);
                    if (menus.Any())
                    {
                        foreach (var mn in menus)
                        {
                            if (checkIsPermissionMenu(mn))
                            {
                                isPermission = true;
                                break;
                            }
                        }
                    }
                }
                return isPermission;
            }
        }

        string GetMenuItem(TbController ParentMenu)
        {
            string menuUl = "";
            var menus = db.TbController.Where(a => a.ParentId == ParentMenu.Id && a.IsActive == true && a.IsDelete == false).ToList();
            if (menus.Count() > 0)
            {
                menuUl = "<ul>";
                foreach (var menu in menus)
                {
                    if (checkIsPermissionMenu(menu))
                    {
                        string extend = GetMenuItem(menu);
                        string url = "#";
                        string menuActive = "";
                        //if (menu.m_action.Any())
                        if (db.TbAction.Any(ac => ac.ControllerName == menu.Controller))
                        {
                            url = menu.Url;
                            if (Context.Request.GetEncodedUrl().Contains(url))
                            {
                                menuActive = "active";
                            }
                        }
                        string menuIsParent = extend.Length > 0 ? "sidebar-nav-menu" : "";
                        string menuclass = string.Format("class='{0} {1}'", menuActive, menuIsParent);
                        string menunav = extend.Length > 0 ? "<i class='fa fa-angle-left sidebar-nav-indicator sidebar-nav-mini-hide'></i>" : "";
                        menuUl += string.Format("<li><a href='{4}' {2}>{3} + <span class='sidebar-nav-mini-hide'>{0}</span></a><ul>{1}</ul></li>", menu.Display == null ? menu.Controller : menu.Display, extend, menuclass, menunav, url);
                    }
                }
                menuUl += "</ul>";
            }
            return menuUl;
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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

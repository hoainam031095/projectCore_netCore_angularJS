#pragma checksum "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\MgRole\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a352292383fe1ed6eaa367b228406974a74c65cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MgRole_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/MgRole/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a352292383fe1ed6eaa367b228406974a74c65cc", @"/Areas/Admin/Views/MgRole/Index.cshtml")]
    public class Areas_Admin_Views_MgRole_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/Content/page/MgRole.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\MgRole\Index.cshtml"
  
    ViewData["Title"] = "Nhóm quyền";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a352292383fe1ed6eaa367b228406974a74c65cc3692", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<ul class=""breadcrumb breadcrumb-top"">
    Hệ thống >
    <a href=""#"">Nhóm quyền</a>
</ul>
<div class=""block"" ng-controller=""RolePage"">
    <div class=""block-title"">
        <div class=""block-options pull-right"">
            <a href=""javascript:void(0)"" class=""btn btn-alt btn-sm btn-primary hint--top"" aria-label=""Thu nhỏ"" data-toggle=""block-toggle-content""><i class=""fa fa-arrows-v""></i></a>
            <a href=""javascript:void(0)"" class=""btn btn-alt btn-sm btn-primary hint--top"" aria-label=""Toàn màn hình"" data-toggle=""block-toggle-fullscreen""><i class=""fa fa-desktop""></i></a>
            <div class=""btn-group hint--top"" aria-label=""Khác"" ]"">
                <a class=""btn btn-alt btn-sm btn-primary dropdown-toggle"" data-toggle=""dropdown"" href=""javascript:void(0)"" aria-expanded=""false""><i class=""fa fa-angle-down""></i></a>
                <ul class=""dropdown-menu dropdown-custom dropdown-menu-right"">
                    <li>
                        <a href=""javascript:void(0)"" ng-click=""loadFormAddN");
            WriteLiteral(@"ewRole()"">Thêm nhóm quyền</a>
                    </li>
                    <li class=""divider""></li>
                    <li><a href=""javascript:void(0)"">Đóng</a></li>
                </ul>
            </div>
        </div>
        <h2><strong>Danh sách nhóm quyền</strong></h2>
    </div>

");
            WriteLiteral("    <div class=\"block-content\">\r\n        <div>\r\n            ");
#nullable restore
#line 34 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\MgRole\Index.cshtml"
       Write(Html.Partial("~/Areas/Admin/Views/PartialGlobal/filterTable.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-12"">
                    <table id=""list_role"" class=""table table-vcenter table-condensed table-bordered"" ui-jq=""dataTable"" ui-options=""dataTableOpt"">
                        <thead>
                            <tr>
                                <th class=""text-center"">STT</th>
                                <th class=""text-center"" ng-click=""sortBy = 'groupName'; sortType = !sortType"">
                                    Tên nhóm quyền <i class=""fa {{getIconSort(sortBy, 'groupName', sortType)}}""></i>
                                </th>
                                <th class=""text-center"" ng-click=""sortBy = 'description'; sortType = !sortType"">
                                    Mô tả <i class=""fa {{getIconSort(sortBy, 'description', sortType)}}""></i>
                                </th>
                                <th class=""text-center"">Trạng thái</th>
                                <th class=""text-center"">Xử lý</t");
            WriteLiteral(@"h>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat=""item in dataPagingRole() | orderBy:sortBy:sortType"">
                                <td class=""text-center"">{{data.indexOf(item) + 1}}</td>
                                <td>{{item.groupName}}</td>
                                <td>{{item.description}}</td>
                                <td>{{item.isActive === true ? 'Có hiệu lực' : 'Không hiệu lực'}}</td>
                                <td class=""hander text-center"">
                                    <a");
            BeginWriteAttribute("href", " href=\'", 3330, "\'", 3337, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default hint--top\" aria-label=\"Chỉnh sửa\" ng-click=\"loadFormEditRole(item)\"> <i class=\"fa fa-pencil\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\'", 3503, "\'", 3510, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default hint--top\" aria-label=\"Cài đặt\" ng-click=\"loadFormActionOfRole(item)\"> <i class=\"fa fa-cogs\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\'", 3676, "\'", 3683, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-default hint--top"" aria-label=""Xóa nhóm quyền"" ng-click=""confirmDeleteRole(item)"" style=""color: red;""><i class=""fa fa-trash-o""></i></a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            ");
#nullable restore
#line 67 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\MgRole\Index.cshtml"
       Write(Html.Partial("~/Areas/Admin/Views/PartialGlobal/pagingTable.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
            WriteLiteral(@"    <div class=""modal fade"" id=""modal-add-role"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"" style=""background-color: #367fa9; color: #fff;"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                    <h3 class=""modal-title"">Thêm nhóm quyền {{RoleAdd.TenKho}}</h3>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label");
            BeginWriteAttribute("for", " for=\"", 4804, "\"", 4810, 0);
            EndWriteAttribute();
            WriteLiteral(">Tên nhóm quyền (*):</label>\r\n                        <input name=\"tenKho\" class=\"form-control\" ng-model=\"RoleAdd.groupName\" />\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label");
            BeginWriteAttribute("for", " for=\"", 5044, "\"", 5050, 0);
            EndWriteAttribute();
            WriteLiteral(@">Mô tả:</label>
                        <input name=""diaChi"" class=""form-control"" ng-model=""RoleAdd.description"" />
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default pull-left"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn btn-primary"" ng-click=""addNewRole()"">Thêm</button>
                </div>
            </div>
        </div>
    </div>
");
            WriteLiteral("\r\n");
            WriteLiteral(@"    <div class=""modal modal-danger fade"" id=""modal-confirm-delete-role"">
        <div class=""modal-dialog"">
            <form>
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                        <h4 class=""modal-title"">Xác nhận thao tác xóa</h4>
                    </div>
                    <div class=""modal-body"">
                        <h3>Bạn có muốn xóa nhóm quyền ""{{roleDelete.groupName}}""?</h3>
                    </div>
                    <div class=""modal-footer"">
                        <input class=""btn btn-default pull-left"" data-dismiss=""modal"" value=""Hủy"" style=""width: 55px;"">
                        <button type=""submit"" class=""btn btn-danger"" ng-click=""deleteRole()"" data-dismiss=""modal"">Thực hiện xóa</button>
                    <");
            WriteLiteral("/div>\r\n                </div>\r\n            </form>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"    <div class=""modal fade edit"" id=""modal-view-modul-role"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"" style=""background-color: #367fa9; color: #fff;"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                    <h3 class=""modal-title"">Quản lý quyền nhóm "" {{roleViewAction.groupName}} ""</h3>
                </div>
                <div class=""modal-body"">
                    <h4>
                        Các quyền hiện có ( {{(listActionOfRole | filter: {checkeds: true}).length }}/{{(listActionOfRole).length}} )
                    </h4>
                    <div class=""row"">
                        <div class=""col-xs-12"">
                            <div class=""box"">
                                <!-- /.box-header -->
                                <div class=""box-body""");
            WriteLiteral(@">
                                    <ul class=""sidebar-nav"">
                                        <li ng-repeat=""item in model.jModul"">
                                            <a href=""javascript: void(0)"" class=""sidebar-nav-menu"">
                                                <span>{{item.controllerDispay === null ? item.controllerName: item.controllerDispay}} ( {{(item.listAction | filter: {checkeds: true}).length}}/{{item.listAction.length}} )</span>
                                            </a>
                                            <div class=""sidebar-menu"">
                                                <ul style=""list-style-type: none;"">
                                                    <li ng-repeat=""item1 in item.listAction"">
                                                        <input type=""checkbox"" ng-model=""item1.checkeds"" class=""flat-red"" />
                                                        {{item1.display === null ? (item1.name === null ? item1.action : i");
            WriteLiteral(@"tem1.name) : item1.display}}
                                                    </li>
                                                </ul>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                                <!-- /.box-body -->
                            </div>
                            <!-- /.box -->
                        </div>
                        <!-- /.col -->
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-danger pull-left"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" ng-click=""luuCaiDatQuyen()"" class=""btn btn-primary pull-right"" data-dismiss=""modal"">Lưu</button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
");
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n            //myApp = angular.module(\"myapp\", []);\r\n        myApp.controller(\'RolePage\', [\'$scope\', \'$http\', function ($scope, $http) {\r\n\r\n            $scope.model = ");
#nullable restore
#line 184 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\MgRole\Index.cshtml"
                      Write(Html.Raw(Json.Serialize(Model.Value)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            $scope.data = $scope.model.jRole;
            //Sort
            $scope.sortBy = Object.keys($scope.data[0])[1];
            $scope.sortType = false;

            //Paging
            $scope.totalItems = function () { return $scope.data.length; };
            $scope.currentPage = 1;
            $scope.itemsOnPage = 30;
            $scope.maxSize = 5;
            $scope.dataPagingRole = function () {
                return $scope.loadDataPaging($scope.data, $scope.currentPage, $scope.itemsOnPage);
            }
            //End paging

            //Form add new nhóm quyền
            $scope.loadFormAddNewRole = function () {
                $scope.RoleAdd = {};
                $(""#modal-add-role"").modal(""show"");
            };
            $scope.addNewRole = function () {
                var statusCode = {
                    200: function (res) {
                        if (res.success) {
                            $scope.RoleAdd.id = res.idNew;
                     ");
                WriteLiteral(@"       $scope.model.jRole.push($scope.RoleAdd);
                            $(""#modal-add-role"").modal(""hide"");
                            swal(res.message, """", ""success"");
                            $scope.$applyAsync();
                        }
                        else {
                            swal(res.message, """", ""error"");
                        }
                    }
                }
                AjaxPostData(""/admin/MgRole/AddNewRole"", { newRole: $scope.RoleAdd }, statusCode);
            };

            //Form confirm delete nhóm quyền
            $scope.confirmDeleteRole = function (role) {
                $scope.roleDelete = role;
                $(""#modal-confirm-delete-role"").modal(""show"");
            };
            //Thực hiện xóa nhóm quyền
            $scope.deleteRole = function () {
                $(""#modal-confirm-delete-role"").modal(""hide"");
                var indexRoleDelete = $scope.model.jRole.findIndex(rl => rl.id === $scope.roleDelete.id);
    ");
                WriteLiteral(@"            var statusCode = {
                    200: function (res) {
                        if (res.success) {
                            swal(res.message, """", ""success"");
                            $scope.model.jRole.splice(indexRoleDelete, 1);
                            $scope.$applyAsync();
                        }
                        else {
                            swal(res.message, """", ""error"");
                        }
                    }
                }
                AjaxPostData(""/admin/MgRole/DeleteRole"", { roleId: $scope.roleDelete.id }, statusCode);

            };

            $scope.loadFormActionOfRole = function (item) {
                $scope.roleViewAction = item;
                $scope.listActionOfRole = [];

                $scope.model.jModul.forEach(function(modul){
                    modul.listAction.forEach(function(action){
                        var index = $scope.model.jRoleAction.findIndex(rlAc => rlAc.actionId === action.id && rlAc.rol");
                WriteLiteral(@"eGroupId == item.id);
                        action.checkeds = index >= 0 ? true : false;
                        $scope.listActionOfRole.push(action);
                    })
                })

                $(""#modal-view-modul-role"").modal(""show"");
            };

            scope = $scope;
            }]);
    </script>

    <script type=""text/javascript"">
        $(function () {
            var isactive;
            $(""#modal-view-modul-role ul.sidebar-nav li"").on(""click"", function () {
                var $this = this;
                $(""#modal-view-modul-role ul.sidebar-nav li"").each(function (index, item) {
                    if ($this != item) {
                        $(item).removeClass(""active"");
                    }
                })
                if (this != isactive) {
                    $(this).addClass(""active"");
                    isactive = this;
                }
                else {
                    $(this).removeClass(""active"");
              ");
                WriteLiteral("      isactive = null;\r\n                }\r\n            });\r\n        })\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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

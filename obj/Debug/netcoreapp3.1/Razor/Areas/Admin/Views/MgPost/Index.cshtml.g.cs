#pragma checksum "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\MgPost\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2813ea167e13b2be15f27b381bd1872d6e5dcb4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MgPost_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/MgPost/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2813ea167e13b2be15f27b381bd1872d6e5dcb4c", @"/Areas/Admin/Views/MgPost/Index.cshtml")]
    public class Areas_Admin_Views_MgPost_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\code\code C#\Hoainam1\netCore\CongThongTin\CongThongTin\Areas\Admin\Views\MgPost\Index.cshtml"
  
    ViewData["Title"] = "Bài viết";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<ul class=""breadcrumb breadcrumb-top"">
    Hệ thống >
    <a href=""#"">Bài viết</a>
</ul>
<div class=""block"">
    <div class=""block-title"">
        <div class=""block-options pull-right"">
            <a href=""javascript:void(0)"" class=""btn btn-alt btn-sm btn-primary hint--top"" aria-label=""Thu nhỏ"" data-toggle=""block-toggle-content""><i class=""fa fa-arrows-v""></i></a>
            <a href=""javascript:void(0)"" class=""btn btn-alt btn-sm btn-primary hint--top"" aria-label=""Toàn màn hình"" data-toggle=""block-toggle-fullscreen""><i class=""fa fa-desktop""></i></a>
            <div class=""btn-group hint--top"" aria-label=""Khác"" ]"">
                <a class=""btn btn-alt btn-sm btn-primary dropdown-toggle"" data-toggle=""dropdown"" href=""javascript:void(0)"" aria-expanded=""false""><i class=""fa fa-angle-down""></i></a>
                <ul class=""dropdown-menu dropdown-custom dropdown-menu-right"">
                    <li>
                        <a href=""javascript:void(0)"">Thêm bài viết</a>
                    </li>
 ");
            WriteLiteral(@"                   <li>
                        <a href=""javascript:void(0)"" onclick=""reloadTable()"">Danh sách bài viết</a>
                    </li>
                    <li class=""divider""></li>
                    <li><a href=""javascript:void(0)"">Đóng</a></li>
                </ul>
            </div>
        </div>
        <h2><strong>Danh sách bài viết</strong></h2>
    </div>

");
            WriteLiteral(@"    <div class=""block-content"">
        <div ng-controller=""validationCtrl"">
            <table class=""table"">
                <tr ng-repeat=""row in dataPaging()"">
                    <td>{{row.name}}</td>
                    <td>{{row.id}}</td>
                </tr>
            </table>
            <div class=""row row-paging"">
                <div class=""col-sm-4 info-paging"">
                    <span> Trang {{currentPage}} / {{numPages}} ( tổng cộng có {{totalItems}} bản ghi )</span>
                </div>
                <div class=""col-sm-8 text-right"">
                    <pagination total-items=""totalItems""
                                ng-model=""currentPage""
                                max-size=""maxSize""
                                items-per-page=""itemsOnPage""
                                num-pages=""numPages""
                                previous-text=""Trước"" next-text=""Tiếp"" first-text=""Đầu"" last-text=""Cuối""
                                class=""pagination-sm"" boun");
            WriteLiteral("dary-links=\"true\">\r\n                    </pagination>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        //var scope;
        //myApp = angular.module(""myapp"", []);
        myApp.controller('validationCtrl', ['$scope', '$http', function ($scope, $http) {
            $scope.data = [{ ""name"": ""Bell"", ""id"": ""K0H 2V1"" }, { ""name"": ""Bell"", ""id"": ""K0H 2V5"" }, { ""name"": ""Octavius"", ""id"": ""X1E 6J0"" }, { ""name"": ""Alexis"", ""id"": ""N6E 1L6"" }, { ""name"": ""Colton"", ""id"": ""U4O 1H4"" }, { ""name"": ""Abdul"", ""id"": ""O9Z 2Q8"" }, { ""name"": ""Ian"", ""id"": ""Q7W 8M4"" }, { ""name"": ""Eden"", ""id"": ""H8X 5E0"" }, { ""name"": ""Britanney"", ""id"": ""I1Q 1O1"" }, { ""name"": ""Ulric"", ""id"": ""K5J 1T0"" }, { ""name"": ""Geraldine"", ""id"": ""O9K 2M3"" }, { ""name"": ""Hamilton"", ""id"": ""S1D 3O0"" }, { ""name"": ""Melissa"", ""id"": ""H9L 1B7"" }, { ""name"": ""Remedios"", ""id"": ""Z3C 8P4"" }, { ""name"": ""Ignacia"", ""id"": ""K3B 1Q4"" }, { ""name"": ""Jaime"", ""id"": ""V6O 7C9"" }, { ""name"": ""Savannah"", ""id"": ""L8B 8T1"" }, { ""name"": ""Declan"", ""id"": ""D5Q 3I9"" }, { ""name"": ""Skyler"", ""id"": ""I0O 4O8"" }, { ""name"": ""Lawrence"", ""id"": ""V4K 0L2"" }, { ""name"": ""Yael"", ""id"": ""R5E 9D9"" ");
                WriteLiteral(@"}, { ""name"": ""Herrod"", ""id"": ""V5W 6L3"" }, { ""name"": ""Lydia"", ""id"": ""G0E 2K3"" }, { ""name"": ""Tobias"", ""id"": ""N9P 2V5"" }, { ""name"": ""Wing"", ""id"": ""T5M 0E2"" }, { ""name"": ""Callum"", ""id"": ""L9P 3W5"" }, { ""name"": ""Tiger"", ""id"": ""R9A 4E4"" }, { ""name"": ""Summer"", ""id"": ""R4B 4Q4"" }, { ""name"": ""Beverly"", ""id"": ""M5E 4V4"" }, { ""name"": ""Xena"", ""id"": ""I8G 6O1"" }, { ""name"": ""Yael"", ""id"": ""L1K 5C3"" }, { ""name"": ""Stacey"", ""id"": ""A4G 1S4"" }, { ""name"": ""Marsden"", ""id"": ""T1J 5J3"" }, { ""name"": ""Uriah"", ""id"": ""S9S 8I7"" }, { ""name"": ""Kamal"", ""id"": ""Y8Z 6X0"" }, { ""name"": ""MacKensie"", ""id"": ""W2N 7P9"" }, { ""name"": ""Amelia"", ""id"": ""X7A 0U3"" }, { ""name"": ""Xavier"", ""id"": ""B8I 6C9"" }, { ""name"": ""Whitney"", ""id"": ""H4M 9U2"" }, { ""name"": ""Linus"", ""id"": ""E2W 7U1"" }, { ""name"": ""Aileen"", ""id"": ""C0C 3N2"" }, { ""name"": ""Keegan"", ""id"": ""V1O 6X2"" }, { ""name"": ""Leonard"", ""id"": ""O0L 4M4"" }, { ""name"": ""Honorato"", ""id"": ""F4M 8M6"" }, { ""name"": ""Zephr"", ""id"": ""I2E 1T9"" }, { ""name"": ""Karen"", ""id"": ""H8W 4I7"" }, { ""name"": ""Orlando"", ""id"": ""L8R 0U4"" }, { ""name"": ");
                WriteLiteral(@"""India"", ""id"": ""N8M 8F4"" }, { ""name"": ""Luke"", ""id"": ""Q4Y 2Y8"" }, { ""name"": ""Sophia"", ""id"": ""O7F 3F9"" }, { ""name"": ""Faith"", ""id"": ""B8P 1U5"" }, { ""name"": ""Dara"", ""id"": ""J4A 0P3"" }, { ""name"": ""Caryn"", ""id"": ""D5M 8Y8"" }, { ""name"": ""Colton"", ""id"": ""A4Q 2U1"" }, { ""name"": ""Kelly"", ""id"": ""J2E 2L3"" }, { ""name"": ""Victor"", ""id"": ""H1V 8Y5"" }, { ""name"": ""Clementine"", ""id"": ""Q9R 4G8"" }, { ""name"": ""Dale"", ""id"": ""Q1S 3I0"" }, { ""name"": ""Xavier"", ""id"": ""Z0N 0L5"" }, { ""name"": ""Quynn"", ""id"": ""D1V 7B8"" }, { ""name"": ""Christine"", ""id"": ""A2X 0Z8"" }, { ""name"": ""Matthew"", ""id"": ""L1H 2I4"" }, { ""name"": ""Simon"", ""id"": ""L2Q 7V7"" }, { ""name"": ""Evan"", ""id"": ""Z8Y 6G8"" }, { ""name"": ""Zachary"", ""id"": ""F4K 8V9"" }, { ""name"": ""Deborah"", ""id"": ""I0D 4J6"" }, { ""name"": ""Carl"", ""id"": ""X7H 3J3"" }, { ""name"": ""Colin"", ""id"": ""C8P 0O1"" }, { ""name"": ""Xenos"", ""id"": ""K3S 1H5"" }, { ""name"": ""Sonia"", ""id"": ""W9C 0N3"" }, { ""name"": ""Arsenio"", ""id"": ""B0M 2G6"" }, { ""name"": ""Angela"", ""id"": ""N9X 5O7"" }, { ""name"": ""Cassidy"", ""id"": ""T8T 0Q5"" }, { ""name"": ""Sebastian"", ""id""");
                WriteLiteral(@": ""Y6O 0A5"" }, { ""name"": ""Bernard"", ""id"": ""P2K 0Z5"" }, { ""name"": ""Kerry"", ""id"": ""T6S 4T7"" }, { ""name"": ""Uriel"", ""id"": ""K6G 5V2"" }, { ""name"": ""Wanda"", ""id"": ""S9G 2E5"" }, { ""name"": ""Drake"", ""id"": ""G3G 8Y2"" }, { ""name"": ""Mia"", ""id"": ""E4F 4V8"" }, { ""name"": ""George"", ""id"": ""K7Y 4L4"" }, { ""name"": ""Blair"", ""id"": ""Z8E 0F0"" }, { ""name"": ""Phelan"", ""id"": ""C5Z 0C7"" }, { ""name"": ""Margaret"", ""id"": ""W6F 6Y5"" }, { ""name"": ""Xaviera"", ""id"": ""T5O 7N5"" }, { ""name"": ""Willow"", ""id"": ""W6K 3V0"" }, { ""name"": ""Alden"", ""id"": ""S2M 8C1"" }, { ""name"": ""May"", ""id"": ""L5B 2H3"" }, { ""name"": ""Amaya"", ""id"": ""Q3B 7P8"" }, { ""name"": ""Julian"", ""id"": ""W6T 7I6"" }, { ""name"": ""Colby"", ""id"": ""N3Q 9Z2"" }, { ""name"": ""Cole"", ""id"": ""B5G 0V7"" }, { ""name"": ""Lana"", ""id"": ""O3I 2W9"" }, { ""name"": ""Dieter"", ""id"": ""J4A 9Y6"" }, { ""name"": ""Rowan"", ""id"": ""I7E 9U4"" }, { ""name"": ""Abraham"", ""id"": ""S7V 0W9"" }, { ""name"": ""Eleanor"", ""id"": ""K7K 9P4"" }, { ""name"": ""Martina"", ""id"": ""V0Z 5Q7"" }, { ""name"": ""Kelsie"", ""id"": ""R7N 7P2"" }, { ""name"": ""Hedy"", ""id"": ""B7E 7F2"" }, { ""name"":");
                WriteLiteral(@" ""Hakeem"", ""id"": ""S5P 3P6"" }];

            $scope.dataPaging = function () {
                $scope.totalItems = $scope.data.length;
                $scope.currentPage = 1;
                $scope.itemsOnPage = 10;
                $scope.maxSize = 5;
                return $scope.loadDataPaging($scope.data, $scope.currentPage, $scope.itemsOnPage);
            }

            scope = $scope;
        }]);


    </script>
");
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
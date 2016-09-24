var Daily;
(function (Daily) {
    var Base;
    (function (Base) {
        var Lib;
        (function (Lib) {
        })(Lib = Base.Lib || (Base.Lib = {}));
    })(Base = Daily.Base || (Daily.Base = {}));
})(Daily || (Daily = {}));
/// <reference path="../references.ts" />
'use strict';
var Daily;
(function (Daily) {
    var Module;
    (function (Module) {
        var Home = (function () {
            function Home() {
            }
            Home.Configure = function (module) {
                module.controller('HomeCtrl', function ($scope, $filter, $location) {
                    $scope.InitHome = function (homeModel) {
                        $scope.LawNewsList = homeModel.LawNewsList;
                        $scope.LawNewsFirst = homeModel.LawNewsFirst;
                        $scope.WorldNewsList = homeModel.WorldNewsList;
                        $scope.WorldNewsFirst = homeModel.WorldNewsFirst;
                        $scope.SocietyNewsList = homeModel.SocietyNewsList;
                        $scope.SocietyNewsFirst = homeModel.SocietyNewsFirst;
                        $scope.SportNewsList = homeModel.SportNewsList;
                        $scope.SportNewsFirst = homeModel.SportNewsFirst;
                        $scope.EntertaimentNewsList = homeModel.EntertaimentNewsList;
                        $scope.LifeNewsList = homeModel.LifeNewsList;
                        $scope.HotNewsToday = homeModel.HotNewsToday;
                        $scope.HotNewsTodayList = homeModel.HotNewsTodayList;
                        $scope.TopLeftNewsList = homeModel.TopLeftNewsList;
                        $scope.TopRightNewsList = homeModel.TopRightNewsList;
                    };
                });
            };
            Home.$inject = ['$scope', '$filter', '$location'];
            return Home;
        }());
        Module.Home = Home;
    })(Module = Daily.Module || (Daily.Module = {}));
})(Daily || (Daily = {}));
/// <reference path="../references.ts" />
'use strict';
var Daily;
(function (Daily) {
    var Module;
    (function (Module) {
        var News = (function () {
            function News() {
            }
            News.Configure = function (module) {
                module.controller('NewsCtrl', function ($scope, $filter, $location) {
                    $scope.InitNews = function (newsModel) {
                        $scope.LinkTree = newsModel.LinkTree;
                        $scope.ViewNews = newsModel.ViewNews;
                        $scope.FocusNewsList = newsModel.FocusNewsList;
                        $scope.HotNewsList = newsModel.HotNewsList;
                    };
                    $scope.InitCategory = function (cateModel) {
                        $scope.LeftNewsList = cateModel.LeftNewsList;
                        $scope.RightNewsList = cateModel.RightNewsList;
                        $scope.FocusNewsList = cateModel.FocusNewsList;
                        $scope.InterestingNewsList = cateModel.InterestingNewsList;
                    };
                });
            };
            News.$inject = ['$scope', '$filter', '$location'];
            return News;
        }());
        Module.News = News;
    })(Module = Daily.Module || (Daily.Module = {}));
})(Daily || (Daily = {}));
/// <reference path="base.ts" />
/// <reference path="typings/jquery/jquery.d.ts" /> 
/// <reference path="typings/angularjs/angular.d.ts"/> 
/// <reference path="typings/angularjs/angular-animate.d.ts"/> 
/// <reference path="typings/angularjs/angular-cookies.d.ts"/> 
/// <reference path="typings/angularjs/angular-mocks.d.ts"/> 
/// <reference path="typings/angularjs/angular-resource.d.ts"/> 
/// <reference path="typings/angularjs/angular-route.d.ts"/> 
/// <reference path="typings/angularjs/angular-sanitize.d.ts"/> 
/// <reference path="controllers/app.module.home.ts" />
/// <reference path="controllers/app.module.news.ts" /> 
/// <reference path="references.ts" />
'use strict';
(function () {
    var dailyApp = angular.module("dailyApp", ['ngSanitize']);
    dailyApp.filter('unsafe', function ($sce) { return $sce.trustAsHtml; });
    //eposApp.config(function ($stateProvider, $urlRouterProvider) {
    //    $urlRouterProvider.otherwise("/");
    //    $stateProvider
    //        .state("inventoryInputDetail", {
    //            url: '/InventoryInputDetail/:goodsReceivedNoteId',
    //            views: {
    //                'leftMenu': {
    //                    templateUrl: '/app/views/_LeftMain.html',
    //                },
    //                'content': {
    //                    templateUrl: '/app/views/InventoryInput/InventoryInputDetail.html',
    //                    controller: Epos.Controller.InventoryInputController,
    //                    controllerAs: "ctrl"
    //                }
    //            }
    //        });
    //});
    //eposApp.service("companyService", Epos.Services.CompanyService);
    //eposApp.service("productService", Epos.Services.ProductService);
    Daily.Module.Home.Configure(dailyApp);
    Daily.Module.News.Configure(dailyApp);
    //dailyApp.run(function ($rootScope, $state, $stateParams) {
    //    $rootScope.$state = $state;
    //    $rootScope.$stateParams = $stateParams;
    //});
    dailyApp.directive('showtab', function () {
        return {
            link: function (scope, element, attrs) {
                element.click(function (e) {
                    e.preventDefault();
                });
            }
        };
    });
})();

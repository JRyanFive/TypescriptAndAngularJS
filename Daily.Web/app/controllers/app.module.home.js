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

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

/// <reference path="../references.ts" />
'use strict';

module Daily.Module {
    export class News {
        public static $inject = ['$scope', '$filter', '$location'];
        static Configure(module: angular.IModule) {
            module.controller('NewsCtrl', function ($scope, $filter,$location) {

                $scope.InitNews = (newsModel) => {
                    $scope.LinkTree = newsModel.LinkTree;
                    $scope.ViewNews = newsModel.ViewNews;
                    $scope.FocusNewsList = newsModel.FocusNewsList;
                    $scope.HotNewsList = newsModel.HotNewsList;
                };

                $scope.InitCategory = (cateModel) => {
                    $scope.LeftNewsList = cateModel.LeftNewsList;
                    $scope.RightNewsList = cateModel.RightNewsList;
                    $scope.FocusNewsList = cateModel.FocusNewsList;
                    $scope.InterestingNewsList = cateModel.InterestingNewsList;
                };
            });
        }
    }
}

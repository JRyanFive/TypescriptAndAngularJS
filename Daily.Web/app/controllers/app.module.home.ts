/// <reference path="../references.ts" />
'use strict';

module Daily.Module {
    export class Home {
        public static $inject = ['$scope', '$filter', '$location'];
        static Configure(module: angular.IModule) {
            module.controller('HomeCtrl', function ($scope, $filter,$location) {

                $scope.InitHome = (homeModel) => {
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
        }
    }
}

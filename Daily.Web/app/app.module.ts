/// <reference path="references.ts" />
'use strict';

((): void => {
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

    dailyApp.directive('showtab',
        function () {
            return {
                link: function (scope, element, attrs) {
                    element.click(function (e) {
                        e.preventDefault();
                    });
                }
            };
        });
})()
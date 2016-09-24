module Daily.Base.Lib {
    declare var $rootScope: any;

    //export function NotifyWaring(message) {
    //    Notify(message, 'warning');
    //}

    //export function NotifySuccess(message) {
    //    Notify(message, 'success');
    //}

    //export function NotifyInfo(message) {
    //    Notify(message, 'info');
    //}

    //export function NotifyDanger(message) {
    //    Notify(message, 'danger');
    //}

    //export function Notify(message, type) {
    //    var icon;
    //    switch (type) {
    //        case "success":
    //            icon = 'glyphicon glyphicon-ok-sign';
    //            break;
    //        case "warning":
    //            icon = 'glyphicon glyphicon-question-sign';
    //            break;
    //        case "danger":
    //            icon = 'glyphicon glyphicon-remove-sign';
    //            break;
    //        case "info":
    //            icon = 'glyphicon glyphicon-info-sign';
    //            type = 'info';
    //            break;
    //    }

    //    $.notify({
    //        message: message,
    //        icon: icon,

    //    }, {
    //            type: type,
    //            offset: 20,
    //            spacing: 1,
    //            z_index: 10001,
    //            animate: {
    //                enter: 'animated fadeInDown',
    //                exit: 'animated fadeOutUp'
    //            },
    //            placement: {
    //                from: "bottom",
    //                align: "right"
    //            },
    //        });
    //}

    //export function ConfirmYesNo(message, callback) {
    //    bootbox.dialog({
    //        message: message,
    //        buttons: {
    //            Cancel: {
    //                label: "<i class='fa fa-ban'></i> Bỏ qua",
    //                className: "btn-default-alt"
    //            },
    //            Ok: {
    //                label: "<i class='fa fa-check'></i> Đồng ý",
    //                className: "btn-info",
    //                callback: callback
    //            }
    //        }
    //    });
    //}

    //export function InternetRequire($scope, callback) {
    //    if ($scope.online) {
    //        callback();
    //    } else {
    //        Lib.NotifyDanger("Không thể kết nối internet. Vui lòng kiểm tra lại");
    //    }
    //}

    //export function GenerateId() {
    //    function addZero(x, n) {
    //        while (x.toString().length < n) {
    //            x = "0" + x;
    //        }
    //        return x;
    //    }

    //    var date = new Date();
    //    var y = date.getFullYear();
    //    var d = addZero(date.getDate(), 2);;
    //    var m = addZero(date.getMonth(), 2);
    //    var hour = addZero(date.getHours(), 2);
    //    var min = addZero(date.getMinutes(), 2);
    //    var msecon = addZero(date.getMilliseconds(), 3);
    //    var n = String(m) + String(d) + String(y) + String(hour) + String(min) + String(msecon) +
    //        Math.random().toString(36).substr(2, 8).toUpperCase();
    //    return n;
    //}
}
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUD.aspx.cs" Inherits="Interview_Webforms.CRUD" %>
<!DOCTYPE html>
<html ng-app="myApp">
<head>
    <title>Configuring dxDataGrid - Angular Approach</title>
    <meta charset="utf-8" />
    <script type="text/javascript" src="content/js/jquery-1.12.3.min.js"></script>
    
    <script type="text/javascript" src="content/js/angular.min.js"></script>
    <script type="text/javascript" src="content/js/dx.all.js"></script>
    
    <script type="text/javascript" src="content/js/globalize.min.js"></script>
    

    

    <link rel="stylesheet" type="text/css" href="content/css/dx.common.css" />
    <link rel="stylesheet" type="text/css" href="content/css/dx.light.css" />

    <script type="text/javascript">
        var myApp = angular.module('myApp', ['dx']);
        myApp.controller("defaultCtrl", function ($scope) {
            var employees = [
                { a: 'a' },
                { a: 'a' },
                { a: 'a' }
            ];
            $scope.gridSettings = {
                dataSource: employees,
                paging: {
                    pageSize: 6
                },
                filterRow: {
                    visible: true
                },
                groupPanel: {
                    visible: true,
                },
                editing: {
                    editMode: 'row',
                    editEnabled: true,
                    removeEnabled: true,
                    insertEnabled: true

                }
            }
        });

    </script>
</head>
<body ng-controller="defaultCtrl">
    <div dx-data-grid="gridSettings"></div>
</body>
</html>
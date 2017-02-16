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

</head>
<body ng-controller="patientCtrl">
    <div dx-data-grid="gridSettings"></div>
</body>
<script src="content/custom/js/app.js"></script>
<script src="content/custom/js/services/patientService.js"></script>
<script src="content/custom/js/controllers/patientController.js"></script>
</html>
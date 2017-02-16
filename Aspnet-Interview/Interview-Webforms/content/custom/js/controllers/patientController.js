(function() {

    angular.module('myApp')
        .controller("patientCtrl", ['$scope', 'patientFactory', function ($scope, patientFactory) {
        
        patientFactory.getPatients(1).then(function (response) {
                $scope.gridSettings = {
                    dataSource: response.data,
                    paging: {
                        pageSize: 5
                    },
                    filterRow: {
                        visible: true
                    },
                    groupPanel: {
                        visible: true,
                    },
                    editing: {
                        mode: 'row',
                        allowUpdating: true,
                        allowDeleting: true,
                        allowAdding: true

                    }
                }

            });

        }]);
})();
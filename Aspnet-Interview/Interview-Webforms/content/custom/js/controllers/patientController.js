(function() {

    angular.module('myApp')
        .controller("patientCtrl", ['$scope', 'patientFactory', function ($scope, patientFactory) {
        var employees = [
            { a: 'a' },
            { a: 'a' },
            { a: 'a' }
            ];// will need to obtain this from the service

        patientFactory.getPatients(1).then(function (response) {
            console.log(response.data);
                $scope.gridSettings = {
                    dataSource: response.data,
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
                        mode: 'row',
                        allowUpdating: true,
                        allowDeleting: true,
                        allowAdding: true

                    }
                }

            });

        }]);
})();
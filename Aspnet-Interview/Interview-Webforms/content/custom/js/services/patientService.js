(function() {
    
    angular.module('myApp')
        .factory('patientFactory', ['$http', function ($http) {
            //revealing module

            function getPatients(page) {
                //do something

                    return $http({
                        method: 'GET',
                        url: 'http://localhost:54232/api/Patient/getall/' + page,
                        headers: { 'Accept': 'application/json, text/xml' }
                        
                    });
                   
            }

            //function getSinglePatient() {
            //    //do something
            //}

            return {
               // getSinglePatient: getSinglePatient,
                getPatients: getPatients
            }
        }]);
})();
var app = angular.module('app', ['ngRoute']);

app.config(

    function ($routeProvider) {

        $routeProvider
            .when(
                '/funcionario/cadastro', 
                {
                    templateUrl: "/app/views/create.html", 
                    controller: "EmployeeCreate"
                }
            )
            .when(
                '/funcionario/consulta',
                {
                    templateUrl: "/app/views/list.html", 
                    controller: "EmployeeList"
                }
            );
    }
);
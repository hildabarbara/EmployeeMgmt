app.controller(
    'EmployeeCreate',
    function ($scope, $http) {

        $scope.title = "Página de cadastro de funcionários";

        $scope.model = {}; 

        $scope.create = function () {

            $scope.message = "Enviando requisição, por favor aguarde...";

            $http.post("http://localhost:3137/api/funcionario/cadastrar", $scope.model)
                .success(
                    function (msg) {
                        $scope.message = msg;
                        $scope.model = {}; 
                    }
                )
                .error(
                    function (e) {
                        $scope.message = e;
                    }
                );
        };
    }
);


app.controller(
    'EmployeeList',
    function ($scope, $http) {

        $scope.title = "Página de consulta de funcionários";

        $scope.model = {}; 

        $scope.getOne = function (id) {

            $http.get("http://localhost:3137/api/funcionario/obter?id=" + id)
                .success(
                    function (data) {
                        $scope.model.EmployeeId = data.EmployeeId;
                        $scope.model.Name = data.Name;
                        $scope.model.Occupation = data.Occupation;
                        $scope.model.Email = data.Email;
                        $scope.model.Birth = data.Birth;
                    }
                )
                .error(
                    function (e) {
                        $scope.message = e;
                    }
                );
        };

        $scope.edit = function () {

            $http.put("http://localhost:3137/api/funcionario/editar", $scope.model)
                .success(
                    function (msg) {
                        $scope.message = msg;
                        $scope.list();
                    }
                )
                .error(
                    function (e) {
                        $scope.message = e;
                    }
                );
        };

        $scope.delete = function (id) {

            $http.delete("http://localhost:3137/api/funcionario/excluir?id=" + id)
                .success(
                    function (msg) {
                        $scope.message = msg;
                        $scope.list();
                    }
                )
                .error(
                    function (e) {
                        $scope.message = e;
                    }
                );
        };

        $scope.getAll = function () {

            $http.get("http://localhost:3137/api/funcionario/listar")
                .success(
                    function (list) {
                        $scope.employees = list;
                    }
                )
                .error(
                    function (e) {
                        $scope.message = e; 
                    }
                );
        };
    }
);
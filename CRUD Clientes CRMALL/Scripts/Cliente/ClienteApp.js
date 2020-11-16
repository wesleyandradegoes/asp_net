(function () {
    var app = angular.module('ClienteApp', ['ngRoute']);

    
 
    app.controller('ClienteController', function ($scope, $http, $window) {
        
        $scope.buscaCep = function () {
            var cep = $scope.model.Endereco.Cep;

            if (cep == null || cep.toString().length != 8)
                alert("CEP Inválido.");
            else {
                $http.get("https://viacep.com.br/ws/" + cep + "/json/")
                    .then(function (response) {
                        if (response.data.erro)
                            alert("CEP não encontrado.");
                        else
                        {
                            $scope.model.Endereco.Logradouro = response.data.logradouro;
                            $scope.model.Endereco.Bairro = response.data.bairro;
                            $scope.model.Endereco.Cidade = response.data.localidade;
                            var sigla = $scope.model.Endereco.Estado = response.data.uf;
                            
                            $scope.selecionaEstado(sigla);
                        }
                    });
            }
            
        }

        $scope.selecionaEstado = function (sigla) {
            var estadosOptions = document.getElementById("Endereco_Estado").options;
            for (var i = 0; i < estadosOptions.length; i++) {
                if (estadosOptions[i].text == sigla) {
                    $scope.model.Endereco.Estado = estadosOptions[i].value;
                    return;
                }
            }
        }

        $scope.validaCamposObrigatorio = function () {
            $scope.hasErrors = false;
            $scope.errors = [];

            if ($scope.model?.Nome == null || $scope.model.Nome.length <= 0) {
                $scope.errors.push("O campo Nome é obrigatório.");
                $scope.hasErrors = true;
            }
                
            var dataNasc = $scope.model?.DataNascimento?.toString();

            if (dataNasc == null || dataNasc == undefined) {
                $scope.errors.push("O campo Data de Nascimento é obrigatório.");
                $scope.hasErrors = true;
            }
                
            if ($scope.model?.Sexo == null || parseInt($scope.model.Sexo) <= 0) {
                $scope.errors.push("O campo Sexo é obrigatório.");
                $scope.hasErrors = true;
            }
                
            if (!$scope.hasErrors)
                $scope.salvar()
        }

        $scope.salvar = function () {
            $http.post("/Cliente/Novo/", $scope.model)
                .then(result => {
                    $window.location.href = "/Cliente/Index";
                })
           
        }
    });
})();

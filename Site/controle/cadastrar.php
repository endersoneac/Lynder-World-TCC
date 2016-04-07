<?php

require_once("conexao/cadastrodao.php");
require_once("conexao/modelagem/usuarioM.php");

interface iCadastrar{
	public function efetuar($login, $nome, $email, $senha1, $senha2);
}

class cadastrar implements iCadastrar{

	public function efetuar($login, $nome, $email, $senha1, $senha2){
	
		$cadastrodao = new cadastrodao();

		$resultado = $cadastrodao->verificar($login);
		$verificacao = @mysql_num_rows($resultado);

		if($verificacao >= 1){
			return 3;
		}else if($senha1 != $senha2){
			return 4;
		}else{
			$usuarioX = new usuarioM($nome, $email, $senha1, $login);
			$resultado = $cadastrodao->Cadastrar($usuarioX);
			if($resultado == true){
				return 2;
			}else{
				return 5;
			}
		}
	}
}
?>
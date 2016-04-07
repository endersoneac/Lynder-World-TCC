<?php

require_once("modelagem/usuarioM.php");
require_once("query.php");

interface iCadastrodao
{
    public function cadastrar($usuario);
    public function verificar($login);
}

class cadastrodao implements iCadastrodao{

	public function Cadastrar($usuario){
		$usuariomodel = new usuarioM();
		$usuariomodel = $usuario;
		
		$query = new query();
		$sql = "insert into usuario(login, senha, nome, email, ativo) values('" . $usuariomodel->getLogin() . "','" . $usuariomodel->getSenha() . "','" . $usuariomodel->getNome() . "','" . $usuariomodel->getEmail() . "', 0);";
		$query->execute($sql);
		
		return true;
	}

	public function verificar($login){
		$query = new query();
		$sql = "select idUser from usuario where login = '$login'";
		$resultado = $query->execute($sql);
		return $resultado;
	}
}

?>
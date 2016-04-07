<?php

require_once("query.php");

interface iInfosDB{
	public function infoRegistro();
	public function infoPersonagem();
}

class informacoesdb{

	public function infoRegistro() {
		$query = new query();
		$sql = "select COUNT(email) as Quantidade from usuario";
		$resultado = $query->execute($sql);
		return $resultado;
	}
	public function infoPersonagem() {
		$query = new query();
		$sql = "select COUNT(nome) as Quantidade from personagem";
		$resultado = $query->execute($sql);
		return $resultado;
	}
}
?>
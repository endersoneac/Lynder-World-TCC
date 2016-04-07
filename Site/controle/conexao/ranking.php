<?php

require_once("query.php");

interface iRanking{
	public function ranknivel();
	public function rankArmadura();
	public function rankDinheiro();
	public function rankArma();
}

class ranking implements iRanking{

	public function rankNivel() {
		$query = new query();
		$sql = "select nome, nivel from personagem order by nivel desc LIMIT 0, 15";
		$resultado = $query->execute($sql);
		return $resultado;
	}
	public function rankArmadura() {
		$query = new query();
		$sql = "select nome, nvEquip from personagem order by nvEquip desc LIMIT 0, 15";
		$resultado = $query->execute($sql);
		return $resultado;
	}
	public function rankDinheiro() {
		$query = new query();
		$sql = "select nome, dinheiro from personagem order by dinheiro desc LIMIT 0, 15";
		$resultado = $query->execute($sql);
		return $resultado;
	}
	public function rankArma() {
		$query = new query();
		$sql = "select nome, nvArma from personagem order by nvArma desc LIMIT 0, 15";
		$resultado = $query->execute($sql);
		return $resultado;
	}
}


?>
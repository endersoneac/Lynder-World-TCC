<?php
	
	require_once("conexao/ranking.php");

	interface iControlerank
	{
	    public function rNivel();
	    public function rEquip();
	    public function rArma();
	    public function rDinheiro();
	}

	class controleranking implements iControlerank{
		
		public function rNivel() {
			$ranking = New ranking();
			$resultado = $ranking->rankNivel();
			return $resultado;
		}
		public function rEquip() {
			$ranking = New ranking();
			$resultado = $ranking->rankArmadura();
			return $resultado;
		}
		public function rArma() {
			$ranking = New ranking();
			$resultado = $ranking->rankArma();
			return $resultado;
		}
		public function rDinheiro() {
			$ranking = New ranking();
			$resultado = $ranking->rankDinheiro();
			return $resultado;
		}
	}
?>
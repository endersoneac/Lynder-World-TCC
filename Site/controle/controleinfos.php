<?php
	
	require_once("conexao/informacoesdb.php");

	interface iControleinfos{
		public function iRegistros();
		public function iPersonagens();
	}
	
	class controleinfos implements iControleinfos{
		
		public function iRegistros() {
			$informacoesdb = New informacoesdb();
			$resultado = $informacoesdb->infoRegistro();
			return $resultado;
		}
		public function iPersonagens() {
			$informacoesdb = New informacoesdb();
			$resultado = $informacoesdb->infoPersonagem();
			return $resultado;
		}
	}
?>
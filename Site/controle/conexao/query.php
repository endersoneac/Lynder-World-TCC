<?php
	require_once("conexao.php");
	
	interface iQuery{
		public function execute($sql);
	}

	class query implements iQuery{
		private $sqlx;

		public function execute($sql) {
			$conexao = new conexao();
			$this->sqlx = $sql;
			$resultado = mysql_query($this->sqlx, $conexao->getConnection());
			$conexao->Close();
			return $resultado;
		}
	}

?>
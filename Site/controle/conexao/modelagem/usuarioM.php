<?php
	class usuarioM{
		private $nome;
		private $email;
		private $senha;
		private $login;

		public function usuarioM($nome = "", $email = "", $senha = "", $login = ""){
			$this->nome = $nome;
			$this->email = $email;
			$this->senha = $senha;
			$this->login = $login;
		}

		// Sets
		public function setNome($nome){
			$this->nome = $nome;
		}

		public function setEmail($email){
			$this->email = $email;
		}

		public function setSenha($senha){
			$this->senha = $senha;
		}

		public function setLogin($login){
			$this->login = $login;
		}

		// Gets
		public function getNome(){
			return $this->nome;
		}

		public function getEmail(){
			return $this->email;
		}

		public function getSenha(){
			return $this->senha;
		}

		public function getLogin(){
			return $this->login;
		}

	}
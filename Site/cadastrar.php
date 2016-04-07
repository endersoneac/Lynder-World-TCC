<?php
	
	require_once("controle/cadastrar.php");
	
	$login = $_POST['usuario'];
	$nome = $_POST['nome'];
	$email = $_POST['email'];
	$senha1 = $_POST['senha1'];
	$senha2 = $_POST['senha2'];

	$cadastrar = new cadastrar();
	$resultado = $cadastrar->efetuar($login, $nome, $email, $senha1, $senha2);

	echo "<script>document.location = '../registro.php?cad=$resultado'</script>";


?> 


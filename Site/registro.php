<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"[]>
<html xmlns="http://www.w3.org/1999/xhtml" dir="ltr" lang="en-US" xml:lang="en">
<head>
    <!--
    Created by Artisteer v3.1.0.48375
    Base template (without user's data) checked by http://validator.w3.org : "This page is valid XHTML 1.0 Transitional"
    -->
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
	<link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon" />
    <title>Lynder World | Torne-se uma lenda...</title>
	
	<script>
		function irtermos()
		{
			window.open("termos.php",'_blank');
		}
		function atualizar()
		{
			setTimeout("document.location = 'registro.php?cad=1'",5000);
		}
	</script>
	
	<?
	if($_GET['cad'] != 0){
	$cadastrado = $_GET['cad'];
	}else{
		echo "<meta HTTP-EQUIV='Refresh' CONTENT='0;URL=registro.php?cad=1'>";
	}
	?>

    <link rel="stylesheet" href="style.css" type="text/css" media="screen" />
	<link rel="stylesheet" href="formcss.css" type="text/css" media="screen" />
    <!--[if IE 6]><link rel="stylesheet" href="style.ie6.css" type="text/css" media="screen" /><![endif]-->
    <!--[if IE 7]><link rel="stylesheet" href="style.ie7.css" type="text/css" media="screen" /><![endif]-->

    <script type="text/javascript" src="jquery.js"></script>
    <script type="text/javascript" src="script.js"></script>
	
	<script src="js/jquery.js" type="text/javascript"></script>
	<script src="js/jqueryValida.js" type="text/javascript"></script>
	<script src="js/regras.js" type="text/javascript"></script>
	
	
	
   <style type="text/css">
.art-post .layout-item-0 { margin-bottom: 10px; }
.art-post .layout-item-1 { color: #000000; }
.art-post .layout-item-2 { border-top-width:1px;border-top-style:solid;border-top-color:#949494;margin-top: 10px;margin-bottom: 10px; }
.art-post .layout-item-3 { color: #000000; background:repeat #E5E5E5; padding-right: 10px;padding-left: 10px; }
   .ie7 .art-post .art-layout-cell {border:none !important; padding:0 !important; }
   .ie6 .art-post .art-layout-cell {border:none !important; padding:0 !important; }
   
   label { width: 10em; float: left; }
label.error { float: none; color: red; padding-left: 0px; vertical-align: bottom; }
p { clear: both; }
fieldset {position: absolute; left: 450px; width: 400px; } 
em { font-weight: bold; padding-right: 1em; vertical-align: top; }
   </style>
   
</head>
<body>
<div id="art-page-background-middle-texture">
<div id="art-main">
    <div class="cleared reset-box"></div>
    <div class="art-header">
        <div class="art-header-position">
            <div class="art-header-wrapper">
                <div class="cleared reset-box"></div>
                <div class="art-header-inner">
                <div class="art-logo">
                                 <h1 class="art-logo-name"><a href="./index.php">Lynder World</a></h1>
                                                 <h2 class="art-logo-text">Torne-se uma lenda!</h2>
                                </div>
                </div>
            </div>
        </div>
        
    </div>
    <div class="cleared reset-box"></div>
<div class="art-bar art-nav">
<div class="art-nav-outer">
<div class="art-nav-wrapper">
<div class="art-nav-inner">
	<div class="art-nav-center">
	<ul class="art-hmenu">
		<li>
			<a href="./inicio.php">Inicio</a>
		</li>	
		<li>
			<a href="./registro.php?cad=1" class="active">Registro</a>
		</li>	
		<li>
			<a href="./game.php">Game</a>
		</li>	
		<li>
			<a href="./informacoes.php">Informações</a>
		</li>	
	</ul>
	</div>
</div>
</div>
</div>
</div>
<div class="cleared reset-box"></div>
<div class="art-box art-sheet">
        <div class="art-box-body art-sheet-body">
            <div class="art-layout-wrapper">
                <div class="art-content-layout">
                    <div class="art-content-layout-row">
                        <div class="art-layout-cell art-content">
<div class="art-box art-post">
    <div class="art-box-body art-post-body">
<div class="art-post-inner art-article">
                                <div class="art-postcontent">
<div class="art-content-layout-wrapper layout-item-0">
<div class="art-content-layout layout-item-1">
    <div class="art-content-layout-row">
    <div class="art-layout-cell layout-item-3" style="width: 100%;">
        <p><strong>Instruções para o registro:</strong></p>
        
        <p>&gt; Preencha as informações do formulário.</p>
        
        <p>&gt; Clique no botão cadastrar.</p>
        
        <p>&gt; Espere a confirmação.</p>
    </div>
    </div>
	<div class="art-content-layout-row">
		<?php
		if($cadastrado == 2){
			$msg = "Usuário cadastrado com sucesso no Lynder World!";
			echo "<p></p>";
			echo "<div class='confirma' id='confirma'>";
			echo "<p align='center'>" . $msg . "</p>";
			echo "</div>";
			echo"<script>atualizar();</script>"; 
		}else if($cadastrado == 3){
			$msg = "Usuário não pode ser cadastrado, pois ja existe!";
			echo "<p></p>";
			echo "<div class='existente' id='existente'>";
			echo "<p align='center'>" . $msg . "</p>";
			echo "</div>";
			echo"<script>atualizar();</script>"; 
		}else if($cadastrado == 4){
            $msg = "Senhas não conferem!";
            echo "<p></p>";
            echo "<div class='existente' id='existente'>";
            echo "<p align='center'>" . $msg . "</p>";
            echo "</div>";
            echo"<script>atualizar();</script>"; 
        }else if($cadastrado == 5){
            $msg = "Erro ao tentar cadastrar usuário!";
            echo "<p></p>";
            echo "<div class='existente' id='existente'>";
            echo "<p align='center'>" . $msg . "</p>";
            echo "</div>";
            echo"<script>atualizar();</script>"; 
        }
		?>
	</div>
</div>
</div>
<div class="art-content-layout-br layout-item-2">
</div><div class="art-content-layout">
    <div class="art-content-layout-row">
    <div class="art-layout-cell" style="width: 25%;">
        <p><br /></p>
    </div><div class="art-layout-cell" style="width: 50%;">
        <span style="font-weight: bold;"><span style="font-size: 26px;">Registro:</span></span>
        
        <form method="post" name="cadastro" action="cadastrar.php" id="registro" enctype="multipart/form-data>
            <label for="nome">Nome:</label><br />
            <input value="" type="text" id="nome" name="nome" size="50" maxlength="128" /><br />
            <label for="usuario">Usuario:</label><br />
            <input value="" type="text" id="usuario" name="usuario" size="50" maxlength="128" /><br />
            <label for="senha1">Senha:</label><br />
            <input value="" type="password" name="senha1" id="senha1" size="50" maxlength="128" /><br />
            <label for="senha2">Confirma Senha:</label><br />
            <input value="" type="password" name="senha2" id="senha2" size="50" maxlength="128" /><br />
            <label for="email">Email:</label><br />
            <input value="" type="text" name="email" id="email" size="50" maxlength="128" /><br />
            
			<br />
			<p onclick="irtermos()" align="center" style="cursor: pointer; width: 500px;">Verifique os termos de uso do Lynder World</p>
			<p align="Center" style="width: 500px;"><b>Clicando em cadastrar, significa que você leu e aceitou os Termos de USO.</b></p>
			<br>
			
            <input type="submit" value="Cadastrar" id="limpar" name="enviar" />
			<input type="reset" value="Limpar" id="limpar" name="limpar" />
        </form>
    </div><div class="art-layout-cell" style="width: 25%;">
        <p><br /></p>
    </div>
    </div>
</div>

                </div>
                <div class="cleared"></div>
                </div>

		<div class="cleared"></div>
    </div>
</div>

                          <div class="cleared"></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="cleared"></div>
            
    		<div class="cleared"></div>
        </div>
    </div>
    <div class="art-footer">
        <div class="art-footer-body">
            <div class="art-footer-center">
                <div class="art-footer-wrapper">
                    <div class="art-footer-text">
                        <p><a href="http://www.industrialararaquara.com.br/site/">ETEC</a></p>

<p>Lynder World Copyright © 2013. Todos os direitos reservados.</p>
                        <div class="cleared"></div>
                        
                    </div>
                </div>
            </div>
            <div class="cleared"></div>
        </div>
    </div>
    <div class="cleared"></div>
</div>
</div>

</body>
</html>

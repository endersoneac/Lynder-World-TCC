<?php

interface iConexao{
      public function getConnection();
      public function Close();
}

class conexao{

      private $link = null;

      public function getConnection(){
            $link = mysql_connect('localhost', 'enderson_lynder', 'enderson123');
                        
            if (!$link) {
                  die('Erro de conexão: ' . mysql_error());
            }
            
            mysql_select_db('enderson_lynder');

            return $link;
      }

      public function Close(){
      	if( $this->link != null ){
      		$this->link = null;
            }
      }
}
?>
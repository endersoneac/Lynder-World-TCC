$(document).ready( function() {
    $("#registro").validate({
        // Define as regras
        rules:{
            nome:{
                // campoNome será obrigatório (required) e terá tamanho mínimo (minLength)
                required: true, minlength: 5
            },
            email:{
                // campoEmail será obrigatório (required) e precisará ser um e-mail válido (email)
                required: true, email: true
            },
			senha1:{
				required: true, minlength: 8
			},
			senha2:{
				required: true, equalTo: "#senha1"
			},
			usuario:{
				required: true, minlength: 5
			},
			termos:{
				required: true
			}			
        },
        //mensagens para serem mostradas caso seja contra as regras.
		messages:{
            nome:{
                required: "Digite o seu nome!",
                minLength: "O seu nome deve conter, no mínimo, 5 caracteres"
            },
            email:{
                required: "Digite o seu e-mail!",
                email: "Digite um e-mail v&aacute;lido"
            },
            usuario:{
                required: "Digite o seu usu&aacute;rio!",
                minLength: "O seu usu&aacute;rio deve conter, no mínimo, 5 caracteres"
            },
			senha1:{
				required: "Digite sua senha!",
				minlength: "Sua senha deve contar, no minimo, 8 caracteres"
			},
			senha2:{
				required: "Digite sua senha!",
				equalTo: "Senhas digitadas n&atilde;o conferem!"
			},
			termos:{
				required: "Necess&aacute;rio aceitar os termos."
			}
        }
    });
});
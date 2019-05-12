function hgsubmit() {
    if (/\S+/.test(document.hgmailer.name.value) == false) alert("Por favor, digite um nome.");
    else if (/^\S+@[a-z0-9_.-]+\.[a-z]{2,6}$/i.test(document.hgmailer.email.value) == false) alert("Um endereço de e-mail válido é requerido.");
    else if (/\S+/.test(document.hgmailer.message.value) == false) alert("É necessário um conteúdo para mensagem.");
    else {
        document.hgmailer.submit();
        alert('Obrigado!\nSeu e-mail foi enviado com sucesso.');
    }
}
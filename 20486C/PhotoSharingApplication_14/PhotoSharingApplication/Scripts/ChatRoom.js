$(document).ready(() => {
	let chat = $.connection.chatHub;
	chat.client.addMessage = (name, message) => {
		let encodedName = $("<div/>").text(name).html();
		let encodedMessage = $("<div/>").text(message).html();
		let listItem = `<li>${encodedName}: ${encodedMessage}</li>`;
		$("#discussion").append(listItem);
	};

	$("#chat-message").focus();
	$.connection.hub.start().done(() => {
		chat.server.join(photoid).done(() => {
			$("#sendmessage").click(() => {
				chat.server.send(username, photoid, $("#chat-message").val());
				$("#chat-message").val("").focus();
			});
		});
	});
});
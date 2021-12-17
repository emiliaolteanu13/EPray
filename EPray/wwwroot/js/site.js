var msg = new SpeechSynthesisUtterance();

var message = document.getElementById("prayer").innerHTML
msg.text = message
window.speechSynthesis.speak(msg);


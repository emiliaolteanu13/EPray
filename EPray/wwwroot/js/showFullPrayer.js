function showPrayer(ev) {
    ev.preventDefault();
    let lyrics = ev.target.dataset.lyrics;
    console.log(lyrics);
    console.log(ev.target);
    ev.target.innerText = lyrics 
    var msg = new SpeechSynthesisUtterance();

    msg.text = lyrics+ "ehehhheheehehehehehhehehehuehueheuheuhueueeuhuehue o ho hooooo my belly hurts hahahaihaihihahahahis";
    window.speechSynthesis.speak(msg);
}
document.querySelectorAll(".lyrics").forEach(item => {
    item.addEventListener('click', (ev) => {
        console.log(ev);
        showPrayer(ev);
    })
})
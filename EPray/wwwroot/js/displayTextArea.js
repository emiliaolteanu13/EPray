
document.getElementsByName("target").forEach(item => {
    item.addEventListener('click', (ev) => {
        ev.target.nextElementSibling.style.visibility = "visible"; 
    })
})



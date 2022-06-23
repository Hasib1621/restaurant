const menu = document.getElementById('hamburger');

menu.addEventListener('click', (e) => {
    e.preventDefault();
    document.querySelector('.sidebar').classList.toggle('disable');
})

const alert = document.querySelector('.notification');

if (alert.length != 0) {
    setTimeout(() => {
        $("div.alert.notification").fadeOut();
    }, 2000)
}


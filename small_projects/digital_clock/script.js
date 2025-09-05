function tick() {

    const d = new Date();

    const pad = n => String(n).padStart(2, '0');

    hours = d.getHours() % 12 || 12;
    minutes = d.getMinutes();
    seconds = d.getSeconds();

    const ampm = hours >= 12 ? 'PM' : 'AM';

    document.getElementById('clock').textContent = `${hours}:${pad(minutes)}:${pad(seconds)} ${ampm}`;
}

tick();
setInterval(tick, 1000);
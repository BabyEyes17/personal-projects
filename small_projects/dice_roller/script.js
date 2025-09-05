document.getElementById('roll').onclick = function () {

    die_a = 1 + Math.floor(Math.random() * 6);

    die_b = 1 + Math.floor(Math.random() * 6)

    document.getElementById('msg').textContent = `You rolled a ${die_a} and a ${die_b}!`;
};
secret = Math.floor(Math.random() * 100) +1;

console.log("The secret is:", secret)

document.getElementById('check').onclick = function () {

    guess = Number(document.getElementById('guess').value);

    if (guess === secret) {
        document.getElementById('msg').textContent = "Correct!";
    }

    else if (guess > secret) {
        document.getElementById('msg').textContent = "Too high!";
    }

    else {
        document.getElementById('msg').textContent = "Too low!";
    }
};
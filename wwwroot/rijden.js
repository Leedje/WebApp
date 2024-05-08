const mobileMenuIcon = document.getElementById('mobile-menu-icon');
const mobileNav = document.getElementById('mobile-nav');

mobileMenuIcon.addEventListener('click', function () {
    if (mobileNav.style.display === 'block' || mobileNav.style.display === '') {

        mobileNav.style.display = 'none';
    } else {
        mobileNav.style.display = 'block';
    }
});


var timerInterval;
var isPlaying = false;

function toggleVideo() {
    var video = document.getElementById("myVideo");
    var button = document.getElementById("startStopButton");

    if (!isPlaying) {
        video.play();
        button.innerText = "Stop";

        var startTime = Date.now();
        timerInterval = setInterval(function () {
            var elapsedTime = Date.now() - startTime;
            var minutes = Math.floor((elapsedTime / (1000 * 60)) % 60);
            var seconds = Math.floor((elapsedTime / 1000) % 60);
            document.getElementById("timer").innerText = minutes + ":" + seconds;
        }, 1000);

        isPlaying = true;
    } else {
        video.pause();
        clearInterval(timerInterval);
        button.innerText = "Start Video";

        isPlaying = false;
    }
}

window.startCountdown = function (elementId, eventDateStr) {
    console.log('startCountdown called with:', elementId, eventDateStr);

    const countdownEl = document.getElementById(elementId);
    if (!countdownEl) {
        console.error('Element not found:', elementId);
        return;
    }

    console.log('Element found:', countdownEl);

    const targetDate = new Date(eventDateStr).getTime();
    if (isNaN(targetDate)) {
        console.error('Invalid date:', eventDateStr);
        countdownEl.innerHTML = "Invalid Date";
        return;
    }

    console.log('Target date:', new Date(eventDateStr));

    // Function to calculate and display countdown
    function updateCountdown() {
        const now = new Date().getTime();
        const distance = targetDate - now;

        console.log('Distance:', distance);

        if (distance < 0) {
            countdownEl.innerHTML = "Event Started!";
            return false; // Stop the interval
        } else {
            const days = Math.floor(distance / (1000 * 60 * 60 * 24));
            const hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
            const minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
            const seconds = Math.floor((distance % (1000 * 60)) / 1000);

            const countdownText = `${days}d ${hours}h ${minutes}m ${seconds}s`;
            console.log('Setting countdown to:', countdownText);
            countdownEl.innerHTML = countdownText;
            return true; // Continue the interval
        }
    }

    // Update immediately on load
    if (updateCountdown()) {
        // Only start interval if event hasn't started yet
        const interval = setInterval(function () {
            if (!updateCountdown()) {
                clearInterval(interval);
            }
        }, 1000);
    }
};
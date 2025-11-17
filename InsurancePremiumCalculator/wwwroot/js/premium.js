async function calculatePremium() {
    let req = {
        name: document.getElementById("name").value,
        ageNextBirthday: parseInt(document.getElementById("age").value),
        dateOfBirth: document.getElementById("dob").value,
        occupation: document.getElementById("occupation").value,
        deathSumInsured: parseFloat(document.getElementById("sum").value)
    };

    if (!req.name || !req.ageNextBirthday || !req.dateOfBirth || !req.occupation || !req.deathSumInsured) {
        alert("All fields are mandatory!");
        return;
    }

    let res = await fetch("/api/PremiumApi/Calculate", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(req)
    });

    let premium = await res.json();
    document.getElementById("premiumText").innerText = premium;
}

var calcBtn = document.getElementById("calcBtn");
if (calcBtn) {
    calcBtn.onclick = function () {
        calculatePremium();
    };
}

var occDrop = document.getElementById("occupation");
if (occDrop) {
    occDrop.onchange = function () {
        calculatePremium();
    };
}
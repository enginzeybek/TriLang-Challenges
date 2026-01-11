function findSecond() {
    var numbers = document.getElementById("sayi").value;
    if (!numbers) {
        alert("Lütfen boş geçmeyiniz!!!");
        return;
    }
    var numbersArray = numbers.split(",").map(Number);

    var maxnumber = numbersArray[0];
    var secondmax = Number.NEGATIVE_INFINITY;

    for (let i = 0; i < numbersArray.length; i++) {
        let current = numbersArray[i];

        if (current > maxnumber) {
            
            secondmax = maxnumber;
            maxnumber = current;
        }
        else if (current < maxnumber && current > secondmax) {
            
            secondmax = current;
        }
        
    }
    document.getElementById("result").innerText = `İkinci en büyük: ${secondmax}`;
}
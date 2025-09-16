
function printArithmeticSeries(n) {
    if (n <= 0 || n > 100) {
        console.log("Wrong Input");
        return;
    }

    let result = [];
    let current = 2;  

    for (let i = 0; i < n; i++) {
        if (current % 3 === 0 && current % 5 === 0) {
            result.push("Boom");
        } else if (current % 3 === 0) {
            result.push("Tik");
        } else if (current % 5 === 0) {
            result.push("Tak");
        } else {
            result.push(current);
        }

        if ((i + 1) % 3 === 0) {
            current += 1;
        } else {
            current += 3;
        }
    }

    console.log(result.join(" "));
}

function main() {
    const n = parseInt(readLine()); // Panjang deret
    printArithmeticSeries(n); // Menampilkan hasil
}
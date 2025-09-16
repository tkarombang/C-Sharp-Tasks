function sumNumbersInString(str) {
    const numbers = str.match(/\d+/g); // F*CK REGEX
    if (numbers === null) {
        return 0; 
    }

    const sum = numbers.reduce((acc, num) => acc + parseInt(num), 0);
    return sum;
}

function main() {
    const input = readLine(); 
    const result = sumNumbersInString(input);
    console.log(result);
}
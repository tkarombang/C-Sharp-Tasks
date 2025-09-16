function printFiboStar(length, divisor) {
    
    if (length <= 0 || length > 100 || divisor <= 0) {
        console.log("Wrong Input");
        return;
    }


    let a = 1; 
    let b = 2;  
    let fiboSequence = []; 
    for (let i = 1; i <= length; i++) {
        if (i === 1) {
            fiboSequence.push(a);
        } else if (i === 2) {
            fiboSequence.push(b);
        } else {
            let next = a + b;
            fiboSequence.push(next);
            a = b;
            b = next;
        }
    }

    let result = fiboSequence.map(num => (num % divisor === 0 ? '*' : num));
    
    console.log(result.join(' '));
}

function main() {
    //DO YOUR CODE HERE
    const length = parseInt(readLine());  
    const divisor = parseInt(readLine()); 

    printFiboStar(length, divisor);
}
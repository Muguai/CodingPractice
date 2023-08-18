/*
Kata Practice 4

Check the Logic 

Create a function that returns true if a given inequality expression is correct and 
false otherwise. 
Examples 
checkLogic("3 < 7 < 11") ➞ true 
 
checkLogic("13 > 44 > 33 > 1") ➞ false 
 
checkLogic("1 < 2 < 6 < 9 > 3") ➞ true 

*/

function checkLogic(input){
    const input2 = input.split(" ")
    for (let i = 0; i < input2.length - 2; i+=2) {
        if(input2[i + 1] === "<" && !(Number(input2[i]) < Number(input2[i+2])))
            return false;
        else if(input2[i + 1] === ">" && !(Number(input2[i]) > Number(input2[i+2])))
            return false;
        
    }
    return true;
}

function checkLogic2(input){
    const input2 = input.split(" ")

    for (let i = 1; i < input2.length - 1; i+=2) {
        if(!eval(input2[i-1] + input2[i] + input2[i+1]))
            return false;
    }

    return true;
}

function checkLogic3(input){
    
    const input2 = input.split(" ")
    operator = input2.filter((word) => word == '<' || word =='>');
    num = input2.filter((word) => !isNaN(word));

    for (let i = 0; i < operator.length ; i++) {
        if(operator[i] === '<' && !(Number(num[i]) < Number(num[i+1])))
            return false;
        else if(operator[i] === '>'&& !(Number(num[i]) > Number(num[i+1])))
            return false;
            
    }

    return true;
}

console.log(checkLogic2("3 < 7 < 11"));
console.log(checkLogic2("13 > 44 > 33 > 1"));
console.log(checkLogic2("1 < 2 < 6 < 9 > 3"));
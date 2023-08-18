/*
Kata problem 2

Celsius to Fahrenheit Converter 

Write a function that converts Celsius to Fahrenheit and vice versa. 

Examples 
convert(35*C) ➞ 95*F 
 
convert(19*f) ➞ -7*C 
 
convert(21*c) ➞ 70*F 
 
convert(51*k) ➞ Error 
 
convert(33) ➞ Error 
 
convert(72**F) ➞ Error 
 
convert(100f) ➞ Error 
 
Notes 
• Round to the nearest integer.  
• If the input is incorrect, return "Error".  
• For the formulae to convert back and forth:  
o https://www.rapidtables.com/convert/temperature/celsius-to-fahrenheit.html 
o https://www.rapidtables.com/convert/temperature/fahrenheit -to-celsius.html 

*/

function temperatureMetricConverter(input){
    
    if(!input)
        throw new Error("Input has to be a string in the vain of #*C or #*F")

    let input2 = input.split("*");

    if(isNaN(input2[0]) || input2.Length != 2)
        throw new Error("Input has to be a string in the vain of #*C or #*F")
        
    
    if(input2[1].toUpperCase() === "F")
        return Math.round((Number(input2[0]) - 32)  * 5 / 9) + "*C";
    else if(input2[1].toUpperCase() === "C")
        return Math.round(Number(input2[0]) * 9 / 5 + 32) + "*F";
    
    throw new Error(input + " Is not a valid input");
}

console.log(temperatureMetricConverter("barrW*d"));
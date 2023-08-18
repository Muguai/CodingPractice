/*
Kata Problem 3

Exists a Number Higher?

 
Write a function that returns  true  if there exists at least one number that is larger than 
or equal to  n . 
Examples 
existsHigher([5, 3, 15, 22, 4], 10) ➞ true 
 
existsHigher([1, 2, 3, 4, 5], 8) ➞ false 
 
existsHigher([4, 3, 3, 3, 2, 2, 2], 4) ➞ true 
 
existsHigher([-10, -99, -57, -4], -4) ➞ true 
 
existsHigher([5], 5) ➞ true 
 
existsHigher([99, 99], 99) ➞ true 
 
existsHigher([], 5) ➞ false 
Notes: 
Return  false  for an empty array  [] . 
Negative numbers are allowed 
  
Optional Extra: 
Create a new function called  oddAndEven()  that receives an array of numbers and 
returns the difference between the sums of the elements of the array with odd indexes and 
the even indexes. For instance: 
[5, 3, 15, 22, 4] 
= (5 + 15 + 4) – (3 + 22) 
= 24 – 25 
= –1 
Examples 
oddAndEven([5, 3, 15, 22, 4]) ➞ -1 
 
oddAndEven([1, 2, 3, 4, 5]) ➞ 3 
 
oddAndEven([4, 3, 3, 3, 2, 2, 2]) ➞ 3 
 
oddAndEven([-10, -99, -57, -4]) ➞ 36 
 
oddAndEven([5]) ➞ 5 
 
oddAndEven([99, 99]) ➞ 0 
 
oddAndEven([]) ➞ 0 
 
Notes  
You can feed this function the same array data as the first part of the Kata. 
*/

function existHigher(numArray, n){
    for(const i of numArray){
        if(i >= n)
            return true;
    }
    return false;
}

function oddAndEven(numArray){
    let odd = 0;
    let even = 0;

    for (let i = 0; i < numArray.length; i++) {
        if(i % 2 == 0)
            even += numArray[i];
        else
            odd += numArray[i];
    }

    return even - odd;
}

console.log("Test Exist Higher");
console.log(existHigher([-10, -99, -57, -4], -4));
console.log(existHigher([4, 3, 3, 3, 2, 2, 2], 4));
console.log(existHigher([], 5));


console.log("Test Odd and Even");
console.log(oddAndEven([5, 3, 15, 22, 4]));
console.log(oddAndEven([4, 3, 3, 3, 2, 2, 2]));
console.log(oddAndEven([]));
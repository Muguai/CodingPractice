/*
Kattis Problem

99 Problems

Ingrid is the founder of a company that sells bicycle parts. She used to set the prices of products quite arbitrarily, but now she has decided that it would be more profitable if the prices end in

.

You are given a positive integer
, the price of a product. Your task is to find the nearest positive integer to which ends in

. If there are two such numbers that are equally close, find the bigger one.
Input

The input contains one integer
(), the price of a product. It is guaranteed that the number does not end in

.
Output

Print one integer, the closest positive integer that ends in
. In case of a tie, print the bigger one.

*/

function NinetyNineProblems(N){
    amountOfDigits = N.toString().length;
    
    if(amountOfDigits < 3)
        return 99;

    const first = N.toString()[0];
    const NinteyNine = "9".repeat(amountOfDigits - 1);
    
    if(Math.abs(first + NinteyNine - N ) <=  Math.abs(NinteyNine - N))
        return first + NinteyNine;
    
    return NinteyNine;
}


console.log(NinetyNineProblems(10));
console.log(NinetyNineProblems(249));
console.log(NinetyNineProblems(1501));
console.log(NinetyNineProblems(1499));

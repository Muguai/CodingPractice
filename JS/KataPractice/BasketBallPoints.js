/*
Kata problem 1

Basketball Points 
You are counting points for a basketball game, given the amount of 2-pointers scored and 3-
pointers scored, find the final points for the team and return that value. 
*/


function points(twoPointers, threePointers){
    if(isNaN(twoPointers) || isNaN(threePointers))
        throw new Error("Input has to be numbers");
    
    
    if(twoPointers < 0 || threePointers < 0)
        throw new Error("Points cant be negative");
        
    return (twoPointers * 2) + (threePointers * 3);
}

console.log(points("hello",1));

// Alt + Shift + F (Auto format)
/// Ctrl Space (Auto suggestion)
// Alt + Shift + up / down (Copies line up  or down)
// Alt + up / down (Moves lines up or down)
// Ctrl + / 
/*

Kata Problem 6

Car Park Exit 
 
You are stuck in a multi-story car parking lot. Your task is to exit the carpark using 
only the staircases. Exit is always at the bottom right of the ground floor. 
Create a function that takes a two-dimensional array where: 
1.  Free carparking spaces are represented by a  0  
2.  Staircases are represented by a  1  
3.  Your starting position is represented by a  2  and can be at any level of the car 
park. 
4.  Exit is always at the bottom right of the ground floor. 
5.  You must use the staircases (1) to go down a level. 
6.  Each floor will have only one staircase apart from the ground floor which will 
not have any staircases. 
... and returns an array of the quickest route out of the carpark. 
arr = [ 
  [1, 0, 0, 0, 2], 
  [0, 0, 0, 0, 0] 
] 
 
// Starting from 2, move to left 4 times = "L4" 
// Go down from stairs 1 step = "D1" 
// Move to right 4 times to exit from right bottom corner = "R4" 
 
result = ["L4", "D1", "R4"] 
 
See the below examples to better understand: 
Examples 
parking_exit([ 
  [1, 0, 0, 0, 2], 
  [0, 0, 0, 0, 0] 
]) ➞ ["L4", "D1", "R4"] 
parking_exit([ 
  [2, 0, 0, 1, 0], 
  [0, 0, 0, 1, 0], 
  [0, 0, 0, 0, 0] 
]) ➞ ["R3", "D2", "R1"] 
 
// Starting from 2, move to right 3 times = "R3" 
// Go down from stairs 2 steps = "D2" 
// Move to right 1 step to exit from right bottom corner = "R1" 
parking_exit([[0, 0, 0, 0, 2]]) ➞ [] 
 
// You are already at right bottom corner. 
*/


function parking_exit(...args) {
    let dir = [];
    let playerIndex = args[0].indexOf(2);
    let array = args;
    let exitIndex = 0;
    array[array.length - 1][array[array.length - 1].length - 1] = 1;

    while (array.length > 0) {
        
        exitIndex = array[0].indexOf(1);
        
        const difference = Math.abs(playerIndex - exitIndex);

        if (playerIndex - difference == exitIndex && difference != 0)
            dir.push("L" + (difference));
        else if (difference != 0)
            dir.push("R" + (difference));

        if (array.length > 1) 
            dir.push("D" + 1);

        playerIndex = exitIndex;
        array.shift();
    }

    return dir;
}

console.log(parking_exit(
    [2, 0, 0, 1, 0],
    [0, 0, 0, 1, 0],
    [0, 0, 0, 0, 0]));

console.log(parking_exit(
    [1, 0, 0, 0, 2],
    [0, 0, 0, 0, 0]
));
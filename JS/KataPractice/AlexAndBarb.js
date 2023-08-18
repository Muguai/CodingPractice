/*
Kattis Problem

Alex and Barb

Alex and Barb are waiting for their two cousins to visit for dinner. Since their cousins tend to get involved in all sorts of shenanigans, Alex and Barb decide to pass the time with a little card game.

The game is as follows: there is a stack of
cards on the table. Alex and Barb take turns taking from to

cards, beginning with Alex. The first player with no valid moves left loses.

Given
, , and

, determine which player will win the game provided that both play with an optimal strategy.
Inputs

The input consists of a single line containing three space-separated integers
and

.
Outputs

On a single line output the name of the winning player.

*/


function alexAndBarb(k,m,n){
    //An optimal strategy in this game must be to take the lowest or highets value depending on the situation
    
    if(k % (m+n) > m)
        return "Alex";
    else
        return "Barb";
}

console.log(alexAndBarb(5,2,2));
console.log(alexAndBarb(25,3,10));
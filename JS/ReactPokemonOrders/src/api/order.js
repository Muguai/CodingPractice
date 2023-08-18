import { createHeaders } from ".";
const apiUrl = process.env.REACT_APP_API_URL;


export const orderAdd = async (user, pokemon) => {
    try {
        console.log("User and pokemon ", pokemon, user);
        const response = await fetch(`${apiUrl}/${user.id}`, {
            method: 'PATCH',
            headers: createHeaders(),
            body: JSON.stringify({
                username: user.username,
                pokemon: [...user.pokemon, pokemon]
            })
        });

        if(!response.ok){
            throw new Error('Could not update ' + user.username)
        }


        const result = await response.json();

        console.log("Result " + result);
        return  [null, result];
    }
    catch (error){
        return [error.message, null]
    }
}

export const orderClearHistory = async (userId) =>{
    try {
        const response = await fetch(`${apiUrl}/${userId}`, {
            method: 'PATCH',
            headers: createHeaders(),
            body: JSON.stringify({
                pokemon: []
            })
        })
        if(!response.ok){
            throw new Error('Could not update orders');
        }
        const result = await response.json();
        console.log("Result ", result);
        return [null, result];
    } catch (error) {
        return [error, null];
    }
}
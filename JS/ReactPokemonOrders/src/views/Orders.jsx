import { useState } from "react";
import OrderForm from "../components/Orders/OrderForm";
import OrderPokemonButton from "../components/Orders/OrderPokemonButton";
import withAuth from "../hoc/withAuth";
import { useUser } from "../context/UserContext";
import { orderAdd } from "../api/order";
import { storageSave } from "../utils/storage";
import { STORAGE_KEY_USER } from "../const/storageKeys";

const POKEMON = [
  {
    id: 1,
    name: "Plusle",
    image: "img/Plusle.png",
  },
  {
    id: 2,
    name: "Cyndaquil",
    image: "img/Cyndaquil.png",
  },
  {
    id: 3,
    name: "Shroomish",
    image: "img/Shroomish.png",
  },
  {
    id: 4,
    name: "Teddyursa",
    image: "img/Teddyursa.png",
  },
];

const Orders = () => {
  const [pokemon, setPokemon] = useState(null);
  const {user} = useUser();

  const handlePokemonClicked = (pokemonId) => {
    setPokemon(POKEMON.find((pokemon) => pokemon.id === pokemonId));
  };

  const handleOrderClick = async (notes) => {
      if(!pokemon){
        alert("Please select a pokemon first");
        return;
      }

      const order = (pokemon.name + ' ' + notes).trim();
 
      console.log("Order " + order);

      const [error, updatedUser] = await orderAdd(user,order);

      if(error !== null){
        return;
      }

      storageSave(STORAGE_KEY_USER, updatedUser)
      setUser(updatedUser);

      console.log('Error', error);
      console.log('Result', result);
  }

  const availableCoffees = POKEMON.map((pokemon) => { 
    return (
      <OrderPokemonButton
        key={pokemon.id}
        pokemon={pokemon}
        onSelect={handlePokemonClicked}
      />
    );
  });

  return (
    <>
      <h1>Pokemon</h1>
      <section id="pokemon-options">{availableCoffees}</section>
      <section id="pokemon-notes">
        <OrderForm onOrder={ handleOrderClick}></OrderForm>
      </section>
      <h4>Summary: </h4>
      {pokemon && <p>Selected Pokemon: {pokemon.name}</p>}
    </>
  );
};

export default withAuth(Orders);

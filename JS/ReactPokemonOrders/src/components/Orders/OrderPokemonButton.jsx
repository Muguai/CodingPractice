const OrderPokemonButton = ({ pokemon, onSelect}) => {
    return (
        <button onClick={() =>onSelect(pokemon.id)}>
            <aside>
                <img src={ pokemon.image } alt={ pokemon.name } width="55"/>
            </aside>
            <section>
                <b>{ pokemon.name }</b>
            </section>
        </button>
    )
}

export default OrderPokemonButton;
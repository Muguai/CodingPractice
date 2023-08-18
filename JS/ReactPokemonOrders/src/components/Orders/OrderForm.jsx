import { useForm } from "react-hook-form";

const OrderForm = ({onOrder}) => {
    
    const { register, handleSubmit ,formState: {errors}} = useForm();

    const onSubmit = ({pokeNotes}) => {
        onOrder(pokeNotes);
    }
    
    return(
        <form onSubmit={handleSubmit(onSubmit)}>
            <fieldset>
                <label htmlFor="pokemon-notes">Pokemon Name:</label>
                <input type="text" {...register('pokeNotes')} placeholder="PokemonName"/>
            </fieldset>
            <button type="submit">Choose</button>
        </form>
    )
}
export default OrderForm
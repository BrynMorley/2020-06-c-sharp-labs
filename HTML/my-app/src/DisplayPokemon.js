import React from 'react'
import Pokemon from './Pokemon'

const DisplayPokemon = (props) =>{
    return(
        <div>
            {props.pokemon.map(pokemon => <Pokemon pokemon={pokemon}/>)}
        </div>
    )
}

export default DisplayPokemon
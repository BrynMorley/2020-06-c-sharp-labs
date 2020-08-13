import React from 'react';
import ChildComponent from './ChildComponent'
import ShowComponent from './ShowComponent'
import DisplayPokemon from  './DisplayPokemon'

class LikeComponent extends React.Component{

    constructor(){
        super()
        this.state = {
            likes: 0,
            isShown: false,
            pokemon: []
        }
    }

    componentDidMount() {
        fetch("https://pokeapi.co/api/v2/pokemon?limit=20")
            .then(response => response.json())
            .then(pokemonJson => this.setState({pokemon: pokemonJson}))
    }

    incrementLikeCount = () => {
        this.setState({
            likes: this.state.likes + 1
        })
    }

    handleShowChange = () => 
    this.setState({
        isShown: !this.state.isShown
    })

    render() {
        return(
            <main>
                <div>
                    <h1> This is the amount of likes: {this.state.likes}</h1>
                    <ChildComponent incrementLikeCount={this.incrementLikeCount}/>
                    <button onClick={() => this.handleShowChange()}>Show me</button>
                    {this.state.isShown ? <DisplayPokemon /> : null}
                  
                </div>
            </main>
        )
        
    }
}

export default LikeComponent
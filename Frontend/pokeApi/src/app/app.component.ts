import { Component } from '@angular/core';
import {IPokemon} from '../app/shared/IPokemon';
import { PokemonService } from '../app/shared/Services/PokemonService';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'pokeApi';
  ItemsToDelete:IPokemon[] = []; 
  selectAll:boolean = false;
  searchTerm:string = "";
  createNew:boolean = false;
  deleteItem:boolean = false;
  pokemonList:IPokemon[] = [];
  adminError:string = "Consulte al administrador del sistema.";
  error:boolean = false;
  thirdToEdit:IPokemon;
  currentPage: number = 1;
  itemsPerPage: number = 2;
  collection: any[] = [];  

  constructor(private PokemonService:PokemonService) { }

  ngOnInit() { 
    this.getAll();
  }

  getAll() {
    this.PokemonService.getAll().subscribe(data => {
      this.pokemonList = data.results;
    }, (err) => { 
    })
  }

  hideDetails(pokemon:IPokemon){
    if(pokemon != null){
      pokemon.showDetails = false;
    }
  }

  showDetails(pokemon:IPokemon){
    if(pokemon != null){
      (pokemon.showDetails == true) ? pokemon.showDetails = false:pokemon.showDetails = true;  
        this.PokemonService.getById(pokemon).subscribe( data => {
          pokemon.base_Experience = data.base_Experience;
          pokemon.isDefault = data.isDefault;
          pokemon.height = data.height;
          pokemon.weight = data.weight;
          console.log(data);
        });
    }
  }
}
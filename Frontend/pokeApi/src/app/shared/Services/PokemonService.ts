import {Injectable} from '@angular/core';
import { IPokemon } from '../IPokemon';
import { Observable, Subject, of, BehaviorSubject, throwError } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';

@Injectable()

export class PokemonService {
    private pokemonList : IPokemon[];
    private configUrl = 'http://localhost:57953/';

    constructor(private http:HttpClient) {
        this.pokemonList = new Array<IPokemon>();
        // this.observableThirdParties = new BehaviorSubject<IThirdParty[]>(this.thirdParties);
    }

    getAll(){
        return this.http.get<IPokemon[]>(this.configUrl + "Pokemon")
         .pipe(
             catchError((err) => {
                 return throwError(err.message); 
             })
         )
     }

     getById(pokemon: IPokemon){
         const id = pokemon.url.split("/").splice(-2)[0];
         console.log(id);
        return this.http.get<IPokemon>(this.configUrl + "Pokemon/" + id);
     }
}
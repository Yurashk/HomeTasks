import { Component, OnInit, Inject } from '@angular/core';
import { Film, Place, DateTimePlace, TransferModel } from '../film.model';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-cinema-comp',
  templateUrl: './cinema-comp.component.html',
  styleUrls: ['./cinema-comp.component.css']
})
export class CinemaCompComponent implements OnInit {
  public forecasts: Film[] = [];
  public cinemaPlaces: Place[] = [];
  selectedFilm: Film;
  selectedDate: any;
  selectedPlace: Place;
  visibility: boolean;
  reservedSeats: Array<number> = [];
  _baseUrl: string;
  resultWind:boolean ;
  counter:number=0;
  ngOnInit() {
  }
  constructor(public http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl;
    http.get<Film[]>(baseUrl + 'api/Film').subscribe(result => {
      for (const key in result) {
        if (key) {
          const film = new Film();
          film.Id = result[key]['id'];
          film.Name = result[key]['name'];
          film.DateTimePlaces = result[key]['dateTimePlaces'];
          this.forecasts.push(film);
        }
      }
    }, error => console.error(error));
  }
  // ВЫбор фильма
  resivedFilm:Film;
  onSelectFilm(film: Film) {
    
    this.selectedDate = null;
    this.selectedFilm=null;
    this.selectedFilm = film;
    
   
  }
  // Выбор даты
  reservedDates:DateTimePlace;
  selectedDates(date: DateTimePlace) {
   
    this.selectedDate = date;
    if(this.selectedDate.active){
      this.selectedDate.passiv;
    }
    else if(this.reservedDates && this.selectedDate!=this.reservedDates){

      this.selectedDate=this.reservedDates;
      this.selectedDate.active=!this.selectedDate.active;
      this.selectedDate=date;
    }
    this.selectedDate.active=!this.selectedDate.active;
    this.reservedDates=date;
    // if(this.selectedDate.active){
    //   this.selectedDate.passiv;
    // }
    // this.selectedDate.active=!this.selectedDate.active;
  }
  setSeats(id: number) {
    //
  }
  // Выбор места в зале
  selectedPlaces(seat: Place) {
    const model = new TransferModel();
    model.FilmId = this.selectedFilm.Id;
    this.counter++;
    model.Date =  this.selectedDate.dateTime;
    model.PlaceId = seat.id;
    this.selectedPlace = seat;
    this.selectedPlace.isReserved = true;
    this.http.post(this._baseUrl + 'api/Film/AddReserve', model).subscribe(() =>
      this.http.get<Place[]>(this._baseUrl + 'api/Film/GetPlaces').subscribe((result) => {
        this.cinemaPlaces = [];
        for (const key in result) {
          if (key) {
            const plases = new Place();
            plases.id = result[key]['id'];
            plases.row = result[key]['row'];
            plases.isReserved = result[key]['isReserved'];
            
            this.cinemaPlaces.push(plases);
          }
        }
        console.log(this.cinemaPlaces);
      }, error => console.error(error)));

    this.reservedSeats.push(seat.id);
    this.reservedPlace(seat);
  }
  reservedPlace(seat: Place) {
    console.log( seat.isReserved);
    return seat.isReserved ? 'seats reservedPlaces' : 'default';
  }
  result(){
    
    this.resultWind=!this.resultWind;
    if(!this.resultWind){
      this.selectedDate = null;
    this.selectedFilm=null;
    this.counter=0;
    }

  } 
}

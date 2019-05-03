import { Component, Inject } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Film } from '../film.model';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: Film[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.post(baseUrl + 'api/Film/AddReserve', 1).subscribe();
    http.get<Film[]>(baseUrl + 'api/Film').subscribe(result => {
      for (const key in result) {
        if (key) {
          const film = new Film();
          film.Id = result[key]['id'];
          film.Name = result[key]['name'];
          film.DateTimePlaces = result[key]['dateTimes'];
          this.forecasts.push(film);

        }
      }
      console.log(this.forecasts);
    }, error => console.error(error));
    http.get(baseUrl + 'api/Film/GetPlaces').subscribe((result) => console.log(result));
  }
}

interface WeatherForecast {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

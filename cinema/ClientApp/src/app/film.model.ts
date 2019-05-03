export class Film {
    Id: number;
    Name: string;
    DateTimePlaces: DateTimePlace[];
}
export class Place {
    id: number;
    row: number;
    number: number;
    isReserved: boolean;
}
export class DateTimePlace {
    dateTime: string;
    places: Place[];
}
export class TransferModel {
    FilmId: number;
    Date: string;
    PlaceId: number;
}

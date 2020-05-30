import { Photo } from './photo';

export interface User {
    /** Postawowe informacje */
    id: number;
    username: string;
    gender: string;
    age: number;
    created: Date;
    lastActive: Date;
    city: string;
    country: string;

    /** Zakładka Info */
    school: string;
    department: string;
    direction: string;
    specialisation: string;
    semester: string;

    /** Zakłada  O mnie */
    motto: string;
    description: string;

    /** Zakłaka Pasje, zaiteresowania */
    interests: string;
    freeTime: string;
    sport: string;
    movies: string;
    music: string;

    /** Zakładka Zdjecia */
    photos: Photo[];
    photoUrl: string;
}

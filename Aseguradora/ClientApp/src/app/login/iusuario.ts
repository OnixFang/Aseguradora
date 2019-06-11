import { Rol } from './rol.enum';

export interface IUsuario {
    username: string;
    password: string;
    persona: any;
    rol: Rol;
}

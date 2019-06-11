import { Rol } from './rol.enum';
import { IPersona } from './ipersona';

export interface IUsuario {
    id: number;
    username: string;
    password: string;
    persona: IPersona;
    rol: Rol;
}

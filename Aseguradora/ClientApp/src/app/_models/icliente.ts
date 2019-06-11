import { IPoliza } from "./ipoliza";

export interface ICliente {
  id: number;
  cedula: string;
  nombre: string;
  apellido: string;
  direccion: string;
  telefono: string;
  ciudad: string;
  polizas: IPoliza;
}

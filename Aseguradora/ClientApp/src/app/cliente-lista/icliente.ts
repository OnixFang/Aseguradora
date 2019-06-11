import { Ipoliza } from "../poliza/ipoliza";

export interface ICliente {
  Id: number;
  Cedula: string;
  Nombre: string;
  Apellido: string;
  Direccion: string;
  Telefono: string;
  Ciudad: string;
  Polizas: Ipoliza;
}

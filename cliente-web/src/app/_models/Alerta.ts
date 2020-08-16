import { Objeto } from './Objeto';
import { Regra } from './Regra';

export class Alerta extends Objeto{

    descricao: string;
    data: Date;
    regra: Regra;
}

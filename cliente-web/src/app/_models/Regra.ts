import { Objeto } from './Objeto';
import { RegraTipo } from './RegraTipo';

export class Regra extends Objeto{

    valor: number;
    periodo: number;
    tipo: RegraTipo;
    ativo: boolean;
}

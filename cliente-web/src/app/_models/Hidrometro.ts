import { Objeto } from './Objeto';
import { Registro } from './Registro';
import { Alerta } from './Alerta';
import { Regra } from './Regra';

export class Hidrometro{

    id: number;
    identificador: string;
    chave: string;
    modelo: string;
    descricao: string;
    ativo: boolean;
    registros: Array<Registro>;
    alertas: Array<Alerta>;
    regras: Array<Regra>;
}

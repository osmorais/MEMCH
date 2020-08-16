import { Objeto } from './Objeto';
import { Hidrometro } from './Hidrometro';

export class Conexao extends Objeto{

    host: string;
    ativo: boolean;
    descricao: string;
    hidrometro: Hidrometro;
}

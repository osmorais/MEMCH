import { Objeto } from './Objeto';
import { Conexao } from './Conexao';
import { Pessoa } from './Pessoa';

export class Usuario extends Objeto {
    login: string;
    senha: string;
    // conexoes: Conexao[];
    pessoa: Pessoa;
}

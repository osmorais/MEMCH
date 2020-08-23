/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.InterfaceDAO.IPessoaDAO;
import java.util.ArrayList;
import modelo.Pessoa;

/**
 *
 * @author osmar
 */
public class PessoaDAO implements IPessoaDAO{
//                                Table "public.pessoa"
// Column |         Type          |                      Modifiers                      
//--------+-----------------------+-----------------------------------------------------
// id     | integer               | not null default nextval('pessoa_id_seq'::regclass)
// nome   | character varying(20) | 
// cpf    | character varying(14) | 
//Indexes:
//    "pk_pessoa" PRIMARY KEY, btree (id)
//Referenced by:
//    TABLE "usuario" CONSTRAINT "pessoafk" FOREIGN KEY (pessoaid) REFERENCES pessoa(id)

    @Override
    public void cadastrar(Pessoa alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void consultar(Pessoa alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void alterar(Pessoa alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void remover(Pessoa alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Pessoa> listar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}

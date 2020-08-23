/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.InterfaceDAO.IUsuarioDAO;
import java.util.ArrayList;
import modelo.Hidrometro;
import modelo.Usuario;

/**
 *
 * @author osmar
 */
public class UsuarioDAO implements IUsuarioDAO{
//                                     Table "public.usuario"
//  Column  |         Type          |                      Modifiers                       
//----------+-----------------------+------------------------------------------------------
// id       | integer               | not null default nextval('usuario_id_seq'::regclass)
// login    | character varying(20) | 
// senha    | character varying(20) | 
// pessoaid | integer               | not null
//Indexes:
//    "pk_usuario" PRIMARY KEY, btree (id)
//Foreign-key constraints:
//    "pessoafk" FOREIGN KEY (pessoaid) REFERENCES pessoa(id)

    @Override
    public void cadastrar(Usuario alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void consultar(Usuario alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void alterar(Usuario alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void remover(Usuario alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Usuario> listar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}

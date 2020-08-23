/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.HidrometroDAO;
import dao.InterfaceDAO.IHidrometroDAO;
import dao.InterfaceDAO.IUsuarioDAO;
import dao.UsuarioDAO;
import java.util.ArrayList;
import modelo.Usuario;

/**
 *
 * @author osmar
 */
public class SrvcUsuario {
     public static ArrayList<Usuario> listar(){
        
        IUsuarioDAO usuariodao = new UsuarioDAO();
        
        return usuariodao.listar();
    }
     
     public static Usuario consultar(Usuario usuario){

        IUsuarioDAO usuariodao = new UsuarioDAO();
        usuariodao.consultar(usuario);
        
        return usuario;
    }
}

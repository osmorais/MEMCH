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
    public static Usuario consultarLogin(Usuario usuario){

        IUsuarioDAO usuariodao = new UsuarioDAO();
        usuariodao.consultarLogin(usuario);
        
        return usuario;
    }
    public static Usuario cadastrar(Usuario usuario){

        IUsuarioDAO usuariodao = new UsuarioDAO();
        usuariodao.cadastrar(usuario);
        
        return usuario;
    }
    public static Usuario alterar(Usuario usuario){

        IUsuarioDAO usuariodao = new UsuarioDAO();
        usuariodao.alterar(usuario);
        
        return usuario;
    }
    public static Usuario remover(Usuario usuario){

        IUsuarioDAO usuariodao = new UsuarioDAO();
        usuariodao.remover(usuario);
        
        return usuario;
    }
}

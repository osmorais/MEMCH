/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao.InterfaceDAO;

import java.util.ArrayList;
import modelo.Hidrometro;
import modelo.Usuario;

/**
 *
 * @author osmar
 */
public interface IUsuarioDAO {
    void cadastrar(Usuario usuario);
    void consultar(Usuario usuario);
    void consultarLogin(Usuario usuario);
    void alterar(Usuario usuario);
    void remover(Usuario usuario);
    ArrayList<Usuario> listar();
}

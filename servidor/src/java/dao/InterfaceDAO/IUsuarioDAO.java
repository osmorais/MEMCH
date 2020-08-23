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
    void cadastrar(Usuario alerta);
    void consultar(Usuario alerta);
    void alterar(Usuario alerta);
    void remover(Usuario alerta);
    ArrayList<Usuario> listar();
}

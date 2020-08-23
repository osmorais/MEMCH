/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao.InterfaceDAO;

import java.util.ArrayList;
import modelo.Hidrometro;
import modelo.Pessoa;

/**
 *
 * @author osmar
 */
public interface IPessoaDAO {
    void cadastrar(Pessoa alerta);
    void consultar(Pessoa alerta);
    void alterar(Pessoa alerta);
    void remover(Pessoa alerta);
    ArrayList<Pessoa> listar();
}

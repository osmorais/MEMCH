/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao.InterfaceDAO;

import java.util.ArrayList;
import modelo.Conexao;

/**
 *
 * @author osmar
 */
public interface IConexaoDAO {
    Conexao cadastrar(Conexao conexao);
    void consultar(Conexao conexao);
    Conexao alterar(Conexao conexao);
    void remover(Conexao conexao);
    ArrayList<Conexao> listar();
}

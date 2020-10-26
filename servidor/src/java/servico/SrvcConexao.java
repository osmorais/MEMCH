/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.ConexaoDAO;
import dao.HidrometroDAO;
import dao.InterfaceDAO.IConexaoDAO;
import dao.InterfaceDAO.IHidrometroDAO;
import java.util.ArrayList;
import modelo.Conexao;

/**
 *
 * @author osmar
 */
public class SrvcConexao {
    public static Conexao cadastrar(Conexao conexao){

        IConexaoDAO conexaodao = new ConexaoDAO();
        conexaodao.cadastrar(conexao);
        
        return conexao;
    }
    public static Conexao alterar(Conexao conexao){

        IConexaoDAO conexaodao = new ConexaoDAO();
        conexaodao.alterar(conexao);
        
        return conexao;
    }
    public static Conexao remover(Conexao conexao){

        IConexaoDAO conexaodao = new ConexaoDAO();
        conexaodao.consultar(conexao);
        
        conexaodao.remover(conexao);
        
        return conexao;
    }
    public static ArrayList<Conexao> listar(){
        
        //ArrayList<Registro> arrdepartamento = new ArrayList<Registro>();
        IConexaoDAO conexaodao = new ConexaoDAO();
        
        return conexaodao.listar();
    }
}

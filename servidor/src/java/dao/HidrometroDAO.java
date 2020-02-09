/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.sql.Connection;
import java.util.ArrayList;
import modelo.Hidrometro;

/**
 *
 * @author osmar
 */
public class HidrometroDAO implements IHidrometroDAO{
    private final String SELECTALL = "SELECT * FROM HIDROMETRO;";
    private final String SELECTID = "SELECT * FROM HIDROMETRO WHERE ID=?;";
    private static final String INSERT = "INSERT INTO HIDROMETRO "
            + "(IDENTIFICADOR, CHAVE, MODELO, DESCRICAO, ATIVO) VALUES "
            + "(?,?,?,?,?)";
    private static final String DELETE = "DELETE FROM HIDROMETRO WHERE ID=?";
    private static final String UPDATE = "UPDATE HIDROMETRO "
            + "SET IDENTIFICADOR=?, CHAVE=?, MODELO=?, DESCRICAO=?, ATIVO=?"
            + " WHERE ID=?";
    private Connection conexao;
    
    @Override
    public void cadastrar(Hidrometro hidrometro) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void consultar(Hidrometro hidrometro) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void alterar(Hidrometro hidrometro) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void remover(Hidrometro hidrometro) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Hidrometro> listar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}

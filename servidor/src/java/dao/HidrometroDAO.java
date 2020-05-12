/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import modelo.Hidrometro;
import util.ConnectionFactory;

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
        try {
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTID);
            stmt.setInt(1, hidrometro.getId());

            ResultSet rs = stmt.executeQuery();
            if (rs.next()) {
                hidrometro.setId(rs.getInt("id"));
                hidrometro.setIdentificador(rs.getString("identificador"));
                hidrometro.setChave(rs.getString("chave"));
                hidrometro.setDescricao(rs.getString("descricao"));
                hidrometro.setModelo(rs.getString("modelo"));
                hidrometro.setAtivo(rs.getInt("ativo") == 1);
                
                IRegistroDAO registrodao = new RegistroDAO();
                hidrometro.setRegistros(registrodao.listar()); 
                
                IAlertaDAO alertadao = new AlertaDAO();
                hidrometro.setAlertas(alertadao.listar()); 
                
                IRegraDAO regradao = new RegraDAO();
                hidrometro.setRegras(regradao.listar()); 
            }
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
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

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
import modelo.Regra;
import modelo.RegraTipo;
import util.ConnectionFactory;

/**
 *
 * @author pi
 */
public class RegraDAO implements IRegraDAO{
    private final String SELECTALL = "SELECT * FROM REGRA;";
    private final String SELECTID = "SELECT * FROM REGRA WHERE ID=?;";
    private static final String INSERT = "INSERT INTO REGRA "
            + "(DESCRICAO) values "
            + "(?)";
    private static final String DELETE = "DELETE FROM REGRA WHERE ID=?";
    private static final String UPDATE = "UPDATE REGRA "
            + "SET DESCRICAO=?"
            + " WHERE ID=?";
    private Connection conexao;

    @Override
    public void cadastrar(Regra regra) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void consultar(Regra regra) {
        try {
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTID);
            stmt.setInt(1, regra.getId());

            ResultSet rs = stmt.executeQuery();
            if (rs.next()) {
                regra.setId(rs.getInt("id"));
                regra.setValor(rs.getDouble("valor"));
                regra.setAtivo(rs.getInt("ativo"));
                
                RegraTipoDAO regratipodao = new RegraTipoDAO();
                RegraTipo regratipo = new RegraTipo();
                
                regratipo.setId(rs.getInt("regratipofk"));
                regratipodao.consultar(regratipo);
                
                regra.setTipo(regratipo);
            }
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void alterar(Regra regra) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void remover(Regra regra) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Regra> listar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}

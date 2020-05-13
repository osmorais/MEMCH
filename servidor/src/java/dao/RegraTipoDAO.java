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
import java.sql.Statement;
import java.util.ArrayList;
import modelo.Alerta;
import modelo.Regra;
import modelo.RegraTipo;
import util.ConnectionFactory;

/**
 *
 * @author osmar
 */
public class RegraTipoDAO implements IRegraTipoDAO{
    private final String SELECTALL = "SELECT * FROM REGRATIPO;";
    private final String SELECTID = "SELECT * FROM REGRATIPO WHERE ID=?;";
    private static final String INSERT = "INSERT INTO REGRATIPO "
            + "(DESCRICAO) values "
            + "(?)";
    private static final String DELETE = "DELETE FROM REGRATIPO WHERE ID=?";
    private static final String UPDATE = "UPDATE REGRATIPO "
            + "SET DESCRICAO=?"
            + " WHERE ID=?";
    private Connection conexao;
    
    @Override
    public void cadastrar(RegraTipo regraTipo) {
         try {
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(INSERT,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setString(1, regraTipo.getDescricao());
            
            stmt.execute();
            
            ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                regraTipo.setId(rs.getInt(1));
            }
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void consultar(RegraTipo regraTipo) {
        try {
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTID);
            stmt.setInt(1, regraTipo.getId());

            ResultSet rs = stmt.executeQuery();
            if (rs.next()) {
                regraTipo.setId(rs.getInt("id"));
                regraTipo.setDescricao(rs.getString("descricao"));
            }
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void alterar(RegraTipo regraTipo) {
        try {
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(UPDATE);
            stmt.setString(1, regraTipo.getDescricao());
            stmt.setInt(2, regraTipo.getId());
            
            stmt.execute();
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void remover(RegraTipo regraTipo) {
        try {
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(DELETE);
            stmt.setInt(1, regraTipo.getId());

            stmt.execute();
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public ArrayList<RegraTipo> listar() {
        try {
            ArrayList<RegraTipo> arrregratipo = new ArrayList<RegraTipo>();
            
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTALL);

            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                RegraTipo regratipo = new RegraTipo();
                regratipo.setId(rs.getInt("id"));
                regratipo.setDescricao(rs.getString("descricao"));
                
                arrregratipo.add(regratipo);
            }
            return arrregratipo;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
    
}

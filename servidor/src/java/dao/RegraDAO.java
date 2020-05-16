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
import modelo.Hidrometro;
import modelo.Regra;
import modelo.RegraTipo;
import util.ConnectionFactory;

/**
 *
 * @author pi
 */
public class RegraDAO implements IRegraDAO{
//        Column    |  Type   |                     Modifiers                      
//--------------+---------+----------------------------------------------------
// id           | integer | not null default nextval('regra_id_seq'::regclass)
// valor        | numeric | 
// regratipofk  | integer | not null
// hidrometrofk | integer | not null
// periodo      | integer | 
// ativo        | integer | not null

    private final String SELECTALL = "SELECT * FROM REGRA;";
    private final String SELECTID = "SELECT * FROM REGRA WHERE ID=?;";
    private static final String INSERT = "INSERT INTO REGRA "
            + "(valor, regratipofk, hidrometrofk, periodo, ativo) values "
            + "(?,?,?,?,?);";
    private static final String DELETE = "DELETE FROM REGRA WHERE ID=?";
    private static final String UPDATE = "UPDATE REGRA "
            + "SET valor=?, regratipofk=?, hidrometrofk=?, periodo=?, ativo=?"
            + " WHERE ID=?;";
    private Connection conexao;

    @Override
    public Regra cadastrar(Regra regra) {
        try {
            ConnectionFactory con = new ConnectionFactory();
            conexao = con.getConnection();

            PreparedStatement stmt = conexao.prepareStatement(INSERT,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setDouble(1, regra.getValor());
            //stmt.setString(1, regra.getDescricao());
            stmt.setInt(1, regra.getTipo().getId());
            stmt.setInt(1, regra.getPeriodo());
            stmt.setInt(1, regra.getAtivo() ? 1 : 0);

            int lastId = 0;

            stmt.execute();
            final ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                lastId = rs.getInt(1);
            }

            regra.setId(lastId);
            ConnectionFactory.closeConnection(conexao, stmt);
            return regra;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
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
                regra.setPeriodo(rs.getInt("periodo"));
                regra.setAtivo(rs.getInt("ativo") == 1);
                
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
    public Regra alterar(Regra regra) {
        try {
            ConnectionFactory con = new ConnectionFactory();
            conexao = con.getConnection();

            PreparedStatement stmt = conexao.prepareStatement(UPDATE,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setDouble(1, regra.getValor());
           // stmt.setInt(2, regra.get);
            //"(valor, regratipofk, hidrometrofk, periodo, ativo) values "
            

            int lastId = 0;

            stmt.execute();
            final ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                lastId = rs.getInt(1);
            }

            regra.setId(lastId);
            ConnectionFactory.closeConnection(conexao, stmt);
            return regra;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void remover(Regra regra) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Regra> listar() {
        try {
            ArrayList<Regra> arrregra = new ArrayList<Regra>();
            
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTALL);

            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Regra regra = new Regra();
                regra.setId(rs.getInt("id"));
                regra.setValor(rs.getDouble("valor"));
                regra.setPeriodo(rs.getInt("periodo"));
                
                RegraTipoDAO regratipodao = new RegraTipoDAO();
                RegraTipo regratipo = new RegraTipo();
                
                regratipo.setId(rs.getInt("regratipofk"));
                regratipodao.consultar(regratipo);
                
                regra.setTipo(regratipo);
                
                regra.setAtivo(rs.getInt("ativo") == 1);
                arrregra.add(regra);
            }
            return arrregra;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
    
}

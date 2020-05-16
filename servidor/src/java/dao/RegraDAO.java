/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.InterfaceDAO.IRegraDAO;
import dao.InterfaceDAO.IRegraTipoDAO;
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
//                            Table "public.regra"
//    Column    |  Type   |                     Modifiers                      
//--------------+---------+----------------------------------------------------
// id           | integer | not null default nextval('regra_id_seq'::regclass)
// valor        | numeric | 
// regratipofk  | integer | not null
// hidrometrofk | integer | not null
// periodo      | integer | 
// ativo        | integer | not null
//Indexes:
//    "regra_pkey" PRIMARY KEY, btree (id)
//Foreign-key constraints:
//    "fk_hidrometro" FOREIGN KEY (hidrometrofk) REFERENCES hidrometro(id)
//    "fk_regratipo" FOREIGN KEY (regratipofk) REFERENCES regratipo(id)
//Referenced by:
//    TABLE "alerta" CONSTRAINT "fk_regra" FOREIGN KEY (regrafk) REFERENCES regra(id)
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
    public void cadastrar(Regra regra, Hidrometro hidrometro) {
        try {
            ConnectionFactory con = new ConnectionFactory();
            conexao = con.getConnection();

            PreparedStatement stmt = conexao.prepareStatement(INSERT,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setDouble(1, regra.getValor());
            stmt.setInt(2, regra.getTipo().getId());
            stmt.setInt(3, hidrometro.getId());
            stmt.setInt(4, regra.getPeriodo());
            stmt.setInt(5, regra.isAtivo() ? 1 : 0);

            int lastId = 0;

            stmt.execute();
            final ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                lastId = rs.getInt(1);
            }

            regra.setId(lastId);
            ConnectionFactory.closeConnection(conexao, stmt);
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
    public void alterar(Regra regra, Hidrometro hidrometro) {
        try {
            ConnectionFactory con = new ConnectionFactory();
            conexao = con.getConnection();

            PreparedStatement stmt = conexao.prepareStatement(UPDATE,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setDouble(1, regra.getValor());
            stmt.setInt(2, regra.getTipo().getId());
            stmt.setInt(3, hidrometro.getId());
            stmt.setInt(4, regra.getPeriodo());
            stmt.setInt(5, regra.isAtivo() ? 1 : 0);
            stmt.setInt(6, regra.getId());
            
            int lastId = 0;

            stmt.execute();
            final ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                lastId = rs.getInt(1);
            }

            regra.setId(lastId);
            ConnectionFactory.closeConnection(conexao, stmt);
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void remover(Regra regra) {
        try {
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(DELETE);
            stmt.setInt(1, regra.getId());

            stmt.executeQuery();
            
            regra.setId(0);
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
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
                
                IRegraTipoDAO regratipodao = new RegraTipoDAO();
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

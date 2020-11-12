/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.InterfaceDAO.IConexaoDAO;
import dao.InterfaceDAO.IHidrometroDAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import modelo.Conexao;
import modelo.Hidrometro;
import util.ConnectionFactory;

/**
 *
 * @author osmar
 */
public class ConexaoDAO implements IConexaoDAO{
//                                    Table "public.conexao"
//    Column    |          Type          |                      Modifiers                       
//--------------+------------------------+------------------------------------------------------
// id           | integer                | not null default nextval('conexao_id_seq'::regclass)
// host         | character varying(15)  | not null
// ativo        | integer                | not null
// descricao    | character varying(100) | 
// hidrometrofk | integer                | not null
// usuariofk    | integer                | 
//Indexes:
//    "conexao_pkey" PRIMARY KEY, btree (id)
//Foreign-key constraints:
//    "hidrometrofk" FOREIGN KEY (hidrometrofk) REFERENCES hidrometro(id)
//    "usuariofk" FOREIGN KEY (usuariofk) REFERENCES usuario(id)

    private final String SELECTALL = "SELECT * FROM CONEXAO WHERE USUARIOFK=? order by ID;";
    private final String SELECTID = "SELECT * FROM CONEXAO WHERE ID=?;";
    private static final String INSERT = "INSERT INTO CONEXAO "
            + "(HOST, ATIVO, DESCRICAO, HIDROMETROFK, USUARIOFK) VALUES "
            + "(?,?,?,?,?)";
    private static final String DELETE = "DELETE FROM CONEXAO WHERE ID=?";
    private static final String UPDATE = "UPDATE CONEXAO "
            + "SET HOST=?, ATIVO=?, DESCRICAO=?, HIDROMETROFK=?"
            + " WHERE ID=?";
    private Connection conexao;
    
    @Override
    public void cadastrar(Conexao conexao, int usuarioid) {
        try {
            ConnectionFactory con = new ConnectionFactory();

            this.conexao = con.getConnection();
            PreparedStatement stmt = this.conexao.prepareStatement(INSERT,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setString(1, conexao.getHost());
            stmt.setInt(2, conexao.isAtivo()? 1 : 0);
            stmt.setString(3, conexao.getDescricao());
            stmt.setInt(4, usuarioid);
            
            IHidrometroDAO hidrometrodao = new HidrometroDAO();
            Hidrometro hidrometro = conexao.getHidrometro();
            
            hidrometrodao.cadastrar(hidrometro);
            stmt.setInt(4, hidrometro.getId());
            
            stmt.execute();
            
            ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                conexao.setId(rs.getInt(1));
            }
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void consultar(Conexao conexao) {
        try {
            ConnectionFactory con = new ConnectionFactory();

            this.conexao = con.getConnection();
            PreparedStatement stmt = this.conexao.prepareStatement(SELECTID);
            stmt.setInt(1, conexao.getId());

            ResultSet rs = stmt.executeQuery();
            if (rs.next()) {
                conexao.setId(rs.getInt("id"));
                conexao.setHost(rs.getString("host"));
                conexao.setAtivo(rs.getInt("ativo") == 1);
                conexao.setDescricao(rs.getString("descricao"));
                
                HidrometroDAO hidrometrodao = new HidrometroDAO();
                Hidrometro hidrometro = new Hidrometro();
                
                hidrometro.setId(rs.getInt("hidrometrofk"));
                hidrometrodao.consultar(hidrometro);
                
                conexao.setHidrometro(hidrometro);
            }
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void alterar(Conexao conexao) {
        try {
            ConnectionFactory con = new ConnectionFactory();
            this.conexao = con.getConnection();

            PreparedStatement stmt = this.conexao.prepareStatement(UPDATE,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setString(1, conexao.getHost());
            stmt.setInt(2, conexao.isAtivo()? 1 : 0);
            stmt.setString(3, conexao.getDescricao());
            
            IHidrometroDAO hidrometrodao = new HidrometroDAO();
            Hidrometro hidrometro = conexao.getHidrometro();
            hidrometrodao.alterar(hidrometro);
            conexao.setHidrometro(hidrometro);
            stmt.setInt(4, conexao.getHidrometro().getId());
            
            stmt.setInt(5, conexao.getId());
            
            int lastId = 0;

            stmt.execute();
            final ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                lastId = rs.getInt(1);
            }

            conexao.setId(lastId);
            ConnectionFactory.closeConnection(this.conexao, stmt);
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void remover(Conexao conexao) {
        try {
            ConnectionFactory con = new ConnectionFactory();

            this.conexao = con.getConnection();
            PreparedStatement stmt = this.conexao.prepareStatement(DELETE);
            stmt.setInt(1, conexao.getId());
            
            HidrometroDAO hidrometrodao = new HidrometroDAO();
            hidrometrodao.remover(conexao.getHidrometro());

            stmt.execute();
            
            conexao.setId(0);
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public ArrayList<Conexao> listar(int usuarioid) {
        try {
            ArrayList<Conexao> arrconexao = new ArrayList<Conexao>();
            
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTALL);
            stmt.setInt(1, usuarioid);

            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Conexao objconexao = new Conexao();
                objconexao.setId(rs.getInt("id"));
                objconexao.setHost(rs.getString("host"));
                objconexao.setAtivo(rs.getInt("ativo") == 1);
                objconexao.setDescricao(rs.getString("descricao"));
                
                HidrometroDAO hidrometrodao = new HidrometroDAO();
                Hidrometro hidrometro = new Hidrometro();
                
                hidrometro.setId(rs.getInt("hidrometrofk"));
                hidrometrodao.consultar(hidrometro);
                
                objconexao.setHidrometro(hidrometro);
                
                
                arrconexao.add(objconexao);
            }
            return arrconexao;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
    
}

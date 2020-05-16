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
//                  Table "public.conexao"
//    Column    |          Type          | Modifiers 
//--------------+------------------------+-----------
// id           | integer                | not null
// host         | character varying(15)  | not null
// ativo        | integer                | not null
// descricao    | character varying(100) | 
// hidrometrofk | integer                | not null
//Indexes:
//    "pkconexao" PRIMARY KEY, btree (id)
//Foreign-key constraints:
//    "hidrometrofk" FOREIGN KEY (hidrometrofk) REFERENCES hidrometro(id)

    private final String SELECTALL = "SELECT * FROM CONEXAO;";
    private final String SELECTID = "SELECT * FROM CONEXAO WHERE ID=?;";
    private static final String INSERT = "INSERT INTO CONEXAO "
            + "(HOST, ATIVO, DESCRICAO, HIDROMETROFK) VALUES "
            + "(?,?,?,?)";
    private static final String DELETE = "DELETE FROM CONEXAO WHERE ID=?";
    private static final String UPDATE = "UPDATE CONEXAO "
            + "(HOST, ATIVO, DESCRICAO, HIDROMETROFK) VALUES "
            + " WHERE ID=?";
    private Connection conexao;
    
    @Override
    public void cadastrar(Conexao conexao) {
        try {
            ConnectionFactory con = new ConnectionFactory();

            this.conexao = con.getConnection();
            PreparedStatement stmt = this.conexao.prepareStatement(INSERT,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setString(1, conexao.getHost());
            stmt.setInt(2, conexao.isAtivo()? 1 : 0);
            stmt.setString(3, conexao.getDescricao());
            
            IHidrometroDAO hidrometrodao = new HidrometroDAO();
            Hidrometro hidrometro = new Hidrometro();
            
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
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
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
            hidrometrodao.alterar(conexao.getHidrometro());
            
            stmt.setInt(4, conexao.getId());
            
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
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Conexao> listar() {
        try {
            ArrayList<Conexao> arrconexao = new ArrayList<Conexao>();
            
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTALL);

            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Conexao objconexao = new Conexao();
                objconexao.setId(rs.getInt("id"));
                objconexao.setHost(rs.getString("host"));
                objconexao.setAtivo(rs.getInt("ativo") == 1);
                objconexao.setDescricao(rs.getString("descricao"));
                
                IHidrometroDAO hidrometrodao = new HidrometroDAO();
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

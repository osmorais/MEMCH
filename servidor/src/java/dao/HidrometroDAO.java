/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.InterfaceDAO.IHidrometroDAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import modelo.Hidrometro;
import util.ConnectionFactory;

/**
 *
 * @author osmar
 */
public class HidrometroDAO implements IHidrometroDAO{
//                                        Table "public.hidrometro"
//    Column     |         Type          |                        Modifiers                        
//---------------+-----------------------+---------------------------------------------------------
// id            | integer               | not null default nextval('hidrometro_id_seq'::regclass)
// identificador | character varying(50) | 
// chave         | character varying(50) | 
// modelo        | character varying(50) | 
// descricao     | character varying(50) | 
// ativo         | boolean               | 
//Indexes:
//    "hidrometro_pkey" PRIMARY KEY, btree (id)
//Referenced by:
//    TABLE "regra" CONSTRAINT "fk_hidrometro" FOREIGN KEY (hidrometrofk) REFERENCES hidrometro(id)
//    TABLE "alerta" CONSTRAINT "fk_hidrometro" FOREIGN KEY (hidrometrofk) REFERENCES hidrometro(id)
//    TABLE "registro" CONSTRAINT "fk_hidrometro" FOREIGN KEY (hidrometrofk) REFERENCES hidrometro(id)
//    TABLE "conexao" CONSTRAINT "hidrometrofk" FOREIGN KEY (hidrometrofk) REFERENCES hidrometro(id)

    private final String SELECTALL = "SELECT * FROM HIDROMETRO where removido <> 1 order by id;";
    private final String SELECTID = "SELECT * FROM HIDROMETRO WHERE ID=?;";
    private static final String INSERT = "INSERT INTO HIDROMETRO "
            + "(IDENTIFICADOR, CHAVE, MODELO, DESCRICAO, ATIVO, REMOVIDO) VALUES "
            + "(?,?,?,?,?,?)";
    private static final String DELETE = "DELETE FROM HIDROMETRO WHERE ID=?";
    private static final String UPDATE = "UPDATE HIDROMETRO "
            + "SET IDENTIFICADOR=?, CHAVE=?, MODELO=?, DESCRICAO=?, ATIVO=?"
            + " WHERE ID=?";
    private static final String LOGICALDELETE = "UPDATE HIDROMETRO SET REMOVIDO=1 WHERE ID=?";
    private Connection conexao;
    
    @Override
    public void cadastrar(Hidrometro hidrometro) {
        try {
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(INSERT,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setString(1, hidrometro.getIdentificador());
            stmt.setString(2, hidrometro.getChave());
            stmt.setString(3, hidrometro.getModelo());
            stmt.setString(4, hidrometro.getDescricao());
            stmt.setInt(5, hidrometro.isAtivo()? 1 : 0);
            stmt.setInt(6, 0);
            
            stmt.execute();
            
            ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                hidrometro.setId(rs.getInt(1));
            }
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
    
//    public void consultarHidrometro(Hidrometro hidrometro) {
//        try {
//            ConnectionFactory con = new ConnectionFactory();
//
//            conexao = con.getConnection();
//            PreparedStatement stmt = conexao.prepareStatement(SELECTID);
//            stmt.setInt(1, hidrometro.getId());
//
//            ResultSet rs = stmt.executeQuery();
//            if (rs.next()) {
//                hidrometro.setId(rs.getInt("id"));
//                hidrometro.setIdentificador(rs.getString("identificador"));
//                hidrometro.setChave(rs.getString("chave"));
//                hidrometro.setDescricao(rs.getString("descricao"));
//                hidrometro.setModelo(rs.getString("modelo"));
//                hidrometro.setAtivo(rs.getInt("ativo") == 1);
//            }
//        } catch (SQLException ex) {
//            throw new RuntimeException("Erro: ", ex);
//        }
//    }

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
            }
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void alterar(Hidrometro hidrometro) {
        try {
            ConnectionFactory con = new ConnectionFactory();
            conexao = con.getConnection();

            PreparedStatement stmt = conexao.prepareStatement(UPDATE,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setString(1, hidrometro.getIdentificador());
            stmt.setString(2, hidrometro.getChave());
            stmt.setString(3, hidrometro.getModelo());
            stmt.setString(4, hidrometro.getDescricao());
            stmt.setInt(5, hidrometro.isAtivo()? 1 : 0);
            stmt.setInt(6, hidrometro.getId());
            
            int lastId = 0;

            stmt.execute();
            final ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                lastId = rs.getInt(1);
            }

            hidrometro.setId(lastId);
            ConnectionFactory.closeConnection(conexao, stmt);
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void remover(Hidrometro hidrometro) {
        try {
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(LOGICALDELETE);
            stmt.setInt(1, hidrometro.getId());

            stmt.execute();
            
            hidrometro.setId(0);
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public ArrayList<Hidrometro> listar() {
        try {
            ArrayList<Hidrometro> arrhidrometro = new ArrayList<Hidrometro>();
            
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTALL);

            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Hidrometro hidrometro = new Hidrometro();
                hidrometro.setId(rs.getInt("id"));
                hidrometro.setIdentificador(rs.getString("identificador"));
                hidrometro.setChave(rs.getString("chave"));
                hidrometro.setDescricao(rs.getString("descricao"));
                hidrometro.setModelo(rs.getString("modelo"));
                hidrometro.setAtivo(rs.getInt("ativo") == 1);
                arrhidrometro.add(hidrometro);
            }
            return arrhidrometro;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
    
}

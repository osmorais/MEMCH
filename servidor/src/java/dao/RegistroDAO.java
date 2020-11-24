/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.InterfaceDAO.IRegistroDAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import modelo.Hidrometro;
import modelo.Registro;
import util.ConnectionFactory;

/**
 *
 * @author osmar
 */
public class RegistroDAO implements IRegistroDAO{
//                                   Table "public.registro"
//    Column    |     Type     |                       Modifiers                       
//--------------+--------------+-------------------------------------------------------
// id           | integer      | not null default nextval('registro_id_seq'::regclass)
// valor        | numeric(8,3) | 
// data         | date         | 
// hidrometrofk | integer      | not null
//Indexes:
//    "registro_pkey" PRIMARY KEY, btree (id)
//Foreign-key constraints:
//    "fk_hidrometro" FOREIGN KEY (hidrometrofk) REFERENCES hidrometro(id)

    private final String SELECTALL = "SELECT * FROM REGISTRO WHERE HIDROMETROFK=? ORDER BY ID;";
    private final String SELECTBYMONTH = "SELECT * FROM ("
	+ "SELECT COALESCE((SELECT MAX(VALOR) FROM REGISTRO WHERE HIDROMETROFK = ? AND extract(month from data) = 1), 0) AS valor UNION ALL "
 	+ "SELECT COALESCE((SELECT MAX(VALOR) FROM REGISTRO WHERE HIDROMETROFK = ? AND extract(month from data) = 2), 0) UNION ALL "
	+ "SELECT COALESCE((SELECT MAX(VALOR) FROM REGISTRO WHERE HIDROMETROFK = ? AND extract(month from data) = 3), 0) UNION ALL "
	+ "SELECT COALESCE((SELECT MAX(VALOR) FROM REGISTRO WHERE HIDROMETROFK = ? AND extract(month from data) = 4), 0) UNION ALL "
	+ "SELECT COALESCE((SELECT MAX(VALOR) FROM REGISTRO WHERE HIDROMETROFK = ? AND extract(month from data) = 5), 0) UNION ALL "
	+ "SELECT COALESCE((SELECT MAX(VALOR) FROM REGISTRO WHERE HIDROMETROFK = ? AND extract(month from data) = 6), 0) UNION ALL "
	+ "SELECT COALESCE((SELECT MAX(VALOR) FROM REGISTRO WHERE HIDROMETROFK = ? AND extract(month from data) = 7), 0) UNION ALL "
	+ "SELECT COALESCE((SELECT MAX(VALOR) FROM REGISTRO WHERE HIDROMETROFK = ? AND extract(month from data) = 8), 0) UNION ALL "
	+ "SELECT COALESCE((SELECT MAX(VALOR) FROM REGISTRO WHERE HIDROMETROFK = ? AND extract(month from data) = 9), 0) UNION ALL "
	+ "SELECT COALESCE((SELECT MAX(VALOR) FROM REGISTRO WHERE HIDROMETROFK = ? AND extract(month from data) = 10), 0) UNION ALL "
	+ "SELECT COALESCE((SELECT MAX(VALOR) FROM REGISTRO WHERE HIDROMETROFK = ? AND extract(month from data) = 11), 0) UNION ALL "
	+ "SELECT COALESCE((SELECT MAX(VALOR) FROM REGISTRO WHERE HIDROMETROFK = ? AND extract(month from data) = 12), 0)) AS REGISTROS;";
    private final String SELECTID = "SELECT * FROM REGISTRO WHERE ID=?;";
    private static final String INSERT = "INSERT INTO REGISTRO "
            + "(VALOR, DATA) VALUES "
            + "(?,?)";
    private static final String DELETE = "DELETE FROM REGISTRO WHERE ID=?";
    private static final String UPDATE = "UPDATE REGISTRO "
            + "SET VALOR=?,DATA=?"
            + " WHERE ID=?";
    private Connection conexao;
    
    @Override
    public void cadastrar(Registro registro) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void consultar(Registro registro) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void alterar(Registro registro) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void remover(Registro registro) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Registro> listar(Hidrometro hidrometro) {
        try {
            ArrayList<Registro> arrregistro = new ArrayList<Registro>();
            
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTALL);
            stmt.setInt(1, hidrometro.getId());
            
            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Registro registro = new Registro();
                registro.setId(rs.getInt("id"));
                registro.setValor(rs.getDouble("valor"));
                registro.setData(rs.getDate("data"));
                arrregistro.add(registro);
            }
            return arrregistro;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    public ArrayList<Registro> listarMensal(Hidrometro hidrometro) {
        try {
            ArrayList<Registro> arrregistro = new ArrayList<Registro>();
            
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTBYMONTH);
            stmt.setInt(1, hidrometro.getId());
            stmt.setInt(2, hidrometro.getId());
            stmt.setInt(3, hidrometro.getId());
            stmt.setInt(4, hidrometro.getId());
            stmt.setInt(5, hidrometro.getId());
            stmt.setInt(6, hidrometro.getId());
            stmt.setInt(7, hidrometro.getId());
            stmt.setInt(8, hidrometro.getId());
            stmt.setInt(9, hidrometro.getId());
            stmt.setInt(10, hidrometro.getId());
            stmt.setInt(11, hidrometro.getId());
            stmt.setInt(12, hidrometro.getId());
            
            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Registro registro = new Registro();
                registro.setValor(rs.getDouble("valor"));
                arrregistro.add(registro);
            }
            return arrregistro;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
}

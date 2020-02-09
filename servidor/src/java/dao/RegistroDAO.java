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
import modelo.Registro;
import util.ConnectionFactory;

/**
 *
 * @author osmar
 */
public class RegistroDAO implements IRegistroDAO{
    private final String SELECTALL = "SELECT * FROM REGISTRO;";
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
        try {
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(INSERT,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setDouble(1, registro.getValor());
            stmt.setDate(2, new java.sql.Date(registro.getData().getTime()));
            
            stmt.execute();
            
            ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                registro.setId(rs.getInt(1));
            }
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
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
    public ArrayList<Registro> listar() {
        try {
            ArrayList<Registro> arrregistro = new ArrayList<Registro>();
            
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTALL);

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
    
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.InterfaceDAO.IAlertaDAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import modelo.Alerta;
import modelo.Hidrometro;
import modelo.Regra;
import util.ConnectionFactory;

/**
 *
 * @author pi
 */
public class AlertaDAO implements IAlertaDAO{
//                                        Table "public.alerta"
//    Column    |          Type          |                      Modifiers                      
//--------------+------------------------+-----------------------------------------------------
// id           | integer                | not null default nextval('alerta_id_seq'::regclass)
// data         | date                   | 
// hidrometrofk | integer                | not null
// regrafk      | integer                | not null
// descricao    | character varying(100) | 
// regra        | character varying(200) | 
//Indexes:
//    "alerta_pkey" PRIMARY KEY, btree (id)
//Foreign-key constraints:
//    "fk_hidrometro" FOREIGN KEY (hidrometrofk) REFERENCES hidrometro(id)
//    "fk_regra" FOREIGN KEY (regrafk) REFERENCES regra(id)

    private final String SELECTALL = "SELECT * FROM ALERTA WHERE HIDROMETROFK=? order by ID;";
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
    public void cadastrar(Alerta alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void consultar(Alerta alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void alterar(Alerta alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void remover(Alerta alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Alerta> listar(Hidrometro hidrometro) {
       try {
            ArrayList<Alerta> arralerta = new ArrayList<Alerta>();
            
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTALL);
            stmt.setInt(1, hidrometro.getId());

            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Alerta alerta = new Alerta();
                alerta.setId(rs.getInt("id"));
                alerta.setDescricao(rs.getString("descricao"));
                alerta.setData(rs.getDate("data"));
                alerta.setDescricaoRegra(rs.getString("regra"));
                
                RegraDAO regradao = new RegraDAO();
                Regra regra = new Regra();
                
                regra.setId(rs.getInt("regrafk"));
                regradao.consultar(regra);
                
                alerta.setRegra(regra);
                
                arralerta.add(alerta);
            }
            return arralerta;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
    
}
